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

namespace manager_artefaktow
{
    public partial class UserHomePageForm : Form
    {
        public UserHomePageForm()
        {
            InitializeComponent();
        }

        private void UserHomePageForm_Load(object sender, EventArgs e)
        {

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

        private void Browse_Artifacts_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form browseArtifactsForm = new BrowseArtifactsForm();
            browseArtifactsForm.ShowDialog();
        }

        private void ChangePassword_button_Click(object sender, EventArgs e)
        {

        }
    }
}
