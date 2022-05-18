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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSetFull.Categories' . Możesz go przenieść lub usunąć.
            //this.categoriesTableAdapter.Fill(this.artifactManagerDatabaseDataSetFull.Categories);

            /*
            List<string> baseCategories = CategoryManagement.FindBaseCategoriesNames();
            Category_treeView.Nodes.Clear();
            List<TreeNode> nodes = new List<TreeNode>();
            List<string> childrenQueue = new List<string>();
            foreach (var category in baseCategories)
            {
                nodes.Add(new TreeNode(category));
                childrenQueue.AddRange(CategoryManagement.FindAllNearesChildrenOfCategoryName(category));
                while (childrenQueue.Count > 0)
                {

                }
            }
            Category_treeView.Nodes.Add;
            */
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
