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
using manager_artefaktow.Data;
using manager_artefaktow.Data.Models;


namespace manager_artefaktow.Forms
{
    public partial class BrowseArtifactsForm : Form
    {
        private int ADMIN_LOGGEDIN_UNLOGGED; // 0-Admin, 1-logged, 2-unlogged
        public BrowseArtifactsForm()
        {
            InitializeComponent();
        }

        private void BrowseArtifactsForm_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(LoggedUser.UserName))
            {
                if (LoggedUser.UserName == "Admin")
                {
                    ADMIN_LOGGEDIN_UNLOGGED = 0;
                }
                else
                {
                    ADMIN_LOGGEDIN_UNLOGGED = 1;
                }
            }
            else
            {
                ADMIN_LOGGEDIN_UNLOGGED = 2;
            }
        }

        private void Categories_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form categoriesForm = new Categories();
            categoriesForm.ShowDialog();
        }

        private void Artifacts_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form instancesForm = new InstancesForm();
            instancesForm.ShowDialog();
        }

        private void BrowseArtifactsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ADMIN_LOGGEDIN_UNLOGGED == 0)
            {
                this.FindForm().Hide();
                Form adminPanelForm = new AdminPanelForm();
                adminPanelForm.ShowDialog();
            }
            else if (ADMIN_LOGGEDIN_UNLOGGED == 1)
            {
                this.FindForm().Hide();
                Form userHomePageForm = new UserHomePageForm();
                userHomePageForm.ShowDialog();
            }
            else
            {
                this.FindForm().Hide();
                Form menuForm = new MenuForm();
                menuForm.ShowDialog();
            }
        }
    }
}
