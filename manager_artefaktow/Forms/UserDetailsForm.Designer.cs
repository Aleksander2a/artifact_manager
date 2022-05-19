namespace manager_artefaktow.Forms
{
    partial class UserDetailsForm
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
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Role_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName_textBox = new System.Windows.Forms.TextBox();
            this.RoleName_label = new System.Windows.Forms.Label();
            this.UserDetails_label = new System.Windows.Forms.Label();
            this.Users_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordEncrypto_label = new System.Windows.Forms.Label();
            this.Encrypt_button = new System.Windows.Forms.Button();
            this.Encrypt_textBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.artifactManagerDatabaseDataSet = new manager_artefaktow.ArtifactManagerDatabaseDataSet();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(291, 154);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(207, 26);
            this.Password_textBox.TabIndex = 82;
            // 
            // Role_label
            // 
            this.Role_label.AutoSize = true;
            this.Role_label.Location = new System.Drawing.Point(367, 187);
            this.Role_label.Name = "Role_label";
            this.Role_label.Size = new System.Drawing.Size(42, 20);
            this.Role_label.TabIndex = 77;
            this.Role_label.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Password";
            // 
            // UserName_textBox
            // 
            this.UserName_textBox.Location = new System.Drawing.Point(291, 97);
            this.UserName_textBox.Name = "UserName_textBox";
            this.UserName_textBox.Size = new System.Drawing.Size(207, 26);
            this.UserName_textBox.TabIndex = 75;
            // 
            // RoleName_label
            // 
            this.RoleName_label.AutoSize = true;
            this.RoleName_label.Location = new System.Drawing.Point(356, 74);
            this.RoleName_label.Name = "RoleName_label";
            this.RoleName_label.Size = new System.Drawing.Size(83, 20);
            this.RoleName_label.TabIndex = 74;
            this.RoleName_label.Text = "Username";
            // 
            // UserDetails_label
            // 
            this.UserDetails_label.AutoSize = true;
            this.UserDetails_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserDetails_label.Location = new System.Drawing.Point(285, 29);
            this.UserDetails_label.Name = "UserDetails_label";
            this.UserDetails_label.Size = new System.Drawing.Size(222, 32);
            this.UserDetails_label.TabIndex = 73;
            this.UserDetails_label.Text = "User Edit Mode";
            // 
            // Users_button
            // 
            this.Users_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Users_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Users_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Users_button.Location = new System.Drawing.Point(12, 407);
            this.Users_button.Name = "Users_button";
            this.Users_button.Size = new System.Drawing.Size(212, 31);
            this.Users_button.TabIndex = 83;
            this.Users_button.Text = "Back to All Users";
            this.Users_button.UseVisualStyleBackColor = false;
            this.Users_button.Click += new System.EventHandler(this.Users_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(576, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 31);
            this.button1.TabIndex = 84;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordEncrypto_label
            // 
            this.PasswordEncrypto_label.AutoSize = true;
            this.PasswordEncrypto_label.Location = new System.Drawing.Point(12, 295);
            this.PasswordEncrypto_label.Name = "PasswordEncrypto_label";
            this.PasswordEncrypto_label.Size = new System.Drawing.Size(150, 20);
            this.PasswordEncrypto_label.TabIndex = 87;
            this.PasswordEncrypto_label.Text = "Password Encryptor";
            // 
            // Encrypt_button
            // 
            this.Encrypt_button.BackColor = System.Drawing.Color.Blue;
            this.Encrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Encrypt_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Encrypt_button.Location = new System.Drawing.Point(682, 283);
            this.Encrypt_button.Name = "Encrypt_button";
            this.Encrypt_button.Size = new System.Drawing.Size(105, 41);
            this.Encrypt_button.TabIndex = 86;
            this.Encrypt_button.Text = "Encrypt";
            this.Encrypt_button.UseVisualStyleBackColor = false;
            this.Encrypt_button.Click += new System.EventHandler(this.Encrypt_button_Click);
            // 
            // Encrypt_textBox
            // 
            this.Encrypt_textBox.Location = new System.Drawing.Point(168, 292);
            this.Encrypt_textBox.Name = "Encrypt_textBox";
            this.Encrypt_textBox.Size = new System.Drawing.Size(508, 26);
            this.Encrypt_textBox.TabIndex = 85;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 28);
            this.comboBox1.TabIndex = 88;
            // 
            // artifactManagerDatabaseDataSet
            // 
            this.artifactManagerDatabaseDataSet.DataSetName = "ArtifactManagerDatabaseDataSet";
            this.artifactManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(358, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 31);
            this.button2.TabIndex = 89;
            this.button2.Text = "Discard Changes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PasswordEncrypto_label);
            this.Controls.Add(this.Encrypt_button);
            this.Controls.Add(this.Encrypt_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Users_button);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Role_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName_textBox);
            this.Controls.Add(this.RoleName_label);
            this.Controls.Add(this.UserDetails_label);
            this.Name = "UserDetailsForm";
            this.Text = "UserDetailsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDetailsForm_FormClosing);
            this.Load += new System.EventHandler(this.UserDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label Role_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName_textBox;
        private System.Windows.Forms.Label RoleName_label;
        private System.Windows.Forms.Label UserDetails_label;
        private System.Windows.Forms.Button Users_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PasswordEncrypto_label;
        private System.Windows.Forms.Button Encrypt_button;
        private System.Windows.Forms.TextBox Encrypt_textBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}