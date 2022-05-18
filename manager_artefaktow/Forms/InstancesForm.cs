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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Instances' . Możesz go przenieść lub usunąć.
            this.instancesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Instances);

            if (String.IsNullOrEmpty(LoggedUser.UserName))
            {
                AddInstance_button.Enabled = false;
                Instances_dataGridView.AllowUserToDeleteRows = false;
            }
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled


            //Update button update dataset after insertion,upadtion or deletion
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            /*
            string message = "OK";
            for (int i = 0; i < Users_dataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < Users_dataGridView.Rows.Count - 1; j++)
                {
                    string cell = Users_dataGridView.Rows[j].Cells[i].Value as string;
                    if (cell == null || (cell.Trim()).Length == 0)
                    {
                        //MessageBox.Show("Wrong input values. Press ESC to discard or input new value");
                        message = "An error occured\nrow " + j + ", column " + i;
                        Users_dataGridView.Rows[j].Cells[i].Value = "Wrong!"; // WORKS !!!!

                    }
                    else
                    {
                        if (i==1)
                        {
                            Users_dataGridView.Rows[j].Cells[i].Value = UserManagement.encryptPassword(cell);
                        }
                    }
                }
            }
            */
            if (dr == DialogResult.Yes)
            {
                //if (message == "OK")
                //{
                this.instancesTableAdapter.Update(artifactManagerDatabaseDataSet.Instances);
                Instances_dataGridView.Refresh();

                MessageBox.Show("Changes Saved");
                //}
                //else
                //{
                //    MessageBox.Show(message);
                //}
            }
        }

        private void Instances_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string instanceName = e.Row.Cells[0].Value.ToString();
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
                //Roles_dataGridView.Rows.Remove(e.Row);
                //this.rolesTableAdapter3.Update(artifactManagerDatabaseDataSet3.Roles);
                //Roles_dataGridView.Refresh();
                //MessageBox.Show("Row deleted");
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
    }
}
