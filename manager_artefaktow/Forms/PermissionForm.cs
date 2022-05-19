using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using manager_artefaktow.BusinessLogic;
using manager_artefaktow.Data;
using manager_artefaktow.Data.Models;

namespace manager_artefaktow
{
    public partial class PermissionForm : Form
    {
        public PermissionForm()
        {
            InitializeComponent();
        }

        private void AdminPanel_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form adminPanelForm = new AdminPanelForm();
            adminPanelForm.ShowDialog();
            return;
        }

        private void PermissionForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Permissions' . Możesz go przenieść lub usunąć.
            this.permissionsTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Permissions);

            foreach (var type in PermissionManagement.GetAllPermissionTypes())
            {
                Type_comboBox.Items.Add(type);
            }
            Type_comboBox.SelectedIndex = -1;
            foreach (var subject in PermissionManagement.GetAllPermissionSubjects())
            {
                CatORIns_comboBox.Items.Add(subject);
            }
            CatORIns_comboBox.SelectedIndex = -1;
            /*
            foreach (var scope in PermissionManagement.GetAllPermissionScopesForSubject())
            {
                Scope_comboBox.Items.Add(scope);
            }
            Scope_comboBox.SelectedIndex = -1;
            */
            foreach (var owner in PermissionManagement.GetAllPermissionOwners())
            {
                Owner_comboBox.Items.Add(owner);
            }
            CatORIns_comboBox.SelectedIndex = -1;
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            if (Type_comboBox.SelectedIndex == -1 || CatORIns_comboBox.SelectedIndex == -1 || Scope_comboBox.SelectedIndex == -1 || Description_textBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Invalid input");
                return;
            }

            //Update button update dataset after insertion,upadtion or deletion
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if (dr == DialogResult.Yes)
            {
                this.permissionsTableAdapter.Update(artifactManagerDatabaseDataSet.Permissions);
                Permissions_dataGridView.Refresh();
                MessageBox.Show("Changes Saved");
            }
        }

        private void Permissions_dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("DataError: An error occured\n" + e.Exception.Message + "\nrow " + e.RowIndex + ", column " + e.ColumnIndex);
        }

        private void PermissionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CatORIns_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type_comboBox.Text == PermissionManagement.type_create)
            {
                return;
            }
            Scope_comboBox.Items.Clear();
            foreach (var scope in PermissionManagement.GetAllPermissionScopesForSubject(CatORIns_comboBox.Text))
            {
                Scope_comboBox.Items.Add(scope);
            }
            Scope_comboBox.SelectedIndex = -1;
        }

        private void Type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type_comboBox.Text == PermissionManagement.type_create)
            {
                Scope_comboBox.Items.Clear();
                Scope_comboBox.SelectedIndex = -1;
                //Scope_comboBox.Text = "None";
                Scope_comboBox.Enabled = false;
            }
            else
            {
                Scope_comboBox.Items.Clear();
                Scope_comboBox.SelectedIndex = -1;
                Scope_comboBox.Enabled = true;

                if (CatORIns_comboBox.SelectedIndex != -1)
                {
                    foreach (var scope in PermissionManagement.GetAllPermissionScopesForSubject(CatORIns_comboBox.Text))
                    {
                        Scope_comboBox.Items.Add(scope);
                    }
                }
            }
        }

        private void AddRole_button_Click(object sender, EventArgs e)
        {
            string type = Type_comboBox.Text.Trim();
            string subject = CatORIns_comboBox.Text.Trim();
            string scope = Scope_comboBox.Text.Trim();
            string owner = Owner_comboBox.Text.Trim();
            string description = Description_textBox.Text.Trim();
            if (type != PermissionManagement.type_create)
            {
                if (type.Length == 0 || subject.Length == 0 || scope.Length == 0 || owner.Length == 0 || description.Length == 0)
                {
                    MessageBox.Show("Invalid input");
                    return;
                }
            }
            else
            {
                if (type.Length == 0 || subject.Length == 0 || owner.Length == 0 || description.Length == 0)
                {
                    MessageBox.Show("Invalid input");
                    return;
                }
            }

            DialogResult dr = MessageBox.Show("Are you sure to save changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr != DialogResult.Yes)
            {
                return;
            }
            string permissionName = type + ";" + subject + ";" + scope + ";" + owner;
            if (PermissionManagement.PermissionExists(permissionName))
            {
                MessageBox.Show("Such permission already exists");
                return;
            }
            PermissionManagement.AddPermission(permissionName, description);
            this.permissionsTableAdapter.Fill(artifactManagerDatabaseDataSet.Permissions);
            Permissions_dataGridView.Refresh();
            MessageBox.Show("Permission added successfully");
        }

        private void Permissions_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this row", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void Permissions_dataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.permissionsTableAdapter.Update(artifactManagerDatabaseDataSet.Permissions);
            Permissions_dataGridView.Refresh();
            MessageBox.Show("Row deleted");
        }
    }
}
