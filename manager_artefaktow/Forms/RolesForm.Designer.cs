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
            this.components = new System.ComponentModel.Container();
            this.AdminPanel_button = new System.Windows.Forms.Button();
            this.Roles_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artifactManagerDatabaseDataSet3 = new manager_artefaktow.ArtifactManagerDatabaseDataSet();
            this.SaveChanges_button = new System.Windows.Forms.Button();
            this.rolesTableAdapter3 = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter();
            this.RoleDetails_label = new System.Windows.Forms.Label();
            this.RoleName_label = new System.Windows.Forms.Label();
            this.RoleName_textBox = new System.Windows.Forms.TextBox();
            this.Permissions_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.Permissions_label = new System.Windows.Forms.Label();
            this.permissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissionsTableAdapter2 = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.PermissionsTableAdapter();
            this.AddRole_button = new System.Windows.Forms.Button();
            this.NewRole_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Roles_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).BeginInit();
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
            this.Roles_dataGridView.AllowUserToAddRows = false;
            this.Roles_dataGridView.AutoGenerateColumns = false;
            this.Roles_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Roles_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.Roles_dataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.rolesBindingSource, "RoleName", true));
            this.Roles_dataGridView.DataSource = this.rolesBindingSource;
            this.Roles_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Roles_dataGridView.Name = "Roles_dataGridView";
            this.Roles_dataGridView.ReadOnly = true;
            this.Roles_dataGridView.RowHeadersWidth = 62;
            this.Roles_dataGridView.RowTemplate.Height = 28;
            this.Roles_dataGridView.Size = new System.Drawing.Size(338, 278);
            this.Roles_dataGridView.TabIndex = 20;
            this.Roles_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Roles_dataGridView_CellClick);
            this.Roles_dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Roles_dataGridView_DataError);
            this.Roles_dataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Roles_dataGridView_RowValidating);
            this.Roles_dataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Roles_dataGridView_UserDeletedRow);
            this.Roles_dataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Roles_dataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RoleName";
            this.dataGridViewTextBoxColumn2.HeaderText = "RoleName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.artifactManagerDatabaseDataSet3;
            // 
            // artifactManagerDatabaseDataSet3
            // 
            this.artifactManagerDatabaseDataSet3.DataSetName = "ArtifactManagerDatabaseDataSet";
            this.artifactManagerDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveChanges_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveChanges_button.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveChanges_button.Location = new System.Drawing.Point(606, 296);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(141, 50);
            this.SaveChanges_button.TabIndex = 21;
            this.SaveChanges_button.Text = "Save";
            this.SaveChanges_button.UseVisualStyleBackColor = false;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click);
            // 
            // rolesTableAdapter3
            // 
            this.rolesTableAdapter3.ClearBeforeFill = true;
            // 
            // RoleDetails_label
            // 
            this.RoleDetails_label.AutoSize = true;
            this.RoleDetails_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoleDetails_label.Location = new System.Drawing.Point(512, 9);
            this.RoleDetails_label.Name = "RoleDetails_label";
            this.RoleDetails_label.Size = new System.Drawing.Size(180, 32);
            this.RoleDetails_label.TabIndex = 22;
            this.RoleDetails_label.Text = "Role Details";
            // 
            // RoleName_label
            // 
            this.RoleName_label.AutoSize = true;
            this.RoleName_label.Location = new System.Drawing.Point(552, 61);
            this.RoleName_label.Name = "RoleName_label";
            this.RoleName_label.Size = new System.Drawing.Size(88, 20);
            this.RoleName_label.TabIndex = 23;
            this.RoleName_label.Text = "Role Name";
            // 
            // RoleName_textBox
            // 
            this.RoleName_textBox.Location = new System.Drawing.Point(470, 84);
            this.RoleName_textBox.Name = "RoleName_textBox";
            this.RoleName_textBox.ReadOnly = true;
            this.RoleName_textBox.Size = new System.Drawing.Size(277, 26);
            this.RoleName_textBox.TabIndex = 24;
            // 
            // Permissions_checkedListBox
            // 
            this.Permissions_checkedListBox.FormattingEnabled = true;
            this.Permissions_checkedListBox.Location = new System.Drawing.Point(470, 148);
            this.Permissions_checkedListBox.Name = "Permissions_checkedListBox";
            this.Permissions_checkedListBox.Size = new System.Drawing.Size(277, 142);
            this.Permissions_checkedListBox.TabIndex = 25;
            // 
            // Permissions_label
            // 
            this.Permissions_label.AutoSize = true;
            this.Permissions_label.Location = new System.Drawing.Point(552, 125);
            this.Permissions_label.Name = "Permissions_label";
            this.Permissions_label.Size = new System.Drawing.Size(94, 20);
            this.Permissions_label.TabIndex = 26;
            this.Permissions_label.Text = "Permissions";
            // 
            // permissionsBindingSource
            // 
            this.permissionsBindingSource.DataMember = "Permissions";
            this.permissionsBindingSource.DataSource = this.artifactManagerDatabaseDataSet3;
            // 
            // permissionsTableAdapter2
            // 
            this.permissionsTableAdapter2.ClearBeforeFill = true;
            // 
            // AddRole_button
            // 
            this.AddRole_button.BackColor = System.Drawing.Color.Blue;
            this.AddRole_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddRole_button.ForeColor = System.Drawing.SystemColors.Control;
            this.AddRole_button.Location = new System.Drawing.Point(12, 308);
            this.AddRole_button.Name = "AddRole_button";
            this.AddRole_button.Size = new System.Drawing.Size(87, 38);
            this.AddRole_button.TabIndex = 27;
            this.AddRole_button.Text = "Add Role";
            this.AddRole_button.UseVisualStyleBackColor = false;
            this.AddRole_button.Click += new System.EventHandler(this.AddRole_button_Click);
            // 
            // NewRole_textBox
            // 
            this.NewRole_textBox.Location = new System.Drawing.Point(105, 316);
            this.NewRole_textBox.Name = "NewRole_textBox";
            this.NewRole_textBox.Size = new System.Drawing.Size(245, 26);
            this.NewRole_textBox.TabIndex = 28;
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewRole_textBox);
            this.Controls.Add(this.AddRole_button);
            this.Controls.Add(this.Permissions_label);
            this.Controls.Add(this.Permissions_checkedListBox);
            this.Controls.Add(this.RoleName_textBox);
            this.Controls.Add(this.RoleName_label);
            this.Controls.Add(this.RoleDetails_label);
            this.Controls.Add(this.SaveChanges_button);
            this.Controls.Add(this.Roles_dataGridView);
            this.Controls.Add(this.AdminPanel_button);
            this.Name = "RolesForm";
            this.Text = "Roles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RolesForm_FormClosing);
            this.Load += new System.EventHandler(this.RolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Roles_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet3;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter rolesTableAdapter3;
        private System.Windows.Forms.Label RoleDetails_label;
        private System.Windows.Forms.Label RoleName_label;
        private System.Windows.Forms.TextBox RoleName_textBox;
        private System.Windows.Forms.CheckedListBox Permissions_checkedListBox;
        private System.Windows.Forms.Label Permissions_label;
        private System.Windows.Forms.BindingSource permissionsBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.PermissionsTableAdapter permissionsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button AddRole_button;
        private System.Windows.Forms.TextBox NewRole_textBox;
    }
}