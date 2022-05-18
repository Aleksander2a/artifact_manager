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
    public partial class AddInstanceForm : Form
    {
        public AddInstanceForm()
        {
            InitializeComponent();
        }

        private void AddInstanceForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.CategoryProperties' . Możesz go przenieść lub usunąć.
            this.categoryPropertiesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.CategoryProperties);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Categories' . Możesz go przenieść lub usunąć.
            this.categoriesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Categories);

            Creator_textBox.Text = LoggedUser.UserName;
        }

        private void AddInstanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BrowseArtifacts_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form instancesForm = new InstancesForm();
            instancesForm.ShowDialog();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string artifactName = ArtifactName_textBox.Text.Trim();
            string categoryName = Category_comboBox.Text.Trim();
            string creatorName = Creator_textBox.Text.Trim();
            int overall = (int)Overall_numericUpDown.Value;

            if (artifactName.Length == 0 || categoryName.Length == 0 || creatorName.Length == 0)
            {
                MessageBox.Show("Invalid input");
                return;
            }
            for (int row = 0; row < Properties_dataGridView.RowCount; row++)
            {
                for (int col = 0; col < Properties_dataGridView.ColumnCount; col++)
                {
                    if (Properties_dataGridView.Rows[row].Cells[1].Value.ToString().Trim().Length == 0)
                    {
                        MessageBox.Show("Invalid value in the properties section");
                        return;
                    }
                }
            }
            if (InstanceManagement.InstanceExists(artifactName))
            {
                MessageBox.Show("Artifact with this name already exists");
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr != DialogResult.Yes)
            {
                MessageBox.Show("No changes made");
                return;
            }

            InstanceManagement.AddInstanceOnly(artifactName, creatorName, categoryName, overall);

            for (int row = 0; row < Properties_dataGridView.RowCount; row++)
            {
                string propName = Properties_dataGridView.Rows[row].Cells[0].Value.ToString().Trim();
                string propVal = Properties_dataGridView.Rows[row].Cells[1].Value.ToString().Trim();
                InstanceManagement.AddPropertyValueToInstance(artifactName, propName, propVal);
            }

            MessageBox.Show("Artifact added successfully");
            // Clear fields
            ArtifactName_textBox.Clear();
            Creator_textBox.Clear();
            Overall_numericUpDown.Value = 0;
            for (int row = 0; row < Properties_dataGridView.RowCount; row++)
            {
                Properties_dataGridView.Rows[row].Cells[1].Value = "";
            }

            return;
        }
    }
}
