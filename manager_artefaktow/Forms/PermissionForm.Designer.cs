namespace manager_artefaktow
{
    partial class PermissionForm
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
            this.SaveChanges_button = new System.Windows.Forms.Button();
            this.AdminPanel_button = new System.Windows.Forms.Button();
            this.Permissions_dataGridView = new System.Windows.Forms.DataGridView();
            this.permissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artifactManagerDatabaseDataSet = new manager_artefaktow.ArtifactManagerDatabaseDataSet();
            this.permissionsTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.PermissionsTableAdapter();
            this.permissionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Permissions_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveChanges_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveChanges_button.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveChanges_button.Location = new System.Drawing.Point(576, 367);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(212, 71);
            this.SaveChanges_button.TabIndex = 24;
            this.SaveChanges_button.Text = "Save Changes";
            this.SaveChanges_button.UseVisualStyleBackColor = false;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click);
            // 
            // AdminPanel_button
            // 
            this.AdminPanel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AdminPanel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdminPanel_button.ForeColor = System.Drawing.SystemColors.Control;
            this.AdminPanel_button.Location = new System.Drawing.Point(12, 367);
            this.AdminPanel_button.Name = "AdminPanel_button";
            this.AdminPanel_button.Size = new System.Drawing.Size(212, 71);
            this.AdminPanel_button.TabIndex = 22;
            this.AdminPanel_button.Text = "Back to Admin Panel";
            this.AdminPanel_button.UseVisualStyleBackColor = false;
            this.AdminPanel_button.Click += new System.EventHandler(this.AdminPanel_button_Click);
            // 
            // Permissions_dataGridView
            // 
            this.Permissions_dataGridView.AutoGenerateColumns = false;
            this.Permissions_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Permissions_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.permissionNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.Permissions_dataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.permissionsBindingSource, "PermissionName", true));
            this.Permissions_dataGridView.DataSource = this.permissionsBindingSource;
            this.Permissions_dataGridView.Location = new System.Drawing.Point(13, 13);
            this.Permissions_dataGridView.Name = "Permissions_dataGridView";
            this.Permissions_dataGridView.RowHeadersWidth = 62;
            this.Permissions_dataGridView.RowTemplate.Height = 28;
            this.Permissions_dataGridView.Size = new System.Drawing.Size(554, 210);
            this.Permissions_dataGridView.TabIndex = 25;
            this.Permissions_dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Permissions_dataGridView_DataError);
            // 
            // permissionsBindingSource
            // 
            this.permissionsBindingSource.DataMember = "Permissions";
            this.permissionsBindingSource.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // artifactManagerDatabaseDataSet
            // 
            this.artifactManagerDatabaseDataSet.DataSetName = "ArtifactManagerDatabaseDataSet";
            this.artifactManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // permissionsTableAdapter
            // 
            this.permissionsTableAdapter.ClearBeforeFill = true;
            // 
            // permissionNameDataGridViewTextBoxColumn
            // 
            this.permissionNameDataGridViewTextBoxColumn.DataPropertyName = "PermissionName";
            this.permissionNameDataGridViewTextBoxColumn.HeaderText = "PermissionName";
            this.permissionNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.permissionNameDataGridViewTextBoxColumn.Name = "permissionNameDataGridViewTextBoxColumn";
            this.permissionNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // PermissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Permissions_dataGridView);
            this.Controls.Add(this.SaveChanges_button);
            this.Controls.Add(this.AdminPanel_button);
            this.Name = "PermissionForm";
            this.Text = "PermissionForm";
            this.Load += new System.EventHandler(this.PermissionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Permissions_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveChanges_button;
        private System.Windows.Forms.Button AdminPanel_button;
        private System.Windows.Forms.DataGridView Permissions_dataGridView;
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet;
        private System.Windows.Forms.BindingSource permissionsBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.PermissionsTableAdapter permissionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}