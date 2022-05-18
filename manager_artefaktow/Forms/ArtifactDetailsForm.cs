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
using manager_artefaktow.Data.Models;
using manager_artefaktow.Data;

namespace manager_artefaktow.Forms
{
    public partial class ArtifactDetailsForm : Form
    {
        private string ARTIFACT_NAME;
        private string CATEGORY_NAME;
        public ArtifactDetailsForm(string artifactName, string categoryName)
        {
            ARTIFACT_NAME = artifactName;
            CATEGORY_NAME = categoryName;
            InitializeComponent();
        }

        private void ArtifactDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.CategoryProperties' . Możesz go przenieść lub usunąć.
            this.categoryPropertiesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.CategoryProperties);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.InstanceProperties' . Możesz go przenieść lub usunąć.
            //this.instancePropertiesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.InstanceProperties);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Instances' . Możesz go przenieść lub usunąć.
            this.instancesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Instances);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Categories' . Możesz go przenieść lub usunąć.
            this.categoriesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Categories);

            Instance instance = InstanceManagement.FindInstanceByName(ARTIFACT_NAME);
            if (instance != null)
            {
                ArtifactName_textBox.Text = instance.InstanceName;
                Creator_textBox.Text = instance.CreatorName;
                Overall_numericUpDown.Value = instance.Overall;

                Category_textBox.Text = CATEGORY_NAME;
                Properties_dataGridView.Refresh();
                //Category_comboBox.Enabled = false;

                // fill dataGrid with values
                List<string> properties = CategoryManagement.FindPropertiesForCategoryName(CATEGORY_NAME);
                for (int row = 0; row < properties.Count; row++)
                {
                    Properties_dataGridView.Rows.Add(properties[row], InstanceManagement.GetValueByInstancePropertyNames(instance.InstanceName, properties[row]));
                    //Properties_dataGridView.Rows[row].Cells[0].Value = properties[row];

                    //Properties_dataGridView.Rows[row].Cells[1].Value = InstanceManagement.GetValueByInstancePropertyNames(instance.InstanceName, properties[row]);
                }

            }
            if (String.IsNullOrEmpty(LoggedUser.UserName))
            {
                Add_button.Enabled = false;
                Overall_numericUpDown.Enabled = false;
                Overall_numericUpDown.ReadOnly = true;
                Properties_dataGridView.ReadOnly = true;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            // check if all fields are ok
            string artifactName = ArtifactName_textBox.Text.Trim();
            string categoryName = Category_textBox.Text.Trim();
            int overall = (int)Overall_numericUpDown.Value;

            if (artifactName.Length == 0 || categoryName.Length == 0)
            {
                MessageBox.Show("Invalid input");
                return;
            }
            Instance instance = InstanceManagement.FindInstanceByName(ARTIFACT_NAME);

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

            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                instance.Overall = overall;
                InstanceManagement.AddOrUpdateInstance(instance);

                InstanceManagement.RemoveAllPropertyValuesForInstanceName(instance.InstanceName);

                for (int row = 0; row < Properties_dataGridView.RowCount; row++)
                {
                    string propertyName = Properties_dataGridView.Rows[row].Cells[0].Value.ToString().Trim();
                    string propertyValue = Properties_dataGridView.Rows[row].Cells[1].Value.ToString().Trim();

                    InstanceManagement.AddPropertyValueToInstance(instance.InstanceName, propertyName, propertyValue);
                }

                // this.instancesTableAdapter.Update(artifactManagerDatabaseDataSet.Instances);
                //this.instancePropertiesTableAdapter.Update(artifactManagerDatabaseDataSet.InstanceProperties);
                // this.categoriesTableAdapter.Update(artifactManagerDatabaseDataSet.Categories);
                Properties_dataGridView.Refresh();

                MessageBox.Show("Changes Saved");
            }
        }

        private void BrowseArtifacts_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form artifactsForm = new InstancesForm();
            artifactsForm.ShowDialog();
        }

    }
}
