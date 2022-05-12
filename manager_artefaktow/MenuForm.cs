using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager_artefaktow
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void Top_Artifacts_button_Click(object sender, EventArgs e)
        {

        }

        private void Browse_Artifacts_button_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
