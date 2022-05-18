namespace manager_artefaktow.Forms
{
    partial class ArtifactDetailsForm
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
            this.Overall_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Add_button = new System.Windows.Forms.Button();
            this.BrowseArtifacts_button = new System.Windows.Forms.Button();
            this.Properties_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Creator_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ArtifactName_textBox = new System.Windows.Forms.TextBox();
            this.RoleName_label = new System.Windows.Forms.Label();
            this.RoleDetails_label = new System.Windows.Forms.Label();
            this.artifactManagerDatabaseDataSet = new manager_artefaktow.ArtifactManagerDatabaseDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.CategoriesTableAdapter();
            this.instancesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.InstancesTableAdapter();
            this.Category_textBox = new System.Windows.Forms.TextBox();
            this.Properties_dataGridView = new System.Windows.Forms.DataGridView();
            this.fKCategoryPropertiesCategoriesCategoryNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryPropertiesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.CategoryPropertiesTableAdapter();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Overall_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Properties_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCategoryPropertiesCategoriesCategoryNameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Overall_numericUpDown
            // 
            this.Overall_numericUpDown.Location = new System.Drawing.Point(18, 252);
            this.Overall_numericUpDown.Name = "Overall_numericUpDown";
            this.Overall_numericUpDown.Size = new System.Drawing.Size(201, 26);
            this.Overall_numericUpDown.TabIndex = 70;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.LimeGreen;
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Add_button.Location = new System.Drawing.Point(576, 369);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(212, 71);
            this.Add_button.TabIndex = 69;
            this.Add_button.Text = "Save Changes";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // BrowseArtifacts_button
            // 
            this.BrowseArtifacts_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BrowseArtifacts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BrowseArtifacts_button.ForeColor = System.Drawing.SystemColors.Control;
            this.BrowseArtifacts_button.Location = new System.Drawing.Point(12, 369);
            this.BrowseArtifacts_button.Name = "BrowseArtifacts_button";
            this.BrowseArtifacts_button.Size = new System.Drawing.Size(212, 71);
            this.BrowseArtifacts_button.TabIndex = 68;
            this.BrowseArtifacts_button.Text = "Back to All Artifacts";
            this.BrowseArtifacts_button.UseVisualStyleBackColor = false;
            this.BrowseArtifacts_button.Click += new System.EventHandler(this.BrowseArtifacts_button_Click);
            // 
            // Properties_label
            // 
            this.Properties_label.AutoSize = true;
            this.Properties_label.Location = new System.Drawing.Point(479, 56);
            this.Properties_label.Name = "Properties_label";
            this.Properties_label.Size = new System.Drawing.Size(81, 20);
            this.Properties_label.TabIndex = 67;
            this.Properties_label.Text = "Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Overall [0-100]";
            // 
            // Creator_textBox
            // 
            this.Creator_textBox.Location = new System.Drawing.Point(12, 192);
            this.Creator_textBox.Name = "Creator_textBox";
            this.Creator_textBox.ReadOnly = true;
            this.Creator_textBox.Size = new System.Drawing.Size(207, 26);
            this.Creator_textBox.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Creator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Category";
            // 
            // ArtifactName_textBox
            // 
            this.ArtifactName_textBox.Location = new System.Drawing.Point(18, 79);
            this.ArtifactName_textBox.Name = "ArtifactName_textBox";
            this.ArtifactName_textBox.ReadOnly = true;
            this.ArtifactName_textBox.Size = new System.Drawing.Size(207, 26);
            this.ArtifactName_textBox.TabIndex = 60;
            // 
            // RoleName_label
            // 
            this.RoleName_label.AutoSize = true;
            this.RoleName_label.Location = new System.Drawing.Point(70, 56);
            this.RoleName_label.Name = "RoleName_label";
            this.RoleName_label.Size = new System.Drawing.Size(106, 20);
            this.RoleName_label.TabIndex = 59;
            this.RoleName_label.Text = "Artifact Name";
            // 
            // RoleDetails_label
            // 
            this.RoleDetails_label.AutoSize = true;
            this.RoleDetails_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoleDetails_label.Location = new System.Drawing.Point(12, 11);
            this.RoleDetails_label.Name = "RoleDetails_label";
            this.RoleDetails_label.Size = new System.Drawing.Size(214, 32);
            this.RoleDetails_label.TabIndex = 58;
            this.RoleDetails_label.Text = "Artifact Details";
            // 
            // artifactManagerDatabaseDataSet
            // 
            this.artifactManagerDatabaseDataSet.DataSetName = "ArtifactManagerDatabaseDataSet";
            this.artifactManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // instancesTableAdapter
            // 
            this.instancesTableAdapter.ClearBeforeFill = true;
            // 
            // Category_textBox
            // 
            this.Category_textBox.Location = new System.Drawing.Point(17, 140);
            this.Category_textBox.Name = "Category_textBox";
            this.Category_textBox.ReadOnly = true;
            this.Category_textBox.Size = new System.Drawing.Size(207, 26);
            this.Category_textBox.TabIndex = 71;
            // 
            // Properties_dataGridView
            // 
            this.Properties_dataGridView.AllowUserToAddRows = false;
            this.Properties_dataGridView.AllowUserToDeleteRows = false;
            this.Properties_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Properties_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyName,
            this.Value});
            this.Properties_dataGridView.Location = new System.Drawing.Point(316, 79);
            this.Properties_dataGridView.Name = "Properties_dataGridView";
            this.Properties_dataGridView.RowHeadersWidth = 62;
            this.Properties_dataGridView.RowTemplate.Height = 28;
            this.Properties_dataGridView.Size = new System.Drawing.Size(426, 228);
            this.Properties_dataGridView.TabIndex = 72;
            // 
            // fKCategoryPropertiesCategoriesCategoryNameBindingSource
            // 
            this.fKCategoryPropertiesCategoriesCategoryNameBindingSource.DataMember = "FK_CategoryProperties_Categories_CategoryName";
            this.fKCategoryPropertiesCategoriesCategoryNameBindingSource.DataSource = this.categoriesBindingSource;
            // 
            // categoryPropertiesTableAdapter
            // 
            this.categoryPropertiesTableAdapter.ClearBeforeFill = true;
            // 
            // PropertyName
            // 
            this.PropertyName.HeaderText = "Property Name";
            this.PropertyName.MinimumWidth = 8;
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.ReadOnly = true;
            this.PropertyName.Width = 150;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 8;
            this.Value.Name = "Value";
            // 
            // ArtifactDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Properties_dataGridView);
            this.Controls.Add(this.Category_textBox);
            this.Controls.Add(this.Overall_numericUpDown);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.BrowseArtifacts_button);
            this.Controls.Add(this.Properties_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Creator_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArtifactName_textBox);
            this.Controls.Add(this.RoleName_label);
            this.Controls.Add(this.RoleDetails_label);
            this.Name = "ArtifactDetailsForm";
            this.Text = "Artifact Details";
            this.Load += new System.EventHandler(this.ArtifactDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Overall_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Properties_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCategoryPropertiesCategoriesCategoryNameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Overall_numericUpDown;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button BrowseArtifacts_button;
        private System.Windows.Forms.Label Properties_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Creator_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArtifactName_textBox;
        private System.Windows.Forms.Label RoleName_label;
        private System.Windows.Forms.Label RoleDetails_label;
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private ArtifactManagerDatabaseDataSetTableAdapters.InstancesTableAdapter instancesTableAdapter;
        private System.Windows.Forms.TextBox Category_textBox;
        private System.Windows.Forms.DataGridView Properties_dataGridView;
        private System.Windows.Forms.BindingSource fKCategoryPropertiesCategoriesCategoryNameBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.CategoryPropertiesTableAdapter categoryPropertiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}