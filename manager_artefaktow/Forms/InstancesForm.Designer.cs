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
            this.artifactManagerDatabaseDataSet = new manager_artefaktow.ArtifactManagerDatabaseDataSet();
            this.instancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instancesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.InstancesTableAdapter();
            this.instanceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveChanges_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Instances_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instancesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseArtifacts_button
            // 
            this.BrowseArtifacts_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BrowseArtifacts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BrowseArtifacts_button.ForeColor = System.Drawing.SystemColors.Control;
            this.BrowseArtifacts_button.Location = new System.Drawing.Point(12, 367);
            this.BrowseArtifacts_button.Name = "BrowseArtifacts_button";
            this.BrowseArtifacts_button.Size = new System.Drawing.Size(212, 71);
            this.BrowseArtifacts_button.TabIndex = 23;
            this.BrowseArtifacts_button.Text = "Back to Menu";
            this.BrowseArtifacts_button.UseVisualStyleBackColor = false;
            this.BrowseArtifacts_button.Click += new System.EventHandler(this.BrowseArtifacts_button_Click);
            // 
            // Instances_dataGridView
            // 
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
            this.Instances_dataGridView.RowHeadersWidth = 62;
            this.Instances_dataGridView.RowTemplate.Height = 28;
            this.Instances_dataGridView.Size = new System.Drawing.Size(681, 306);
            this.Instances_dataGridView.TabIndex = 24;
            // 
            // artifactManagerDatabaseDataSet
            // 
            this.artifactManagerDatabaseDataSet.DataSetName = "ArtifactManagerDatabaseDataSet";
            this.artifactManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instancesBindingSource
            // 
            this.instancesBindingSource.DataMember = "Instances";
            this.instancesBindingSource.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // instancesTableAdapter
            // 
            this.instancesTableAdapter.ClearBeforeFill = true;
            // 
            // instanceNameDataGridViewTextBoxColumn
            // 
            this.instanceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.instanceNameDataGridViewTextBoxColumn.DataPropertyName = "InstanceName";
            this.instanceNameDataGridViewTextBoxColumn.HeaderText = "InstanceName";
            this.instanceNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.instanceNameDataGridViewTextBoxColumn.Name = "instanceNameDataGridViewTextBoxColumn";
            // 
            // overallDataGridViewTextBoxColumn
            // 
            this.overallDataGridViewTextBoxColumn.DataPropertyName = "Overall";
            this.overallDataGridViewTextBoxColumn.HeaderText = "Overall";
            this.overallDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.overallDataGridViewTextBoxColumn.Name = "overallDataGridViewTextBoxColumn";
            this.overallDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // creatorNameDataGridViewTextBoxColumn
            // 
            this.creatorNameDataGridViewTextBoxColumn.DataPropertyName = "CreatorName";
            this.creatorNameDataGridViewTextBoxColumn.HeaderText = "CreatorName";
            this.creatorNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.creatorNameDataGridViewTextBoxColumn.Name = "creatorNameDataGridViewTextBoxColumn";
            this.creatorNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveChanges_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveChanges_button.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveChanges_button.Location = new System.Drawing.Point(576, 367);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(212, 71);
            this.SaveChanges_button.TabIndex = 26;
            this.SaveChanges_button.Text = "Save Changes";
            this.SaveChanges_button.UseVisualStyleBackColor = false;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click);
            // 
            // InstancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveChanges_button);
            this.Controls.Add(this.Instances_dataGridView);
            this.Controls.Add(this.BrowseArtifacts_button);
            this.Name = "InstancesForm";
            this.Text = "InstancesForm";
            this.Load += new System.EventHandler(this.InstancesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Instances_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instancesBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button SaveChanges_button;
    }
}