namespace manager_artefaktow
{
    partial class UserHomePageForm
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
            this.ChangePassword_button = new System.Windows.Forms.Button();
            this.Browse_Artifacts_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangePassword_button
            // 
            this.ChangePassword_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ChangePassword_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChangePassword_button.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangePassword_button.Location = new System.Drawing.Point(285, 238);
            this.ChangePassword_button.Name = "ChangePassword_button";
            this.ChangePassword_button.Size = new System.Drawing.Size(212, 71);
            this.ChangePassword_button.TabIndex = 10;
            this.ChangePassword_button.Text = "Change Password";
            this.ChangePassword_button.UseVisualStyleBackColor = false;
            this.ChangePassword_button.Click += new System.EventHandler(this.ChangePassword_button_Click);
            // 
            // Browse_Artifacts_button
            // 
            this.Browse_Artifacts_button.BackColor = System.Drawing.Color.Green;
            this.Browse_Artifacts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Browse_Artifacts_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Browse_Artifacts_button.Location = new System.Drawing.Point(285, 99);
            this.Browse_Artifacts_button.Name = "Browse_Artifacts_button";
            this.Browse_Artifacts_button.Size = new System.Drawing.Size(212, 71);
            this.Browse_Artifacts_button.TabIndex = 11;
            this.Browse_Artifacts_button.Text = "Browse Artifacts";
            this.Browse_Artifacts_button.UseVisualStyleBackColor = false;
            this.Browse_Artifacts_button.Click += new System.EventHandler(this.Browse_Artifacts_button_Click);
            // 
            // UserHomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Browse_Artifacts_button);
            this.Controls.Add(this.ChangePassword_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserHomePageForm";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.UserHomePageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangePassword_button;
        private System.Windows.Forms.Button Browse_Artifacts_button;
    }
}