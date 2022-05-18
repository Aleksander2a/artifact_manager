using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager_artefaktow.Forms
{
    public partial class InstancesForm : Form
    {
        public InstancesForm()
        {
            InitializeComponent();
        }

        private void BrowseArtifacts_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form browseArtifactsForm = new BrowseArtifactsForm();
            browseArtifactsForm.ShowDialog();
        }

        private void InstancesForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Instances' . Możesz go przenieść lub usunąć.
            this.instancesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Instances);

        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled


            //Update button update dataset after insertion,upadtion or deletion
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            /*
            string message = "OK";
            for (int i = 0; i < Users_dataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < Users_dataGridView.Rows.Count - 1; j++)
                {
                    string cell = Users_dataGridView.Rows[j].Cells[i].Value as string;
                    if (cell == null || (cell.Trim()).Length == 0)
                    {
                        //MessageBox.Show("Wrong input values. Press ESC to discard or input new value");
                        message = "An error occured\nrow " + j + ", column " + i;
                        Users_dataGridView.Rows[j].Cells[i].Value = "Wrong!"; // WORKS !!!!

                    }
                    else
                    {
                        if (i==1)
                        {
                            Users_dataGridView.Rows[j].Cells[i].Value = UserManagement.encryptPassword(cell);
                        }
                    }
                }
            }
            */
            if (dr == DialogResult.Yes)
            {
                //if (message == "OK")
                //{
                this.instancesTableAdapter.Update(artifactManagerDatabaseDataSet.Instances);
                Instances_dataGridView.Refresh();

                MessageBox.Show("Changes Saved");
                //}
                //else
                //{
                //    MessageBox.Show(message);
                //}
            }
        }
    }
}
