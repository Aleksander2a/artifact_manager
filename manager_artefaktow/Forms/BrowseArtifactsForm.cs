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
        public BrowseArtifactsForm()
        {
            InitializeComponent();
        }

        private void BrowseArtifactsForm_Load(object sender, EventArgs e)
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

        private void BrowseArtifactsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
