namespace manager_artefaktow
{
    partial class LoginForm
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
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.UserName_textBox = new System.Windows.Forms.TextBox();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Register_label = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.Menu_button = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(163, 132);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(206, 26);
            this.Password_textBox.TabIndex = 16;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(20, 135);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(78, 20);
            this.Password_label.TabIndex = 15;
            this.Password_label.Text = "Password";
            // 
            // UserName_textBox
            // 
            this.UserName_textBox.Location = new System.Drawing.Point(163, 80);
            this.UserName_textBox.Name = "UserName_textBox";
            this.UserName_textBox.Size = new System.Drawing.Size(206, 26);
            this.UserName_textBox.TabIndex = 14;
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Location = new System.Drawing.Point(20, 83);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(83, 20);
            this.UserName_label.TabIndex = 13;
            this.UserName_label.Text = "Username";
            // 
            // Register_label
            // 
            this.Register_label.AutoSize = true;
            this.Register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Register_label.Location = new System.Drawing.Point(12, 9);
            this.Register_label.Name = "Register_label";
            this.Register_label.Size = new System.Drawing.Size(123, 46);
            this.Register_label.TabIndex = 12;
            this.Register_label.Text = "Login";
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Login_button.Location = new System.Drawing.Point(24, 188);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(212, 71);
            this.Login_button.TabIndex = 19;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Menu_button
            // 
            this.Menu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Menu_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Menu_button.Location = new System.Drawing.Point(24, 367);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(212, 71);
            this.Menu_button.TabIndex = 18;
            this.Menu_button.Text = "Back to Menu";
            this.Menu_button.UseVisualStyleBackColor = false;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.LimeGreen;
            this.Register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Register_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Register_button.Location = new System.Drawing.Point(576, 367);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(212, 71);
            this.Register_button.TabIndex = 17;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Menu_button);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.UserName_textBox);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.Register_label);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox UserName_textBox;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.Label Register_label;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Menu_button;
        private System.Windows.Forms.Button Register_button;
    }
}