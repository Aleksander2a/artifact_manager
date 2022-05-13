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

namespace manager_artefaktow
{
    public partial class RolesForm : Form
    {
        public RolesForm()
        {
            InitializeComponent();
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet3.Permissions' . Możesz go przenieść lub usunąć.
            this.permissionsTableAdapter2.Fill(this.artifactManagerDatabaseDataSet3.Permissions);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet3.Roles' . Możesz go przenieść lub usunąć.
            this.rolesTableAdapter3.Fill(this.artifactManagerDatabaseDataSet3.Roles);
        }

        private void Roles_dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("DataError: An error occured\nrow " + e.RowIndex + ", column " + e.ColumnIndex);
        }

        private void AdminPanel_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form adminPanelForm = new AdminPanelForm();
            adminPanelForm.ShowDialog();
            return;
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            //Update button update dataset after insertion,upadtion or deletion
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            /*
            string message = "OK";
            for (int i = 0; i < Roles_dataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < Roles_dataGridView.Rows.Count-1; j++)
                {
                    string cell = Roles_dataGridView.Rows[j].Cells[i].Value as string;
                    if (cell == null || (cell.Trim()).Length == 0)
                    {
                        //MessageBox.Show("Wrong input values. Press ESC to discard or input new value");
                        message = "An error occured\nrow " + j + ", column " + i;
                        Roles_dataGridView.Rows[j].Cells[i].Value = "Wrong!"; // WORKS !!!!

                    }
                }
            }
            */
            if (dr == DialogResult.Yes)
            {
                //if(message == "OK")
                //{
                    this.rolesTableAdapter3.Update(artifactManagerDatabaseDataSet3.Roles);
                    Roles_dataGridView.Refresh();
                    MessageBox.Show("Changes Saved");
                //}
                //else
                //{
                //    MessageBox.Show(message);
                //}
            }
        }

        private void RolesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Roles_dataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //for (int i = 0; i < Roles_dataGridView.Columns.Count; i++)
            //{
            /*
                for (int j = 0; j < Roles_dataGridView.Columns.Count; j++)
                {
                    string cell = Roles_dataGridView.Rows[e.RowIndex].Cells[j].Value as string;
                    if (cell == null || (cell.Trim()).Length == 0)
                    {
                        MessageBox.Show("RowValidating: An error occured\nrow " + e.RowIndex + ", column " + j);
                        e.Cancel = true;

                    }
                }
            */
            //}
        }

        private void Roles_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if(row >= 0 && row < Roles_dataGridView.RowCount-1)
            {
                RoleName_textBox.Text = Roles_dataGridView.Rows[row].Cells[0].Value.ToString();
                string roleName = RoleName_textBox.Text;

                var allPermissions = PermissionManagement.getAllPermissionsNames();
                var rolePermissions = RoleManagement.findPermissionsForRoleName(roleName);

                Permissions_checkedListBox.Items.Clear();
                int index = 0;
                foreach(var permission in allPermissions)
                {
                    Permissions_checkedListBox.Items.Add(permission);
                    if (rolePermissions.Contains(permission))
                    {
                        Permissions_checkedListBox.SetItemChecked(index, true);
                    }
                    index++;
                }
                
            }
        }
    }
}
