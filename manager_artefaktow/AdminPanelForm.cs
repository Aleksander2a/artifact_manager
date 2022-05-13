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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void Roles_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form rolesForm = new RolesForm();
            rolesForm.ShowDialog();
        }

        private void Users_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form usersForm = new UsersForm();
            usersForm.ShowDialog();
        }

        private void Permissions_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form permissionForm = new PermissionForm();
            permissionForm.ShowDialog();
        }

        private void AdminPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
