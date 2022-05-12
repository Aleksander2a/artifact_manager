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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form menuForm = new MenuForm();
            menuForm.ShowDialog();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string username = (UserName_textBox.Text).Trim();
            string password = (Password_textBox.Text).Trim();
            string loggingInMessage = LoggingIn.LogIn(username, password);
            if (loggingInMessage == LoggingIn.SuccessMessage)
            {
                MessageBox.Show(loggingInMessage);
                if(username == "Admin")
                {
                    // navigate to home page
                    this.FindForm().Hide();
                    Form adminPanelForm = new AdminPanelForm();
                    adminPanelForm.ShowDialog();
                    return;
                }
                else
                {
                    // navigate to home page
                    this.FindForm().Hide();
                    Form userHomePageForm = new UserHomePageForm();
                    userHomePageForm.ShowDialog();
                    return;
                }
            }
            else
            {
                UserName_textBox.Clear();
                Password_textBox.Clear();
                MessageBox.Show(loggingInMessage);
                return;
            }
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
