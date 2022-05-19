using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using manager_artefaktow.Data;
using manager_artefaktow.Data.Models;
using manager_artefaktow.BusinessLogic;

namespace manager_artefaktow.Forms
{
    public partial class InstancesForm : Form
    {
        public InstancesForm()
        {
            InitializeComponent();
        }

        private void BrowseArtifacts_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form browseArtifactsForm = new BrowseArtifactsForm();
            browseArtifactsForm.ShowDialog();
        }

        private void InstancesForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Users);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Categories' . Możesz go przenieść lub usunąć.
            this.categoriesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Categories);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Instances' . Możesz go przenieść lub usunąć.
            this.instancesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Instances);

            if (String.IsNullOrEmpty(LoggedUser.UserName))
            {
                AddInstance_button.Enabled = false;
                Instances_dataGridView.AllowUserToDeleteRows = false;
            }

            CategoryFilter_comboBox.SelectedIndex = -1;
            CreatorFilter_comboBox.SelectedIndex = -1;
            Filter_button.Enabled = false;
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled


            //Update button update dataset after insertion,upadtion or deletion
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if (dr == DialogResult.Yes)
            {
                this.instancesTableAdapter.Update(artifactManagerDatabaseDataSet.Instances);
                Instances_dataGridView.Refresh();
                MessageBox.Show("Changes Saved");
            }
        }

        private void Instances_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string instanceName = e.Row.Cells[0].Value.ToString();
            if (!InstanceManagement.InstanceExists(instanceName))
            {
                MessageBox.Show("Instance does not exist");
                e.Cancel = true;
                return;
            }
            string instanceCreator = InstanceManagement.FindInstanceCreator(instanceName);
            // Check permissions !
            if (!RoleManagement.isRoleOk(LoggedUser.RoleName, PermissionManagement.type_delete, PermissionManagement.subject_instances, PermissionManagement.scopes_all))
            {
                if (!RoleManagement.isRoleOk(LoggedUser.RoleName, PermissionManagement.type_delete, PermissionManagement.subject_instances, instanceName))
                {
                    if (instanceCreator == LoggedUser.UserName)
                    {
                        if (!RoleManagement.isRoleOk(LoggedUser.RoleName, PermissionManagement.type_delete, PermissionManagement.subject_instances, PermissionManagement.scopes_own))
                        {
                            MessageBox.Show("You do not have permission to perform this action");
                            e.Cancel = true;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to perform this action");
                        e.Cancel = true;
                        return;
                    }
                }
            }
            

            if (!InstanceManagement.InstanceExists(instanceName))
            {
                MessageBox.Show("You cannot delete this row");
                e.Cancel = true;
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure to delete this row", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Instances_dataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.instancesTableAdapter.Update(artifactManagerDatabaseDataSet.Instances);
            Instances_dataGridView.Refresh();
            MessageBox.Show("Row deleted");
        }

        private void InstancesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddInstance_button_Click(object sender, EventArgs e)
        {
            if (!RoleManagement.isRoleOk(LoggedUser.RoleName, PermissionManagement.type_create, PermissionManagement.subject_instances, "None"))
            {
                MessageBox.Show("You do not have permission to perform this action");
                return;
            }
            this.FindForm().Hide();
            Form addArtifactForm = new AddInstanceForm();
            addArtifactForm.ShowDialog();
        }

        private void ArtifactDetails_button_Click(object sender, EventArgs e)
        {
            if (CategoryName_textBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Invalid artifact");
                return;
            }
            this.FindForm().Hide();
            Form artifactDetailsForm = new ArtifactDetailsForm(CategoryName_textBox.Text, textBox1.Text); // Artifact Name, Category Name
            artifactDetailsForm.ShowDialog();
        }

        private void Instances_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (row >= 0 && row < Instances_dataGridView.RowCount)
            {
                CategoryName_textBox.Text = Instances_dataGridView.Rows[row].Cells[0].Value.ToString();
                string artifactName = CategoryName_textBox.Text; // Yes, it is correct! 

                Instance instance = InstanceManagement.FindInstanceByName(artifactName);
                if (instance == null)
                {
                    return;
                }

                textBox1.Text = Instances_dataGridView.Rows[row].Cells[2].Value.ToString();
                textBox2.Text = Instances_dataGridView.Rows[row].Cells[3].Value.ToString();
                textBox3.Text = Instances_dataGridView.Rows[row].Cells[1].Value.ToString();

            }
        }

        private void RemoveCategoryFilter_button_Click(object sender, EventArgs e)
        {
            CategoryFilter_comboBox.SelectedIndex = -1;
            this.categoriesBindingSource.RemoveFilter();
            Filter_button_Click(sender, e);
        }

        private void RemoveCreatorFilter_button_Click(object sender, EventArgs e)
        {
            CreatorFilter_comboBox.SelectedIndex = -1;
            this.categoriesBindingSource.RemoveFilter();
            Filter_button_Click(sender, e);
        }

        private void Filter_button_Click(object sender, EventArgs e)
        {
            string filter = "";
            string categoryFilter = CategoryFilter_comboBox.Text;
            string creatorFilter = CreatorFilter_comboBox.Text;
            if (String.IsNullOrEmpty(categoryFilter))
            {
                if (String.IsNullOrEmpty(creatorFilter))
                {
                    this.instancesBindingSource.RemoveFilter();
                    Filter_button.Enabled = false;
                    return;
                }
                else
                {
                    filter = "CreatorName='" + creatorFilter + "'";
                }
            }
            else
            {
                filter = "CategoryName='" + categoryFilter + "'";
                if (String.IsNullOrEmpty(creatorFilter))
                {
                    // nothing...
                }
                else
                {
                    filter += " AND CreatorName='" + creatorFilter + "'";
                }
            }
            this.instancesBindingSource.Filter = filter;
        }

        private void CategoryFilter_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filter_button.Enabled==false)
            {
                Filter_button.Enabled = true;
            }
        }

        private void CreatorFilter_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filter_button.Enabled==false)
            {
                Filter_button.Enabled = true;
            }
        }
    }
}
