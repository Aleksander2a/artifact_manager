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
            
            if (dr == DialogResult.Yes)
            {
                this.usersTableAdapter.Update(artifactManagerDatabaseDataSet.Users);
                Users_dataGridView.Refresh();
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
    }
}
