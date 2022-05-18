namespace manager_artefaktow
{
    partial class UsersForm
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
            this.Users_dataGridView = new System.Windows.Forms.DataGridView();
            this.Encrypt_textBox = new System.Windows.Forms.TextBox();
            this.Encrypt_button = new System.Windows.Forms.Button();
            this.PasswordEncrypto_label = new System.Windows.Forms.Label();
            this.DefaultRole_label = new System.Windows.Forms.Label();
            this.DefaultRole_comboBox = new System.Windows.Forms.ComboBox();
            this.artifactManagerDatabaseDataSet = new manager_artefaktow.ArtifactManagerDatabaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.UsersTableAdapter();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter();
            this.rolesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveChanges_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveChanges_button.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveChanges_button.Location = new System.Drawing.Point(584, 375);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(212, 71);
            this.SaveChanges_button.TabIndex = 23;
            this.SaveChanges_button.Text = "Save Changes";
            this.SaveChanges_button.UseVisualStyleBackColor = false;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click);
            // 
            // AdminPanel_button
            // 
            this.AdminPanel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AdminPanel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdminPanel_button.ForeColor = System.Drawing.SystemColors.Control;
            this.AdminPanel_button.Location = new System.Drawing.Point(12, 375);
            this.AdminPanel_button.Name = "AdminPanel_button";
            this.AdminPanel_button.Size = new System.Drawing.Size(212, 71);
            this.AdminPanel_button.TabIndex = 22;
            this.AdminPanel_button.Text = "Back to Admin Panel";
            this.AdminPanel_button.UseVisualStyleBackColor = false;
            this.AdminPanel_button.Click += new System.EventHandler(this.AdminPanel_button_Click);
            // 
            // Users_dataGridView
            // 
            this.Users_dataGridView.AutoGenerateColumns = false;
            this.Users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn,
            this.RoleName});
            this.Users_dataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.usersBindingSource, "UserName", true));
            this.Users_dataGridView.DataSource = this.usersBindingSource;
            this.Users_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Users_dataGridView.Name = "Users_dataGridView";
            this.Users_dataGridView.RowHeadersWidth = 62;
            this.Users_dataGridView.RowTemplate.Height = 28;
            this.Users_dataGridView.Size = new System.Drawing.Size(775, 270);
            this.Users_dataGridView.TabIndex = 24;
            this.Users_dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Users_dataGridView_DataError);
            this.Users_dataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Users_dataGridView_RowValidating);
            // 
            // Encrypt_textBox
            // 
            this.Encrypt_textBox.Location = new System.Drawing.Point(168, 297);
            this.Encrypt_textBox.Name = "Encrypt_textBox";
            this.Encrypt_textBox.Size = new System.Drawing.Size(508, 26);
            this.Encrypt_textBox.TabIndex = 25;
            // 
            // Encrypt_button
            // 
            this.Encrypt_button.BackColor = System.Drawing.Color.Blue;
            this.Encrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Encrypt_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Encrypt_button.Location = new System.Drawing.Point(682, 288);
            this.Encrypt_button.Name = "Encrypt_button";
            this.Encrypt_button.Size = new System.Drawing.Size(105, 41);
            this.Encrypt_button.TabIndex = 26;
            this.Encrypt_button.Text = "Encrypt";
            this.Encrypt_button.UseVisualStyleBackColor = false;
            this.Encrypt_button.Click += new System.EventHandler(this.Encrypt_button_Click);
            // 
            // PasswordEncrypto_label
            // 
            this.PasswordEncrypto_label.AutoSize = true;
            this.PasswordEncrypto_label.Location = new System.Drawing.Point(12, 300);
            this.PasswordEncrypto_label.Name = "PasswordEncrypto_label";
            this.PasswordEncrypto_label.Size = new System.Drawing.Size(150, 20);
            this.PasswordEncrypto_label.TabIndex = 27;
            this.PasswordEncrypto_label.Text = "Password Encryptor";
            // 
            // DefaultRole_label
            // 
            this.DefaultRole_label.AutoSize = true;
            this.DefaultRole_label.Location = new System.Drawing.Point(12, 335);
            this.DefaultRole_label.Name = "DefaultRole_label";
            this.DefaultRole_label.Size = new System.Drawing.Size(232, 20);
            this.DefaultRole_label.TabIndex = 28;
            this.DefaultRole_label.Text = "Default role for user registration";
            // 
            // DefaultRole_comboBox
            // 
            this.DefaultRole_comboBox.DataSource = this.rolesBindingSource1;
            this.DefaultRole_comboBox.DisplayMember = "RoleName";
            this.DefaultRole_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefaultRole_comboBox.FormattingEnabled = true;
            this.DefaultRole_comboBox.Location = new System.Drawing.Point(250, 332);
            this.DefaultRole_comboBox.Name = "DefaultRole_comboBox";
            this.DefaultRole_comboBox.Size = new System.Drawing.Size(239, 28);
            this.DefaultRole_comboBox.TabIndex = 29;
            // 
            // artifactManagerDatabaseDataSet
            // 
            this.artifactManagerDatabaseDataSet.DataSetName = "ArtifactManagerDatabaseDataSet";
            this.artifactManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // rolesBindingSource1
            // 
            this.rolesBindingSource1.DataMember = "Roles";
            this.rolesBindingSource1.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // RoleName
            // 
            this.RoleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.DataSource = this.rolesBindingSource;
            this.RoleName.DisplayMember = "RoleName";
            this.RoleName.HeaderText = "RoleName";
            this.RoleName.MinimumWidth = 8;
            this.RoleName.Name = "RoleName";
            this.RoleName.ValueMember = "RoleName";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.DefaultRole_comboBox);
            this.Controls.Add(this.DefaultRole_label);
            this.Controls.Add(this.PasswordEncrypto_label);
            this.Controls.Add(this.Encrypt_button);
            this.Controls.Add(this.Encrypt_textBox);
            this.Controls.Add(this.Users_dataGridView);
            this.Controls.Add(this.SaveChanges_button);
            this.Controls.Add(this.AdminPanel_button);
            this.Name = "UsersForm";
            this.Text = "Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersForm_FormClosing);
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveChanges_button;
        private System.Windows.Forms.Button AdminPanel_button;
        private System.Windows.Forms.DataGridView Users_dataGridView;
        //private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet;
        //private ArtifactManagerDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        //private ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        //private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet1;
        //private ArtifactManagerDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        //private ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter rolesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Encrypt_textBox;
        private System.Windows.Forms.Button Encrypt_button;
        private System.Windows.Forms.Label PasswordEncrypto_label;
        private System.Windows.Forms.Label DefaultRole_label;
        private System.Windows.Forms.ComboBox DefaultRole_comboBox;
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RoleName;
    }
}