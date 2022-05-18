using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    this.usersTableAdapter.Update(artifactManagerDatabaseDataSet.Users);
                    Users_dataGridView.Refresh();
                //Registration.DefaultRoleName = DefaultRole_comboBox.Text;
                    AppPropertiesManagement.SetOrCreatePropertyWithValue("DefaultRole", DefaultRole_comboBox.Text);
                    
                    MessageBox.Show("Changes Saved");
                //}
                //else
                //{
                //    MessageBox.Show(message);
                //}
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Roles' . Możesz go przenieść lub usunąć.
            this.rolesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Roles);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Users);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet2.Roles' . Możesz go przenieść lub usunąć.
            //this.rolesTableAdapter2.Fill(this.artifactManagerDatabaseDataSet2.Roles);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet2.Users' . Możesz go przenieść lub usunąć.
            //this.usersTableAdapter2.Fill(this.artifactManagerDatabaseDataSet2.Users);

            //DefaultRole_label.MaximumSize = new Size(100, 0);
            //DefaultRole_label.AutoSize = true;

            // Set default role for registration
            //if (Registration.DefaultRoleName)
            //{

            //}
            if (AppPropertiesManagement.PropertyExists("DefaultRole"))
            {
                DefaultRole_comboBox.Text = AppPropertiesManagement.GetPropertyValue("DefaultRole");
            }
            else
            {
                DefaultRole_comboBox.Text = DefaultRole_comboBox.Items[0].ToString();
            }
        }

        private void Users_dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("DataError: An error occured\n" + e.Exception.Message + "\nrow " + e.RowIndex + ", column " + e.ColumnIndex);
        }

        private void Users_dataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            /*
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                string username = Users_dataGridView.Rows[e.RowIndex].Cells[0].Value as string;
                string password = Users_dataGridView.Rows[e.RowIndex].Cells[1].Value as string;
                //Users_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = BCrypt.Net.BCrypt.HashPassword(Users_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string);
                var dbContext = new ManagerContext();
                User user = dbContext.Users.Find(username);
                if (user != null)
                {
                    user.Password= UserManagement.encryptPassword(password);
                    dbContext.Users.Update(user);
                    dbContext.SaveChanges();
                }
                else
                {
                    if((username.Trim()).Length>0)
                    {

                    }
                    else
                    {

                    }
                }
            }
            */
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
    }
}
