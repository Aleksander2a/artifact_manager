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

        private void Menu_button_Click(object sender, EventArgs e)
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
            if (dr == DialogResult.Yes)
            {
                this.usersTableAdapter.Update(artifactManagerDatabaseDataSet.Users);
                Users_dataGridView.Refresh();
                MessageBox.Show("Changes Saved");
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Users);
        }

        private void Users_dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("An error occured");
        }

        private void Users_dataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
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
        }
    }
}
