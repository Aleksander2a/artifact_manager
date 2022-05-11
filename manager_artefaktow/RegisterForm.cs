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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form menu_form = new MenuForm();
            menu_form.ShowDialog();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            string username = (UserName_textBox.Text).Trim();
            string password = (Password_textBox.Text).Trim();
            string confirmPassword = (Confirm_Password_textBox.Text).Trim();
            string registrationMessage = Registration.Register(username, password, confirmPassword);
            if (registrationMessage == Registration.SuccessMessage)
            {
                MessageBox.Show(registrationMessage);
                // navigate to home page
                this.FindForm().Hide();
                Form menu_form = new MenuForm();
                menu_form.ShowDialog();
                return;
            }
            else
            {
                UserName_textBox.Clear();
                Password_textBox.Clear();
                Confirm_Password_textBox.Clear();
                MessageBox.Show(registrationMessage);
                return;
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
