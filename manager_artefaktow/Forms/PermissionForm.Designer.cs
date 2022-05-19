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
            this.AdminPanel_button = new System.Windows.Forms.Button();
            this.Permissions_dataGridView = new System.Windows.Forms.DataGridView();
            this.permissionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artifactManagerDatabaseDataSet = new manager_artefaktow.ArtifactManagerDatabaseDataSet();
            this.permissionsTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.PermissionsTableAdapter();
            this.AddRole_button = new System.Windows.Forms.Button();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.Type_label = new System.Windows.Forms.Label();
            this.CatORIns_comboBox = new System.Windows.Forms.ComboBox();
            this.Subject_label = new System.Windows.Forms.Label();
            this.Scope_comboBox = new System.Windows.Forms.ComboBox();
            this.Scope_label = new System.Windows.Forms.Label();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.Description_label = new System.Windows.Forms.Label();
            this.Owner_comboBox = new System.Windows.Forms.ComboBox();
            this.Owner_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Permissions_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).BeginInit();
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
            this.AdminPanel_button.TabIndex = 22;
            this.AdminPanel_button.Text = "Back to Admin Panel";
            this.AdminPanel_button.UseVisualStyleBackColor = false;
            this.AdminPanel_button.Click += new System.EventHandler(this.AdminPanel_button_Click);
            // 
            // Permissions_dataGridView
            // 
            this.Permissions_dataGridView.AllowUserToAddRows = false;
            this.Permissions_dataGridView.AutoGenerateColumns = false;
            this.Permissions_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Permissions_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.permissionNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.Permissions_dataGridView.DataSource = this.permissionsBindingSource;
            this.Permissions_dataGridView.Location = new System.Drawing.Point(13, 13);
            this.Permissions_dataGridView.Name = "Permissions_dataGridView";
            this.Permissions_dataGridView.ReadOnly = true;
            this.Permissions_dataGridView.RowHeadersWidth = 62;
            this.Permissions_dataGridView.RowTemplate.Height = 28;
            this.Permissions_dataGridView.Size = new System.Drawing.Size(775, 205);
            this.Permissions_dataGridView.TabIndex = 25;
            this.Permissions_dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Permissions_dataGridView_DataError);
            this.Permissions_dataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Permissions_dataGridView_UserDeletedRow);
            this.Permissions_dataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Permissions_dataGridView_UserDeletingRow);
            // 
            // permissionNameDataGridViewTextBoxColumn
            // 
            this.permissionNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.permissionNameDataGridViewTextBoxColumn.DataPropertyName = "PermissionName";
            this.permissionNameDataGridViewTextBoxColumn.HeaderText = "PermissionName";
            this.permissionNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.permissionNameDataGridViewTextBoxColumn.Name = "permissionNameDataGridViewTextBoxColumn";
            this.permissionNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.permissionNameDataGridViewTextBoxColumn.Width = 164;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // AddRole_button
            // 
            this.AddRole_button.BackColor = System.Drawing.Color.Blue;
            this.AddRole_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddRole_button.ForeColor = System.Drawing.SystemColors.Control;
            this.AddRole_button.Location = new System.Drawing.Point(13, 251);
            this.AddRole_button.Name = "AddRole_button";
            this.AddRole_button.Size = new System.Drawing.Size(167, 102);
            this.AddRole_button.TabIndex = 28;
            this.AddRole_button.Text = "Add or Update";
            this.AddRole_button.UseVisualStyleBackColor = false;
            this.AddRole_button.Click += new System.EventHandler(this.AddRole_button_Click);
            // 
            // Type_comboBox
            // 
            this.Type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_comboBox.FormattingEnabled = true;
            this.Type_comboBox.Location = new System.Drawing.Point(198, 265);
            this.Type_comboBox.Name = "Type_comboBox";
            this.Type_comboBox.Size = new System.Drawing.Size(121, 28);
            this.Type_comboBox.TabIndex = 29;
            this.Type_comboBox.SelectedIndexChanged += new System.EventHandler(this.Type_comboBox_SelectedIndexChanged);
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Location = new System.Drawing.Point(236, 231);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(43, 20);
            this.Type_label.TabIndex = 30;
            this.Type_label.Text = "Type";
            // 
            // CatORIns_comboBox
            // 
            this.CatORIns_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatORIns_comboBox.FormattingEnabled = true;
            this.CatORIns_comboBox.Location = new System.Drawing.Point(335, 265);
            this.CatORIns_comboBox.Name = "CatORIns_comboBox";
            this.CatORIns_comboBox.Size = new System.Drawing.Size(121, 28);
            this.CatORIns_comboBox.TabIndex = 31;
            this.CatORIns_comboBox.SelectedIndexChanged += new System.EventHandler(this.CatORIns_comboBox_SelectedIndexChanged);
            // 
            // Subject_label
            // 
            this.Subject_label.AutoSize = true;
            this.Subject_label.Location = new System.Drawing.Point(363, 231);
            this.Subject_label.Name = "Subject_label";
            this.Subject_label.Size = new System.Drawing.Size(63, 20);
            this.Subject_label.TabIndex = 32;
            this.Subject_label.Text = "Subject";
            // 
            // Scope_comboBox
            // 
            this.Scope_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Scope_comboBox.FormattingEnabled = true;
            this.Scope_comboBox.Location = new System.Drawing.Point(474, 265);
            this.Scope_comboBox.Name = "Scope_comboBox";
            this.Scope_comboBox.Size = new System.Drawing.Size(121, 28);
            this.Scope_comboBox.TabIndex = 33;
            // 
            // Scope_label
            // 
            this.Scope_label.AutoSize = true;
            this.Scope_label.Location = new System.Drawing.Point(504, 231);
            this.Scope_label.Name = "Scope_label";
            this.Scope_label.Size = new System.Drawing.Size(55, 20);
            this.Scope_label.TabIndex = 34;
            this.Scope_label.Text = "Scope";
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(198, 330);
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(535, 26);
            this.Description_textBox.TabIndex = 35;
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Location = new System.Drawing.Point(419, 307);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(89, 20);
            this.Description_label.TabIndex = 36;
            this.Description_label.Text = "Description";
            // 
            // Owner_comboBox
            // 
            this.Owner_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Owner_comboBox.FormattingEnabled = true;
            this.Owner_comboBox.Location = new System.Drawing.Point(612, 265);
            this.Owner_comboBox.Name = "Owner_comboBox";
            this.Owner_comboBox.Size = new System.Drawing.Size(121, 28);
            this.Owner_comboBox.TabIndex = 37;
            // 
            // Owner_label
            // 
            this.Owner_label.AutoSize = true;
            this.Owner_label.Location = new System.Drawing.Point(646, 231);
            this.Owner_label.Name = "Owner_label";
            this.Owner_label.Size = new System.Drawing.Size(55, 20);
            this.Owner_label.TabIndex = 38;
            this.Owner_label.Text = "Owner";
            // 
            // PermissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Owner_label);
            this.Controls.Add(this.Owner_comboBox);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Scope_label);
            this.Controls.Add(this.Scope_comboBox);
            this.Controls.Add(this.Subject_label);
            this.Controls.Add(this.CatORIns_comboBox);
            this.Controls.Add(this.Type_label);
            this.Controls.Add(this.Type_comboBox);
            this.Controls.Add(this.AddRole_button);
            this.Controls.Add(this.Permissions_dataGridView);
            this.Controls.Add(this.AdminPanel_button);
            this.Name = "PermissionForm";
            this.Text = "PermissionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PermissionForm_FormClosing);
            this.Load += new System.EventHandler(this.PermissionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Permissions_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AdminPanel_button;
        private System.Windows.Forms.DataGridView Permissions_dataGridView;
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet;
        private System.Windows.Forms.BindingSource permissionsBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.PermissionsTableAdapter permissionsTableAdapter;
        private System.Windows.Forms.Button AddRole_button;
        private System.Windows.Forms.ComboBox Type_comboBox;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.ComboBox CatORIns_comboBox;
        private System.Windows.Forms.Label Subject_label;
        private System.Windows.Forms.ComboBox Scope_comboBox;
        private System.Windows.Forms.Label Scope_label;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.ComboBox Owner_comboBox;
        private System.Windows.Forms.Label Owner_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}