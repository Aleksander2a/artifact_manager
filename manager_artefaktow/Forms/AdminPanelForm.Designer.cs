namespace manager_artefaktow
{
    partial class AdminPanelForm
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
            this.Register_label = new System.Windows.Forms.Label();
            this.Users_button = new System.Windows.Forms.Button();
            this.Roles_button = new System.Windows.Forms.Button();
            this.Permissions_button = new System.Windows.Forms.Button();
            this.Browse_Artifacts_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register_label
            // 
            this.Register_label.AutoSize = true;
            this.Register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Register_label.Location = new System.Drawing.Point(12, 9);
            this.Register_label.Name = "Register_label";
            this.Register_label.Size = new System.Drawing.Size(257, 46);
            this.Register_label.TabIndex = 6;
            this.Register_label.Text = "Admin Panel";
            // 
            // Users_button
            // 
            this.Users_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Users_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Users_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Users_button.Location = new System.Drawing.Point(284, 63);
            this.Users_button.Name = "Users_button";
            this.Users_button.Size = new System.Drawing.Size(212, 71);
            this.Users_button.TabIndex = 18;
            this.Users_button.Text = "Users";
            this.Users_button.UseVisualStyleBackColor = false;
            this.Users_button.Click += new System.EventHandler(this.Users_button_Click);
            // 
            // Roles_button
            // 
            this.Roles_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Roles_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Roles_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Roles_button.Location = new System.Drawing.Point(284, 169);
            this.Roles_button.Name = "Roles_button";
            this.Roles_button.Size = new System.Drawing.Size(212, 71);
            this.Roles_button.TabIndex = 19;
            this.Roles_button.Text = "Roles";
            this.Roles_button.UseVisualStyleBackColor = false;
            this.Roles_button.Click += new System.EventHandler(this.Roles_button_Click);
            // 
            // Permissions_button
            // 
            this.Permissions_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Permissions_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Permissions_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Permissions_button.Location = new System.Drawing.Point(284, 269);
            this.Permissions_button.Name = "Permissions_button";
            this.Permissions_button.Size = new System.Drawing.Size(212, 71);
            this.Permissions_button.TabIndex = 20;
            this.Permissions_button.Text = "Permission";
            this.Permissions_button.UseVisualStyleBackColor = false;
            this.Permissions_button.Click += new System.EventHandler(this.Permissions_button_Click);
            // 
            // Browse_Artifacts_button
            // 
            this.Browse_Artifacts_button.BackColor = System.Drawing.Color.Green;
            this.Browse_Artifacts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Browse_Artifacts_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Browse_Artifacts_button.Location = new System.Drawing.Point(284, 367);
            this.Browse_Artifacts_button.Name = "Browse_Artifacts_button";
            this.Browse_Artifacts_button.Size = new System.Drawing.Size(212, 71);
            this.Browse_Artifacts_button.TabIndex = 21;
            this.Browse_Artifacts_button.Text = "Browse Artifacts";
            this.Browse_Artifacts_button.UseVisualStyleBackColor = false;
            this.Browse_Artifacts_button.Click += new System.EventHandler(this.Browse_Artifacts_button_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Browse_Artifacts_button);
            this.Controls.Add(this.Permissions_button);
            this.Controls.Add(this.Roles_button);
            this.Controls.Add(this.Users_button);
            this.Controls.Add(this.Register_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminPanelForm";
            this.Text = "Admin Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanelForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Register_label;
        private System.Windows.Forms.Button Users_button;
        private System.Windows.Forms.Button Roles_button;
        private System.Windows.Forms.Button Permissions_button;
        private System.Windows.Forms.Button Browse_Artifacts_button;
    }
}