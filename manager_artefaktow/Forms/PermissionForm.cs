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
    public partial class PermissionForm : Form
    {
        public PermissionForm()
        {
            InitializeComponent();
        }

        private void AdminPanel_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form adminPanelForm = new AdminPanelForm();
            adminPanelForm.ShowDialog();
            return;
        }

        private void PermissionForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Permissions' . Możesz go przenieść lub usunąć.
            this.permissionsTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Permissions);

        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            //Update button update dataset after insertion,upadtion or deletion
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            /*
            string message = "OK";
            for (int i = 0; i < Permissions_dataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < Permissions_dataGridView.Rows.Count - 1; j++)
                {
                    string cell = Permissions_dataGridView.Rows[j].Cells[i].Value as string;
                    if (cell == null || (cell.Trim()).Length == 0)
                    {
                        //MessageBox.Show("Wrong input values. Press ESC to discard or input new value");
                        message = "An error occured\nrow " + j + ", column " + i;
                        Permissions_dataGridView.Rows[j].Cells[i].Value = "Wrong!"; // WORKS !!!!

                    }
                }
            }
            */
            if (dr == DialogResult.Yes)
            {
                //if (message == "OK")
                //{
                    this.permissionsTableAdapter.Update(artifactManagerDatabaseDataSet.Permissions);
                    Permissions_dataGridView.Refresh();
                    MessageBox.Show("Changes Saved");
                //}
                //else
                //{
                //    MessageBox.Show(message);
                //}
            }
        }

        private void Permissions_dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("DataError: An error occured\n" + e.Exception.Message + "\nrow " + e.RowIndex + ", column " + e.ColumnIndex);
        }
    }
}
