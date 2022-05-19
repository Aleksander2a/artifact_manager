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
    public partial class UserDetailsForm : Form
    {
        private User USER;
        string OLD_USER_NAME = "";
        string OLD_PASSWORD = "";
        string OLD_ROLE_NAME = "";

        public UserDetailsForm(string text)
        {
            USER = UserManagement.FindUser(text);
            OLD_USER_NAME = text;
            OLD_PASSWORD = USER.Password;
            OLD_ROLE_NAME = USER.RoleName;
            InitializeComponent();
        }

        private void UserDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Roles' . Możesz go przenieść lub usunąć.
            this.rolesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Roles);

            UserName_textBox.Text = USER.UserName;
            Password_textBox.Text = USER.Password;

            int index = 0;
            foreach (var role in RoleManagement.GetAllRolesNames())
            {
                comboBox1.Items.Add(role);
                if (role == USER.RoleName)
                {
                    comboBox1.SelectedIndex = index;
                }
                index++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = UserName_textBox.Text.Trim();
            string password = Password_textBox.Text.Trim();
            string roleName = comboBox1.Text.Trim();
            if (userName.Length == 0 || password.Length == 0 || roleName.Length == 0)
            {
                MessageBox.Show("Invalid input");
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr != DialogResult.Yes)
            {
                MessageBox.Show("No changes saved");
                return;
            }
            if (!UserManagement.UserExists(userName))
            {
                UserManagement.EditUser(OLD_USER_NAME, userName, password, roleName);
                MessageBox.Show("User modified");
                OLD_USER_NAME = userName;
                OLD_PASSWORD = password;
                OLD_ROLE_NAME = roleName;
            }
            else
            {
                if (userName == OLD_USER_NAME)
                {
                    UserManagement.EditUser(OLD_USER_NAME, userName, password, roleName);
                    MessageBox.Show("User modified");
                    OLD_USER_NAME = userName;
                    OLD_PASSWORD = password;
                    OLD_ROLE_NAME = roleName;
                }
                else
                {
                    MessageBox.Show("User with such name already exists");
                    button2_Click(sender, e);
                }
            }
        }

        private void Users_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form usersForm = new UsersForm();
            usersForm.ShowDialog();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserName_textBox.Text = OLD_USER_NAME;
            Password_textBox.Text = OLD_PASSWORD;
            comboBox1.Items.Clear();
            int index = 0;
            foreach (var role in RoleManagement.GetAllRolesNames())
            {
                comboBox1.Items.Add(role);
                if (role == OLD_ROLE_NAME)
                {
                    comboBox1.SelectedIndex = index;
                }
                index++;
            }
        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            Encrypt_textBox.Text = UserManagement.encryptPassword(Encrypt_textBox.Text);
        }
    }
}
