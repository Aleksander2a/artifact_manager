namespace manager_artefaktow.Forms
{
    partial class CategoriesForm
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
            this.artifactManagerDatabaseDataSetFull = new manager_artefaktow.ArtifactManagerDatabaseDataSetFull();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetFullTableAdapters.CategoriesTableAdapter();
            this.BrowseArtifacts_button = new System.Windows.Forms.Button();
            this.CreatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Categories_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSetFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Categories_dataGridView
            // 
            this.Categories_dataGridView.AutoGenerateColumns = false;
            this.Categories_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Categories_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreatorName,
            this.categoryNameDataGridViewTextBoxColumn});
            this.Categories_dataGridView.DataSource = this.categoriesBindingSource;
            this.Categories_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Categories_dataGridView.Name = "Categories_dataGridView";
            this.Categories_dataGridView.RowHeadersWidth = 62;
            this.Categories_dataGridView.RowTemplate.Height = 28;
            this.Categories_dataGridView.Size = new System.Drawing.Size(395, 283);
            this.Categories_dataGridView.TabIndex = 0;
            // 
            // artifactManagerDatabaseDataSetFull
            // 
            this.artifactManagerDatabaseDataSetFull.DataSetName = "ArtifactManagerDatabaseDataSetFull";
            this.artifactManagerDatabaseDataSetFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.artifactManagerDatabaseDataSetFull;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // BrowseArtifacts_button
            // 
            this.BrowseArtifacts_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BrowseArtifacts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BrowseArtifacts_button.ForeColor = System.Drawing.SystemColors.Control;
            this.BrowseArtifacts_button.Location = new System.Drawing.Point(12, 367);
            this.BrowseArtifacts_button.Name = "BrowseArtifacts_button";
            this.BrowseArtifacts_button.Size = new System.Drawing.Size(212, 71);
            this.BrowseArtifacts_button.TabIndex = 24;
            this.BrowseArtifacts_button.Text = "Back to Menu";
            this.BrowseArtifacts_button.UseVisualStyleBackColor = false;
            this.BrowseArtifacts_button.Click += new System.EventHandler(this.BrowseArtifacts_button_Click);
            // 
            // CreatorName
            // 
            this.CreatorName.DataPropertyName = "CreatorName";
            this.CreatorName.HeaderText = "CreatorName";
            this.CreatorName.MinimumWidth = 8;
            this.CreatorName.Name = "CreatorName";
            this.CreatorName.Width = 150;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrowseArtifacts_button);
            this.Controls.Add(this.Categories_dataGridView);
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Categories_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSetFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Categories_dataGridView;
        private ArtifactManagerDatabaseDataSetFull artifactManagerDatabaseDataSetFull;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private ArtifactManagerDatabaseDataSetFullTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Button BrowseArtifacts_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
    }
}