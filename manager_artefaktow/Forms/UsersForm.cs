using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using manager_artefaktow.Forms;

using BCryptNet = BCrypt.Net.BCrypt;
using manager_artefaktow.Data;
using manager_artefaktow.Data.Models;
using manager_artefaktow.BusinessLogic;

namespace manager_artefaktow
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled


            //Update button update dataset after insertion,upadtion or deletion
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if (dr == DialogResult.Yes)
            {
                //this.usersTableAdapter.Update(artifactManagerDatabaseDataSet.Users);
                //Users_dataGridView.Refresh();
                AppPropertiesManagement.SetOrCreatePropertyWithValue("DefaultRole", DefaultRole_comboBox.Text);
                MessageBox.Show("Changes Saved");
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Roles' . Możesz go przenieść lub usunąć.
            this.rolesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Roles);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Users);

            // Set default role for registration
            if (AppPropertiesManagement.PropertyExists("DefaultRole"))
            {
                DefaultRole_comboBox.Text = AppPropertiesManagement.GetPropertyValue("DefaultRole");
            }
            else
            {
                DefaultRole_comboBox.Text = DefaultRole_comboBox.Items[0].ToString();
            }

            NewUserRole_comboBox.SelectedIndex = -1;
        }

        private void Users_dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("DataError: An error occured\n" + e.Exception.Message + "\nrow " + e.RowIndex + ", column " + e.ColumnIndex);
        }

        private void Users_dataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void AdminPanel_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form adminPanelForm = new AdminPanelForm();
            adminPanelForm.ShowDialog();
            return;
        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            Encrypt_textBox.Text = UserManagement.encryptPassword(Encrypt_textBox.Text);
        }

        private void AddUser_button_Click(object sender, EventArgs e)
        {
            string userName = NewUserName_textBox.Text.Trim();
            string password = NewUserPassword_textBox.Text.Trim();
            if (string.IsNullOrEmpty(NewUserRole_comboBox.Text) || userName.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Invalid values");
                return;
            }
            string roleName = NewUserRole_comboBox.Text.Trim();
            if (!UserManagement.UserExists(userName))
            {
                DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    UserManagement.AddUser(userName, password, roleName);
                    this.usersTableAdapter.Fill(artifactManagerDatabaseDataSet.Users);
                    Users_dataGridView.Refresh();
                    MessageBox.Show("User added");
                }
                else
                {
                    MessageBox.Show("No changes saved");
                }
            }
            else
            {
                MessageBox.Show("User with this name already exists");
            }
            NewUserName_textBox.Clear();
            NewUserPassword_textBox.Clear();
            NewUserRole_comboBox.SelectedIndex = -1;
        }

        private void NewUserClear_button_Click(object sender, EventArgs e)
        {
            NewUserName_textBox.Clear();
            NewUserPassword_textBox.Clear();
            NewUserRole_comboBox.SelectedIndex = -1;
        }

        private void Users_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string userName = e.Row.Cells[0].Value.ToString();
            if (userName == LoggedUser.UserName)
            {
                MessageBox.Show("You cannot delete your own account as an Admin");
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

        private void Users_dataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.usersTableAdapter.Update(artifactManagerDatabaseDataSet.Users);
            Users_dataGridView.Refresh();
            MessageBox.Show("Row deleted");
        }

        private void Users_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (row >= 0 && row < Users_dataGridView.RowCount)
            {
                UserDetails_textBox.Text = Users_dataGridView.Rows[row].Cells[0].Value.ToString();
            }
        }

        private void UserDetails_button_Click(object sender, EventArgs e)
        {
            if (UserManagement.UserExists(UserDetails_textBox.Text))
            {
                this.FindForm().Hide();
                Form userDetailsForm = new UserDetailsForm(UserDetails_textBox.Text);
                userDetailsForm.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("No such user");
                return;
            }
        }
    }
}
