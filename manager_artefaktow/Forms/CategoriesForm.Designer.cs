namespace manager_artefaktow.Forms
{
    partial class Categories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Categories_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artifactManagerDatabaseDataSet = new manager_artefaktow.ArtifactManagerDatabaseDataSet();
            this.BrowseArtifacts_button = new System.Windows.Forms.Button();
            this.categoriesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.CategoriesTableAdapter();
            this.NewCategory_textBox = new System.Windows.Forms.TextBox();
            this.AddCategory_button = new System.Windows.Forms.Button();
            this.Permissions_label = new System.Windows.Forms.Label();
            this.Properties_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.CategoryName_textBox = new System.Windows.Forms.TextBox();
            this.RoleName_label = new System.Windows.Forms.Label();
            this.RoleDetails_label = new System.Windows.Forms.Label();
            this.SaveChanges_button = new System.Windows.Forms.Button();
            this.DeleteChecked_button = new System.Windows.Forms.Button();
            this.NewProperty_textBox = new System.Windows.Forms.TextBox();
            this.Reset_button = new System.Windows.Forms.Button();
            this.AddInstance_button = new System.Windows.Forms.Button();
            this.CategoryArtifacts_button = new System.Windows.Forms.Button();
            this.Filter_comboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.UsersTableAdapter();
            this.Filter_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Categories_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Categories_dataGridView
            // 
            this.Categories_dataGridView.AllowUserToAddRows = false;
            this.Categories_dataGridView.AutoGenerateColumns = false;
            this.Categories_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Categories_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.creatorNameDataGridViewTextBoxColumn});
            this.Categories_dataGridView.DataSource = this.categoriesBindingSource;
            this.Categories_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Categories_dataGridView.Name = "Categories_dataGridView";
            this.Categories_dataGridView.ReadOnly = true;
            this.Categories_dataGridView.RowHeadersWidth = 62;
            this.Categories_dataGridView.RowTemplate.Height = 28;
            this.Categories_dataGridView.Size = new System.Drawing.Size(394, 288);
            this.Categories_dataGridView.TabIndex = 0;
            this.Categories_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Categories_dataGridView_CellClick);
            this.Categories_dataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Categories_dataGridView_UserDeletedRow);
            this.Categories_dataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Categories_dataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn1.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // creatorNameDataGridViewTextBoxColumn
            // 
            this.creatorNameDataGridViewTextBoxColumn.DataPropertyName = "CreatorName";
            this.creatorNameDataGridViewTextBoxColumn.HeaderText = "CreatorName";
            this.creatorNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.creatorNameDataGridViewTextBoxColumn.Name = "creatorNameDataGridViewTextBoxColumn";
            this.creatorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatorNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // artifactManagerDatabaseDataSet
            // 
            this.artifactManagerDatabaseDataSet.DataSetName = "ArtifactManagerDatabaseDataSet";
            this.artifactManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BrowseArtifacts_button
            // 
            this.BrowseArtifacts_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BrowseArtifacts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BrowseArtifacts_button.ForeColor = System.Drawing.SystemColors.Control;
            this.BrowseArtifacts_button.Location = new System.Drawing.Point(12, 394);
            this.BrowseArtifacts_button.Name = "BrowseArtifacts_button";
            this.BrowseArtifacts_button.Size = new System.Drawing.Size(212, 44);
            this.BrowseArtifacts_button.TabIndex = 24;
            this.BrowseArtifacts_button.Text = "Back to Menu";
            this.BrowseArtifacts_button.UseVisualStyleBackColor = false;
            this.BrowseArtifacts_button.Click += new System.EventHandler(this.BrowseArtifacts_button_Click);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // NewCategory_textBox
            // 
            this.NewCategory_textBox.Location = new System.Drawing.Point(128, 314);
            this.NewCategory_textBox.Name = "NewCategory_textBox";
            this.NewCategory_textBox.Size = new System.Drawing.Size(278, 26);
            this.NewCategory_textBox.TabIndex = 30;
            // 
            // AddCategory_button
            // 
            this.AddCategory_button.BackColor = System.Drawing.Color.Blue;
            this.AddCategory_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddCategory_button.ForeColor = System.Drawing.SystemColors.Control;
            this.AddCategory_button.Location = new System.Drawing.Point(12, 306);
            this.AddCategory_button.Name = "AddCategory_button";
            this.AddCategory_button.Size = new System.Drawing.Size(110, 38);
            this.AddCategory_button.TabIndex = 29;
            this.AddCategory_button.Text = "Add";
            this.AddCategory_button.UseVisualStyleBackColor = false;
            this.AddCategory_button.Click += new System.EventHandler(this.AddCategory_button_Click);
            // 
            // Permissions_label
            // 
            this.Permissions_label.AutoSize = true;
            this.Permissions_label.Location = new System.Drawing.Point(566, 135);
            this.Permissions_label.Name = "Permissions_label";
            this.Permissions_label.Size = new System.Drawing.Size(81, 20);
            this.Permissions_label.TabIndex = 36;
            this.Permissions_label.Text = "Properties";
            // 
            // Properties_checkedListBox
            // 
            this.Properties_checkedListBox.FormattingEnabled = true;
            this.Properties_checkedListBox.Location = new System.Drawing.Point(412, 158);
            this.Properties_checkedListBox.Name = "Properties_checkedListBox";
            this.Properties_checkedListBox.Size = new System.Drawing.Size(376, 142);
            this.Properties_checkedListBox.TabIndex = 35;
            // 
            // CategoryName_textBox
            // 
            this.CategoryName_textBox.Location = new System.Drawing.Point(412, 94);
            this.CategoryName_textBox.Name = "CategoryName_textBox";
            this.CategoryName_textBox.ReadOnly = true;
            this.CategoryName_textBox.Size = new System.Drawing.Size(376, 26);
            this.CategoryName_textBox.TabIndex = 34;
            // 
            // RoleName_label
            // 
            this.RoleName_label.AutoSize = true;
            this.RoleName_label.Location = new System.Drawing.Point(544, 71);
            this.RoleName_label.Name = "RoleName_label";
            this.RoleName_label.Size = new System.Drawing.Size(119, 20);
            this.RoleName_label.TabIndex = 33;
            this.RoleName_label.Text = "Category Name";
            // 
            // RoleDetails_label
            // 
            this.RoleDetails_label.AutoSize = true;
            this.RoleDetails_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoleDetails_label.Location = new System.Drawing.Point(482, 12);
            this.RoleDetails_label.Name = "RoleDetails_label";
            this.RoleDetails_label.Size = new System.Drawing.Size(240, 32);
            this.RoleDetails_label.TabIndex = 32;
            this.RoleDetails_label.Text = "Category Details";
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveChanges_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveChanges_button.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveChanges_button.Location = new System.Drawing.Point(412, 306);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(194, 38);
            this.SaveChanges_button.TabIndex = 31;
            this.SaveChanges_button.Text = "Add Property";
            this.SaveChanges_button.UseVisualStyleBackColor = false;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click);
            // 
            // DeleteChecked_button
            // 
            this.DeleteChecked_button.BackColor = System.Drawing.Color.Red;
            this.DeleteChecked_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteChecked_button.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteChecked_button.Location = new System.Drawing.Point(412, 350);
            this.DeleteChecked_button.Name = "DeleteChecked_button";
            this.DeleteChecked_button.Size = new System.Drawing.Size(194, 38);
            this.DeleteChecked_button.TabIndex = 37;
            this.DeleteChecked_button.Text = "Delete checked";
            this.DeleteChecked_button.UseVisualStyleBackColor = false;
            this.DeleteChecked_button.Click += new System.EventHandler(this.DeleteChecked_button_Click);
            // 
            // NewProperty_textBox
            // 
            this.NewProperty_textBox.Location = new System.Drawing.Point(612, 314);
            this.NewProperty_textBox.Name = "NewProperty_textBox";
            this.NewProperty_textBox.Size = new System.Drawing.Size(176, 26);
            this.NewProperty_textBox.TabIndex = 38;
            // 
            // Reset_button
            // 
            this.Reset_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Reset_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Reset_button.Location = new System.Drawing.Point(612, 350);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(176, 38);
            this.Reset_button.TabIndex = 39;
            this.Reset_button.Text = "Reset checks";
            this.Reset_button.UseVisualStyleBackColor = false;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // AddInstance_button
            // 
            this.AddInstance_button.BackColor = System.Drawing.Color.Teal;
            this.AddInstance_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddInstance_button.ForeColor = System.Drawing.SystemColors.Control;
            this.AddInstance_button.Location = new System.Drawing.Point(612, 394);
            this.AddInstance_button.Name = "AddInstance_button";
            this.AddInstance_button.Size = new System.Drawing.Size(176, 38);
            this.AddInstance_button.TabIndex = 40;
            this.AddInstance_button.Text = "Add Artifact";
            this.AddInstance_button.UseVisualStyleBackColor = false;
            this.AddInstance_button.Click += new System.EventHandler(this.AddInstance_button_Click);
            // 
            // CategoryArtifacts_button
            // 
            this.CategoryArtifacts_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CategoryArtifacts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CategoryArtifacts_button.ForeColor = System.Drawing.SystemColors.Control;
            this.CategoryArtifacts_button.Location = new System.Drawing.Point(412, 394);
            this.CategoryArtifacts_button.Name = "CategoryArtifacts_button";
            this.CategoryArtifacts_button.Size = new System.Drawing.Size(194, 38);
            this.CategoryArtifacts_button.TabIndex = 41;
            this.CategoryArtifacts_button.Text = "All Artifacts";
            this.CategoryArtifacts_button.UseVisualStyleBackColor = false;
            this.CategoryArtifacts_button.Click += new System.EventHandler(this.CategoryArtifacts_button_Click);
            // 
            // Filter_comboBox
            // 
            this.Filter_comboBox.DataSource = this.usersBindingSource;
            this.Filter_comboBox.DisplayMember = "UserName";
            this.Filter_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter_comboBox.FormattingEnabled = true;
            this.Filter_comboBox.Location = new System.Drawing.Point(86, 358);
            this.Filter_comboBox.Name = "Filter_comboBox";
            this.Filter_comboBox.Size = new System.Drawing.Size(162, 28);
            this.Filter_comboBox.TabIndex = 42;
            this.Filter_comboBox.SelectedIndexChanged += new System.EventHandler(this.Filter_comboBox_SelectedIndexChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Filter_button
            // 
            this.Filter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Filter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Filter_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Filter_button.Location = new System.Drawing.Point(12, 350);
            this.Filter_button.Name = "Filter_button";
            this.Filter_button.Size = new System.Drawing.Size(68, 38);
            this.Filter_button.TabIndex = 43;
            this.Filter_button.Text = "Filter";
            this.Filter_button.UseVisualStyleBackColor = false;
            this.Filter_button.Click += new System.EventHandler(this.Filter_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(254, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 44;
            this.button1.Text = "Remove Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Filter_button);
            this.Controls.Add(this.Filter_comboBox);
            this.Controls.Add(this.CategoryArtifacts_button);
            this.Controls.Add(this.AddInstance_button);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.NewProperty_textBox);
            this.Controls.Add(this.DeleteChecked_button);
            this.Controls.Add(this.Permissions_label);
            this.Controls.Add(this.Properties_checkedListBox);
            this.Controls.Add(this.CategoryName_textBox);
            this.Controls.Add(this.RoleName_label);
            this.Controls.Add(this.RoleDetails_label);
            this.Controls.Add(this.SaveChanges_button);
            this.Controls.Add(this.NewCategory_textBox);
            this.Controls.Add(this.AddCategory_button);
            this.Controls.Add(this.BrowseArtifacts_button);
            this.Controls.Add(this.Categories_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Categories";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Categories_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Categories_dataGridView;
        //private ArtifactManagerDatabaseDataSetFullTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Button BrowseArtifacts_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox NewCategory_textBox;
        private System.Windows.Forms.Button AddCategory_button;
        private System.Windows.Forms.Label Permissions_label;
        private System.Windows.Forms.CheckedListBox Properties_checkedListBox;
        private System.Windows.Forms.TextBox CategoryName_textBox;
        private System.Windows.Forms.Label RoleName_label;
        private System.Windows.Forms.Label RoleDetails_label;
        private System.Windows.Forms.Button SaveChanges_button;
        private System.Windows.Forms.Button DeleteChecked_button;
        private System.Windows.Forms.TextBox NewProperty_textBox;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button AddInstance_button;
        private System.Windows.Forms.Button CategoryArtifacts_button;
        private System.Windows.Forms.ComboBox Filter_comboBox;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button Filter_button;
        private System.Windows.Forms.Button button1;
    }
}