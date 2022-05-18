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

namespace manager_artefaktow.Forms
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSet.Categories' . Możesz go przenieść lub usunąć.
            this.categoriesTableAdapter.Fill(this.artifactManagerDatabaseDataSet.Categories);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'artifactManagerDatabaseDataSetFull.Categories' . Możesz go przenieść lub usunąć.
            //this.categoriesTableAdapter.Fill(this.artifactManagerDatabaseDataSetFull.Categories);
            if(String.IsNullOrEmpty(LoggedUser.UserName))
            {
                AddCategory_button.Enabled = false;
                SaveChanges_button.Enabled = false;
                Categories_dataGridView.AllowUserToDeleteRows = false;
                DeleteChecked_button.Enabled = false;
                Reset_button.Enabled = false;
                Properties_checkedListBox.Enabled = false;
            }
        }

        private void BrowseArtifacts_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form browseArtifactsForm = new BrowseArtifactsForm();
            browseArtifactsForm.ShowDialog();
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            // Check if field is filled
            if (NewProperty_textBox.Text.Trim().Length == 0 || !CategoryManagement.CategoryExists(CategoryName_textBox.Text.Trim()))
            {
                MessageBox.Show("Invalid property name or category");
                return;
            }

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
                CategoryManagement.AddPropertyToCategory(NewProperty_textBox.Text, CategoryName_textBox.Text);
                this.categoriesTableAdapter.Update(artifactManagerDatabaseDataSet.Categories);
                Properties_checkedListBox.Items.Add(NewProperty_textBox.Text);
                Categories_dataGridView.Refresh();
                NewProperty_textBox.Clear();
                MessageBox.Show("Changes Saved");
                //}
                //else
                //{
                //    MessageBox.Show(message);
                //}
            }
        }

        private void AddCategory_button_Click(object sender, EventArgs e)
        {
            string categoryName = NewCategory_textBox.Text.Trim();
            if (categoryName.Length > 0)
            {
                if (!CategoryManagement.CategoryExists(categoryName))
                {
                    DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        CategoryManagement.AddCategory(categoryName, LoggedUser.UserName);
                        this.categoriesTableAdapter.Fill(artifactManagerDatabaseDataSet.Categories);
                        Categories_dataGridView.Refresh();
                        NewCategory_textBox.Clear();
                        MessageBox.Show("Category added");
                    }
                }
                else
                {
                    MessageBox.Show("Category with this name already exists");
                }
            }
            else
            {
                MessageBox.Show("Invalid role name");
            }
        }

        private void Categories_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string categoryName = e.Row.Cells[0].Value.ToString();
            if (!CategoryManagement.CategoryExists(categoryName))
            {
                MessageBox.Show("You cannot delete this role");
                e.Cancel = true;
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure to delete this row", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                return;
                //Roles_dataGridView.Rows.Remove(e.Row);
                //this.rolesTableAdapter3.Update(artifactManagerDatabaseDataSet3.Roles);
                //Roles_dataGridView.Refresh();
                //MessageBox.Show("Row deleted");
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Categories_dataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.categoriesTableAdapter.Update(artifactManagerDatabaseDataSet.Categories);
            Categories_dataGridView.Refresh();
            MessageBox.Show("Row deleted");
        }

        private void Categories_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (row >= 0 && row < Categories_dataGridView.RowCount)
            {
                CategoryName_textBox.Text = Categories_dataGridView.Rows[row].Cells[0].Value.ToString();
                string categoryName = CategoryName_textBox.Text;

                var allProperties = CategoryManagement.FindPropertiesForCategoryName(categoryName);
                //var rolePermissions = RoleManagement.findPermissionsForRoleName(roleName);

                Properties_checkedListBox.Items.Clear();
                int index = 0;
                foreach (var property in allProperties)
                {
                    Properties_checkedListBox.Items.Add(property);
                    //if (rolePermissions.Contains(permission))
                    //{
                    //    Permissions_checkedListBox.SetItemChecked(index, true);
                    //}
                    index++;
                }

            }
        }

        private void DeleteChecked_button_Click(object sender, EventArgs e)
        {
            List<string> checkedProperties = new List<string>();
            foreach (var checkedProp in Properties_checkedListBox.CheckedItems)
            {
                checkedProperties.Add(checkedProp.ToString());
            }
            if (checkedProperties.Count == 0)
            {
                MessageBox.Show("No properties to delete");
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure to delete those properties?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr != DialogResult.Yes)
            {
                return;
                //Roles_dataGridView.Rows.Remove(e.Row);
                //this.rolesTableAdapter3.Update(artifactManagerDatabaseDataSet3.Roles);
                //Roles_dataGridView.Refresh();
                //MessageBox.Show("Row deleted");
            }
            CategoryManagement.RemovePropertiesFromCategory(checkedProperties, CategoryName_textBox.Text.ToString());
            var newProperties = CategoryManagement.FindPropertiesForCategoryName(CategoryName_textBox.Text.ToString());

            Properties_checkedListBox.Items.Clear();
            foreach (var property in newProperties)
            {
                Properties_checkedListBox.Items.Add(property);
            }
            MessageBox.Show("Properties deleted");
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            var allProperties = CategoryManagement.FindPropertiesForCategoryName(CategoryName_textBox.Text.ToString());

            Properties_checkedListBox.Items.Clear();
            foreach (var property in allProperties)
            {
                Properties_checkedListBox.Items.Add(property);
            }
        }
    }
}
