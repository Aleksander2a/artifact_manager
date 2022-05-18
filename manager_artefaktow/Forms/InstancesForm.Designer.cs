namespace manager_artefaktow.Forms
{
    partial class InstancesForm
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
            this.BrowseArtifacts_button = new System.Windows.Forms.Button();
            this.Instances_dataGridView = new System.Windows.Forms.DataGridView();
            this.instanceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artifactManagerDatabaseDataSet = new manager_artefaktow.ArtifactManagerDatabaseDataSet();
            this.instancesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.InstancesTableAdapter();
            this.ArtifactDetails_button = new System.Windows.Forms.Button();
            this.CategoryName_textBox = new System.Windows.Forms.TextBox();
            this.RoleName_label = new System.Windows.Forms.Label();
            this.RoleDetails_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddInstance_button = new System.Windows.Forms.Button();
            this.RemoveCategoryFilter_button = new System.Windows.Forms.Button();
            this.Filter_button = new System.Windows.Forms.Button();
            this.CategoryFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.CategoryFilter_label = new System.Windows.Forms.Label();
            this.CreatorFilter_label = new System.Windows.Forms.Label();
            this.CreatorFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.RemoveCreatorFilter_button = new System.Windows.Forms.Button();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.CategoriesTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Instances_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseArtifacts_button
            // 
            this.BrowseArtifacts_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BrowseArtifacts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BrowseArtifacts_button.ForeColor = System.Drawing.SystemColors.Control;
            this.BrowseArtifacts_button.Location = new System.Drawing.Point(12, 400);
            this.BrowseArtifacts_button.Name = "BrowseArtifacts_button";
            this.BrowseArtifacts_button.Size = new System.Drawing.Size(212, 38);
            this.BrowseArtifacts_button.TabIndex = 23;
            this.BrowseArtifacts_button.Text = "Back to Menu";
            this.BrowseArtifacts_button.UseVisualStyleBackColor = false;
            this.BrowseArtifacts_button.Click += new System.EventHandler(this.BrowseArtifacts_button_Click);
            // 
            // Instances_dataGridView
            // 
            this.Instances_dataGridView.AllowUserToAddRows = false;
            this.Instances_dataGridView.AutoGenerateColumns = false;
            this.Instances_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Instances_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instanceNameDataGridViewTextBoxColumn,
            this.overallDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.creatorNameDataGridViewTextBoxColumn});
            this.Instances_dataGridView.DataSource = this.instancesBindingSource;
            this.Instances_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Instances_dataGridView.Name = "Instances_dataGridView";
            this.Instances_dataGridView.ReadOnly = true;
            this.Instances_dataGridView.RowHeadersWidth = 62;
            this.Instances_dataGridView.RowTemplate.Height = 28;
            this.Instances_dataGridView.Size = new System.Drawing.Size(563, 312);
            this.Instances_dataGridView.TabIndex = 24;
            this.Instances_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Instances_dataGridView_CellClick);
            this.Instances_dataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Instances_dataGridView_UserDeletedRow);
            this.Instances_dataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Instances_dataGridView_UserDeletingRow);
            // 
            // instanceNameDataGridViewTextBoxColumn
            // 
            this.instanceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.instanceNameDataGridViewTextBoxColumn.DataPropertyName = "InstanceName";
            this.instanceNameDataGridViewTextBoxColumn.HeaderText = "InstanceName";
            this.instanceNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.instanceNameDataGridViewTextBoxColumn.Name = "instanceNameDataGridViewTextBoxColumn";
            this.instanceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overallDataGridViewTextBoxColumn
            // 
            this.overallDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.overallDataGridViewTextBoxColumn.DataPropertyName = "Overall";
            this.overallDataGridViewTextBoxColumn.HeaderText = "Overall";
            this.overallDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.overallDataGridViewTextBoxColumn.Name = "overallDataGridViewTextBoxColumn";
            this.overallDataGridViewTextBoxColumn.ReadOnly = true;
            this.overallDataGridViewTextBoxColumn.Width = 93;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryNameDataGridViewTextBoxColumn.Width = 151;
            // 
            // creatorNameDataGridViewTextBoxColumn
            // 
            this.creatorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.creatorNameDataGridViewTextBoxColumn.DataPropertyName = "CreatorName";
            this.creatorNameDataGridViewTextBoxColumn.HeaderText = "CreatorName";
            this.creatorNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.creatorNameDataGridViewTextBoxColumn.Name = "creatorNameDataGridViewTextBoxColumn";
            this.creatorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatorNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // instancesBindingSource
            // 
            this.instancesBindingSource.DataMember = "Instances";
            this.instancesBindingSource.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // artifactManagerDatabaseDataSet
            // 
            this.artifactManagerDatabaseDataSet.DataSetName = "ArtifactManagerDatabaseDataSet";
            this.artifactManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instancesTableAdapter
            // 
            this.instancesTableAdapter.ClearBeforeFill = true;
            // 
            // ArtifactDetails_button
            // 
            this.ArtifactDetails_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ArtifactDetails_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArtifactDetails_button.ForeColor = System.Drawing.SystemColors.Control;
            this.ArtifactDetails_button.Location = new System.Drawing.Point(581, 278);
            this.ArtifactDetails_button.Name = "ArtifactDetails_button";
            this.ArtifactDetails_button.Size = new System.Drawing.Size(207, 46);
            this.ArtifactDetails_button.TabIndex = 27;
            this.ArtifactDetails_button.Text = "Artifact Details";
            this.ArtifactDetails_button.UseVisualStyleBackColor = false;
            this.ArtifactDetails_button.Click += new System.EventHandler(this.ArtifactDetails_button_Click);
            // 
            // CategoryName_textBox
            // 
            this.CategoryName_textBox.Location = new System.Drawing.Point(581, 79);
            this.CategoryName_textBox.Name = "CategoryName_textBox";
            this.CategoryName_textBox.ReadOnly = true;
            this.CategoryName_textBox.Size = new System.Drawing.Size(207, 26);
            this.CategoryName_textBox.TabIndex = 37;
            // 
            // RoleName_label
            // 
            this.RoleName_label.AutoSize = true;
            this.RoleName_label.Location = new System.Drawing.Point(639, 56);
            this.RoleName_label.Name = "RoleName_label";
            this.RoleName_label.Size = new System.Drawing.Size(106, 20);
            this.RoleName_label.TabIndex = 36;
            this.RoleName_label.Text = "Artifact Name";
            // 
            // RoleDetails_label
            // 
            this.RoleDetails_label.AutoSize = true;
            this.RoleDetails_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoleDetails_label.Location = new System.Drawing.Point(581, 12);
            this.RoleDetails_label.Name = "RoleDetails_label";
            this.RoleDetails_label.Size = new System.Drawing.Size(214, 32);
            this.RoleDetails_label.TabIndex = 35;
            this.RoleDetails_label.Text = "Artifact Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(581, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(207, 26);
            this.textBox1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Category";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(581, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(207, 26);
            this.textBox2.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Creator";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(581, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(207, 26);
            this.textBox3.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Overall";
            // 
            // AddInstance_button
            // 
            this.AddInstance_button.BackColor = System.Drawing.Color.Teal;
            this.AddInstance_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddInstance_button.ForeColor = System.Drawing.SystemColors.Control;
            this.AddInstance_button.Location = new System.Drawing.Point(612, 400);
            this.AddInstance_button.Name = "AddInstance_button";
            this.AddInstance_button.Size = new System.Drawing.Size(176, 38);
            this.AddInstance_button.TabIndex = 44;
            this.AddInstance_button.Text = "Add Artifact";
            this.AddInstance_button.UseVisualStyleBackColor = false;
            this.AddInstance_button.Click += new System.EventHandler(this.AddInstance_button_Click);
            // 
            // RemoveCategoryFilter_button
            // 
            this.RemoveCategoryFilter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RemoveCategoryFilter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveCategoryFilter_button.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveCategoryFilter_button.Location = new System.Drawing.Point(416, 334);
            this.RemoveCategoryFilter_button.Name = "RemoveCategoryFilter_button";
            this.RemoveCategoryFilter_button.Size = new System.Drawing.Size(159, 30);
            this.RemoveCategoryFilter_button.TabIndex = 47;
            this.RemoveCategoryFilter_button.Text = "Remove Filter";
            this.RemoveCategoryFilter_button.UseVisualStyleBackColor = false;
            this.RemoveCategoryFilter_button.Click += new System.EventHandler(this.RemoveCategoryFilter_button_Click);
            // 
            // Filter_button
            // 
            this.Filter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Filter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Filter_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Filter_button.Location = new System.Drawing.Point(12, 336);
            this.Filter_button.Name = "Filter_button";
            this.Filter_button.Size = new System.Drawing.Size(92, 58);
            this.Filter_button.TabIndex = 46;
            this.Filter_button.Text = "Filter";
            this.Filter_button.UseVisualStyleBackColor = false;
            this.Filter_button.Click += new System.EventHandler(this.Filter_button_Click);
            // 
            // CategoryFilter_comboBox
            // 
            this.CategoryFilter_comboBox.DataSource = this.categoriesBindingSource;
            this.CategoryFilter_comboBox.DisplayMember = "CategoryName";
            this.CategoryFilter_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryFilter_comboBox.FormattingEnabled = true;
            this.CategoryFilter_comboBox.Location = new System.Drawing.Point(248, 336);
            this.CategoryFilter_comboBox.Name = "CategoryFilter_comboBox";
            this.CategoryFilter_comboBox.Size = new System.Drawing.Size(162, 28);
            this.CategoryFilter_comboBox.TabIndex = 45;
            this.CategoryFilter_comboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryFilter_comboBox_SelectedIndexChanged);
            // 
            // CategoryFilter_label
            // 
            this.CategoryFilter_label.AutoSize = true;
            this.CategoryFilter_label.Location = new System.Drawing.Point(110, 339);
            this.CategoryFilter_label.Name = "CategoryFilter_label";
            this.CategoryFilter_label.Size = new System.Drawing.Size(132, 20);
            this.CategoryFilter_label.TabIndex = 48;
            this.CategoryFilter_label.Text = "Filter by Category";
            // 
            // CreatorFilter_label
            // 
            this.CreatorFilter_label.AutoSize = true;
            this.CreatorFilter_label.Location = new System.Drawing.Point(110, 367);
            this.CreatorFilter_label.Name = "CreatorFilter_label";
            this.CreatorFilter_label.Size = new System.Drawing.Size(121, 20);
            this.CreatorFilter_label.TabIndex = 49;
            this.CreatorFilter_label.Text = "Filter by Creator";
            // 
            // CreatorFilter_comboBox
            // 
            this.CreatorFilter_comboBox.DataSource = this.usersBindingSource;
            this.CreatorFilter_comboBox.DisplayMember = "UserName";
            this.CreatorFilter_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreatorFilter_comboBox.FormattingEnabled = true;
            this.CreatorFilter_comboBox.Location = new System.Drawing.Point(248, 364);
            this.CreatorFilter_comboBox.Name = "CreatorFilter_comboBox";
            this.CreatorFilter_comboBox.Size = new System.Drawing.Size(162, 28);
            this.CreatorFilter_comboBox.TabIndex = 50;
            this.CreatorFilter_comboBox.SelectedIndexChanged += new System.EventHandler(this.CreatorFilter_comboBox_SelectedIndexChanged);
            // 
            // RemoveCreatorFilter_button
            // 
            this.RemoveCreatorFilter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RemoveCreatorFilter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveCreatorFilter_button.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveCreatorFilter_button.Location = new System.Drawing.Point(416, 362);
            this.RemoveCreatorFilter_button.Name = "RemoveCreatorFilter_button";
            this.RemoveCreatorFilter_button.Size = new System.Drawing.Size(159, 30);
            this.RemoveCreatorFilter_button.TabIndex = 51;
            this.RemoveCreatorFilter_button.Text = "Remove Filter";
            this.RemoveCreatorFilter_button.UseVisualStyleBackColor = false;
            this.RemoveCreatorFilter_button.Click += new System.EventHandler(this.RemoveCreatorFilter_button_Click);
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
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // InstancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveCreatorFilter_button);
            this.Controls.Add(this.CreatorFilter_comboBox);
            this.Controls.Add(this.CreatorFilter_label);
            this.Controls.Add(this.CategoryFilter_label);
            this.Controls.Add(this.RemoveCategoryFilter_button);
            this.Controls.Add(this.Filter_button);
            this.Controls.Add(this.CategoryFilter_comboBox);
            this.Controls.Add(this.AddInstance_button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryName_textBox);
            this.Controls.Add(this.RoleName_label);
            this.Controls.Add(this.RoleDetails_label);
            this.Controls.Add(this.ArtifactDetails_button);
            this.Controls.Add(this.Instances_dataGridView);
            this.Controls.Add(this.BrowseArtifacts_button);
            this.Name = "InstancesForm";
            this.Text = "InstancesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstancesForm_FormClosing);
            this.Load += new System.EventHandler(this.InstancesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Instances_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseArtifacts_button;
        private System.Windows.Forms.DataGridView Instances_dataGridView;
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet;
        private System.Windows.Forms.BindingSource instancesBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.InstancesTableAdapter instancesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn instanceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ArtifactDetails_button;
        private System.Windows.Forms.TextBox CategoryName_textBox;
        private System.Windows.Forms.Label RoleName_label;
        private System.Windows.Forms.Label RoleDetails_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddInstance_button;
        private System.Windows.Forms.Button RemoveCategoryFilter_button;
        private System.Windows.Forms.Button Filter_button;
        private System.Windows.Forms.ComboBox CategoryFilter_comboBox;
        private System.Windows.Forms.Label CategoryFilter_label;
        private System.Windows.Forms.Label CreatorFilter_label;
        private System.Windows.Forms.ComboBox CreatorFilter_comboBox;
        private System.Windows.Forms.Button RemoveCreatorFilter_button;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}