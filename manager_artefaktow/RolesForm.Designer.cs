namespace manager_artefaktow
{
    partial class RolesForm
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
            this.AdminPanel_button = new System.Windows.Forms.Button();
            this.Roles_dataGridView = new System.Windows.Forms.DataGridView();
            this.Permissions = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SaveChanges_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Roles_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPanel_button
            // 
            this.AdminPanel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AdminPanel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdminPanel_button.ForeColor = System.Drawing.SystemColors.Control;
            this.AdminPanel_button.Location = new System.Drawing.Point(12, 367);
            this.AdminPanel_button.Name = "AdminPanel_button";
            this.AdminPanel_button.Size = new System.Drawing.Size(212, 71);
            this.AdminPanel_button.TabIndex = 19;
            this.AdminPanel_button.Text = "Back to Admin Panel";
            this.AdminPanel_button.UseVisualStyleBackColor = false;
            this.AdminPanel_button.Click += new System.EventHandler(this.AdminPanel_button_Click);
            // 
            // Roles_dataGridView
            // 
            this.Roles_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Roles_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Permissions});
            this.Roles_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Roles_dataGridView.Name = "Roles_dataGridView";
            this.Roles_dataGridView.RowHeadersWidth = 62;
            this.Roles_dataGridView.RowTemplate.Height = 28;
            this.Roles_dataGridView.Size = new System.Drawing.Size(370, 150);
            this.Roles_dataGridView.TabIndex = 20;
            this.Roles_dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Roles_dataGridView_DataError);
            this.Roles_dataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Roles_dataGridView_RowValidating);
            // 
            // Permissions
            // 
            this.Permissions.HeaderText = "Permissions";
            this.Permissions.MinimumWidth = 8;
            this.Permissions.Name = "Permissions";
            this.Permissions.Width = 150;
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveChanges_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveChanges_button.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveChanges_button.Location = new System.Drawing.Point(576, 367);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(212, 71);
            this.SaveChanges_button.TabIndex = 21;
            this.SaveChanges_button.Text = "Save Changes";
            this.SaveChanges_button.UseVisualStyleBackColor = false;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click);
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveChanges_button);
            this.Controls.Add(this.Roles_dataGridView);
            this.Controls.Add(this.AdminPanel_button);
            this.Name = "RolesForm";
            this.Text = "Roles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RolesForm_FormClosing);
            this.Load += new System.EventHandler(this.RolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Roles_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminPanel_button;
        private System.Windows.Forms.DataGridView Roles_dataGridView;
        private System.Windows.Forms.Button SaveChanges_button;
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet;
        private ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet1;
        private ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter rolesTableAdapter1;
        private ArtifactManagerDatabaseDataSetTableAdapters.PermissionsTableAdapter permissionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet2;
        private ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter rolesTableAdapter2;
        private ArtifactManagerDatabaseDataSetTableAdapters.PermissionsTableAdapter permissionsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Permissions;
    }
}