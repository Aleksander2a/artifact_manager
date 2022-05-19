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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artifactManagerDatabaseDataSet = new manager_artefaktow.ArtifactManagerDatabaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Encrypt_textBox = new System.Windows.Forms.TextBox();
            this.Encrypt_button = new System.Windows.Forms.Button();
            this.PasswordEncrypto_label = new System.Windows.Forms.Label();
            this.DefaultRole_label = new System.Windows.Forms.Label();
            this.DefaultRole_comboBox = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.UsersTableAdapter();
            this.rolesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter();
            this.AddUser_button = new System.Windows.Forms.Button();
            this.NewUserName_textBox = new System.Windows.Forms.TextBox();
            this.NewUserPassword_textBox = new System.Windows.Forms.TextBox();
            this.NewUserRole_comboBox = new System.Windows.Forms.ComboBox();
            this.UserDetails_button = new System.Windows.Forms.Button();
            this.rolesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.NewUserClear_button = new System.Windows.Forms.Button();
            this.UserDetails_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveChanges_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveChanges_button.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveChanges_button.Location = new System.Drawing.Point(497, 386);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(76, 43);
            this.SaveChanges_button.TabIndex = 23;
            this.SaveChanges_button.Text = "Save";
            this.SaveChanges_button.UseVisualStyleBackColor = false;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click);
            // 
            // AdminPanel_button
            // 
            this.AdminPanel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AdminPanel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdminPanel_button.ForeColor = System.Drawing.SystemColors.Control;
            this.AdminPanel_button.Location = new System.Drawing.Point(12, 424);
            this.AdminPanel_button.Name = "AdminPanel_button";
            this.AdminPanel_button.Size = new System.Drawing.Size(212, 31);
            this.AdminPanel_button.TabIndex = 22;
            this.AdminPanel_button.Text = "Back to Admin Panel";
            this.AdminPanel_button.UseVisualStyleBackColor = false;
            this.AdminPanel_button.Click += new System.EventHandler(this.AdminPanel_button_Click);
            // 
            // Users_dataGridView
            // 
            this.Users_dataGridView.AllowUserToAddRows = false;
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
            this.Users_dataGridView.ReadOnly = true;
            this.Users_dataGridView.RowHeadersWidth = 62;
            this.Users_dataGridView.RowTemplate.Height = 28;
            this.Users_dataGridView.Size = new System.Drawing.Size(775, 270);
            this.Users_dataGridView.TabIndex = 24;
            this.Users_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_dataGridView_CellClick);
            this.Users_dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Users_dataGridView_DataError);
            this.Users_dataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Users_dataGridView_RowValidating);
            this.Users_dataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Users_dataGridView_UserDeletedRow);
            this.Users_dataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Users_dataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.RoleName.ReadOnly = true;
            this.RoleName.ValueMember = "RoleName";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.artifactManagerDatabaseDataSet;
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
            // Encrypt_textBox
            // 
            this.Encrypt_textBox.Location = new System.Drawing.Point(168, 359);
            this.Encrypt_textBox.Name = "Encrypt_textBox";
            this.Encrypt_textBox.Size = new System.Drawing.Size(508, 26);
            this.Encrypt_textBox.TabIndex = 25;
            // 
            // Encrypt_button
            // 
            this.Encrypt_button.BackColor = System.Drawing.Color.Blue;
            this.Encrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Encrypt_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Encrypt_button.Location = new System.Drawing.Point(682, 350);
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
            this.PasswordEncrypto_label.Location = new System.Drawing.Point(12, 362);
            this.PasswordEncrypto_label.Name = "PasswordEncrypto_label";
            this.PasswordEncrypto_label.Size = new System.Drawing.Size(150, 20);
            this.PasswordEncrypto_label.TabIndex = 27;
            this.PasswordEncrypto_label.Text = "Password Encryptor";
            // 
            // DefaultRole_label
            // 
            this.DefaultRole_label.AutoSize = true;
            this.DefaultRole_label.Location = new System.Drawing.Point(14, 399);
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
            this.DefaultRole_comboBox.Location = new System.Drawing.Point(252, 396);
            this.DefaultRole_comboBox.Name = "DefaultRole_comboBox";
            this.DefaultRole_comboBox.Size = new System.Drawing.Size(239, 28);
            this.DefaultRole_comboBox.TabIndex = 29;
            // 
            // rolesBindingSource1
            // 
            this.rolesBindingSource1.DataMember = "Roles";
            this.rolesBindingSource1.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // AddUser_button
            // 
            this.AddUser_button.BackColor = System.Drawing.Color.LimeGreen;
            this.AddUser_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddUser_button.ForeColor = System.Drawing.SystemColors.Control;
            this.AddUser_button.Location = new System.Drawing.Point(12, 288);
            this.AddUser_button.Name = "AddUser_button";
            this.AddUser_button.Size = new System.Drawing.Size(60, 59);
            this.AddUser_button.TabIndex = 30;
            this.AddUser_button.Text = "Add";
            this.AddUser_button.UseVisualStyleBackColor = false;
            this.AddUser_button.Click += new System.EventHandler(this.AddUser_button_Click);
            // 
            // NewUserName_textBox
            // 
            this.NewUserName_textBox.Location = new System.Drawing.Point(83, 309);
            this.NewUserName_textBox.Name = "NewUserName_textBox";
            this.NewUserName_textBox.Size = new System.Drawing.Size(171, 26);
            this.NewUserName_textBox.TabIndex = 31;
            // 
            // NewUserPassword_textBox
            // 
            this.NewUserPassword_textBox.Location = new System.Drawing.Point(260, 309);
            this.NewUserPassword_textBox.Name = "NewUserPassword_textBox";
            this.NewUserPassword_textBox.Size = new System.Drawing.Size(171, 26);
            this.NewUserPassword_textBox.TabIndex = 32;
            // 
            // NewUserRole_comboBox
            // 
            this.NewUserRole_comboBox.DataSource = this.rolesBindingSource2;
            this.NewUserRole_comboBox.DisplayMember = "RoleName";
            this.NewUserRole_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewUserRole_comboBox.FormattingEnabled = true;
            this.NewUserRole_comboBox.Location = new System.Drawing.Point(437, 306);
            this.NewUserRole_comboBox.Name = "NewUserRole_comboBox";
            this.NewUserRole_comboBox.Size = new System.Drawing.Size(171, 28);
            this.NewUserRole_comboBox.TabIndex = 33;
            // 
            // UserDetails_button
            // 
            this.UserDetails_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UserDetails_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserDetails_button.ForeColor = System.Drawing.SystemColors.Control;
            this.UserDetails_button.Location = new System.Drawing.Point(699, 396);
            this.UserDetails_button.Name = "UserDetails_button";
            this.UserDetails_button.Size = new System.Drawing.Size(88, 59);
            this.UserDetails_button.TabIndex = 34;
            this.UserDetails_button.Text = "Edit User";
            this.UserDetails_button.UseVisualStyleBackColor = false;
            this.UserDetails_button.Click += new System.EventHandler(this.UserDetails_button_Click);
            // 
            // rolesBindingSource2
            // 
            this.rolesBindingSource2.DataMember = "Roles";
            this.rolesBindingSource2.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // NewUserClear_button
            // 
            this.NewUserClear_button.BackColor = System.Drawing.Color.Red;
            this.NewUserClear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewUserClear_button.ForeColor = System.Drawing.SystemColors.Control;
            this.NewUserClear_button.Location = new System.Drawing.Point(616, 288);
            this.NewUserClear_button.Name = "NewUserClear_button";
            this.NewUserClear_button.Size = new System.Drawing.Size(77, 59);
            this.NewUserClear_button.TabIndex = 35;
            this.NewUserClear_button.Text = "Clear";
            this.NewUserClear_button.UseVisualStyleBackColor = false;
            this.NewUserClear_button.Click += new System.EventHandler(this.NewUserClear_button_Click);
            // 
            // UserDetails_textBox
            // 
            this.UserDetails_textBox.Location = new System.Drawing.Point(593, 414);
            this.UserDetails_textBox.Name = "UserDetails_textBox";
            this.UserDetails_textBox.ReadOnly = true;
            this.UserDetails_textBox.Size = new System.Drawing.Size(100, 26);
            this.UserDetails_textBox.TabIndex = 36;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.UserDetails_textBox);
            this.Controls.Add(this.NewUserClear_button);
            this.Controls.Add(this.UserDetails_button);
            this.Controls.Add(this.NewUserRole_comboBox);
            this.Controls.Add(this.NewUserPassword_textBox);
            this.Controls.Add(this.NewUserName_textBox);
            this.Controls.Add(this.AddUser_button);
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
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource2)).EndInit();
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
        private System.Windows.Forms.Button AddUser_button;
        private System.Windows.Forms.TextBox NewUserName_textBox;
        private System.Windows.Forms.TextBox NewUserPassword_textBox;
        private System.Windows.Forms.ComboBox NewUserRole_comboBox;
        private System.Windows.Forms.Button UserDetails_button;
        private System.Windows.Forms.BindingSource rolesBindingSource2;
        private System.Windows.Forms.Button NewUserClear_button;
        private System.Windows.Forms.TextBox UserDetails_textBox;
    }
}