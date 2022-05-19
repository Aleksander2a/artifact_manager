namespace manager_artefaktow.Forms
{
    partial class PasswordChangeForm
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
            this.Register_button = new System.Windows.Forms.Button();
            this.ConfirmNewPass_Password_textBox = new System.Windows.Forms.TextBox();
            this.ConfNewPass_label = new System.Windows.Forms.Label();
            this.NewPass_textBox = new System.Windows.Forms.TextBox();
            this.NewPass_label = new System.Windows.Forms.Label();
            this.CurrentPass_textBox = new System.Windows.Forms.TextBox();
            this.currPass_label = new System.Windows.Forms.Label();
            this.Register_label = new System.Windows.Forms.Label();
            this.Menu_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.LimeGreen;
            this.Register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Register_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Register_button.Location = new System.Drawing.Point(576, 367);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(212, 71);
            this.Register_button.TabIndex = 20;
            this.Register_button.Text = "Change Password";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // ConfirmNewPass_Password_textBox
            // 
            this.ConfirmNewPass_Password_textBox.Location = new System.Drawing.Point(196, 184);
            this.ConfirmNewPass_Password_textBox.Name = "ConfirmNewPass_Password_textBox";
            this.ConfirmNewPass_Password_textBox.PasswordChar = '*';
            this.ConfirmNewPass_Password_textBox.Size = new System.Drawing.Size(206, 26);
            this.ConfirmNewPass_Password_textBox.TabIndex = 19;
            // 
            // ConfNewPass_label
            // 
            this.ConfNewPass_label.AutoSize = true;
            this.ConfNewPass_label.Location = new System.Drawing.Point(20, 187);
            this.ConfNewPass_label.Name = "ConfNewPass_label";
            this.ConfNewPass_label.Size = new System.Drawing.Size(170, 20);
            this.ConfNewPass_label.TabIndex = 18;
            this.ConfNewPass_label.Text = "Confirm new Password";
            // 
            // NewPass_textBox
            // 
            this.NewPass_textBox.Location = new System.Drawing.Point(196, 132);
            this.NewPass_textBox.Name = "NewPass_textBox";
            this.NewPass_textBox.PasswordChar = '*';
            this.NewPass_textBox.Size = new System.Drawing.Size(206, 26);
            this.NewPass_textBox.TabIndex = 17;
            // 
            // NewPass_label
            // 
            this.NewPass_label.AutoSize = true;
            this.NewPass_label.Location = new System.Drawing.Point(20, 135);
            this.NewPass_label.Name = "NewPass_label";
            this.NewPass_label.Size = new System.Drawing.Size(113, 20);
            this.NewPass_label.TabIndex = 16;
            this.NewPass_label.Text = "New Password";
            // 
            // CurrentPass_textBox
            // 
            this.CurrentPass_textBox.Location = new System.Drawing.Point(196, 80);
            this.CurrentPass_textBox.Name = "CurrentPass_textBox";
            this.CurrentPass_textBox.PasswordChar = '*';
            this.CurrentPass_textBox.Size = new System.Drawing.Size(206, 26);
            this.CurrentPass_textBox.TabIndex = 15;
            // 
            // currPass_label
            // 
            this.currPass_label.AutoSize = true;
            this.currPass_label.Location = new System.Drawing.Point(20, 83);
            this.currPass_label.Name = "currPass_label";
            this.currPass_label.Size = new System.Drawing.Size(135, 20);
            this.currPass_label.TabIndex = 14;
            this.currPass_label.Text = "Current Password";
            // 
            // Register_label
            // 
            this.Register_label.AutoSize = true;
            this.Register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Register_label.Location = new System.Drawing.Point(12, 9);
            this.Register_label.Name = "Register_label";
            this.Register_label.Size = new System.Drawing.Size(461, 46);
            this.Register_label.TabIndex = 13;
            this.Register_label.Text = "Change Your Password";
            // 
            // Menu_button
            // 
            this.Menu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Menu_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Menu_button.Location = new System.Drawing.Point(12, 367);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(212, 71);
            this.Menu_button.TabIndex = 21;
            this.Menu_button.Text = "Back to Menu";
            this.Menu_button.UseVisualStyleBackColor = false;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // PasswordChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu_button);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.ConfirmNewPass_Password_textBox);
            this.Controls.Add(this.ConfNewPass_label);
            this.Controls.Add(this.NewPass_textBox);
            this.Controls.Add(this.NewPass_label);
            this.Controls.Add(this.CurrentPass_textBox);
            this.Controls.Add(this.currPass_label);
            this.Controls.Add(this.Register_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PasswordChangeForm";
            this.Text = "Password Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.TextBox ConfirmNewPass_Password_textBox;
        private System.Windows.Forms.Label ConfNewPass_label;
        private System.Windows.Forms.TextBox NewPass_textBox;
        private System.Windows.Forms.Label NewPass_label;
        private System.Windows.Forms.TextBox CurrentPass_textBox;
        private System.Windows.Forms.Label currPass_label;
        private System.Windows.Forms.Label Register_label;
        private System.Windows.Forms.Button Menu_button;
    }
}