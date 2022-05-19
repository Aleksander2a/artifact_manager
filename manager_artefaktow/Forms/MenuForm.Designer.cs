namespace manager_artefaktow
{
    partial class MenuForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_button = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.Browse_Artifacts_button = new System.Windows.Forms.Button();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Login_button.Location = new System.Drawing.Point(287, 83);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(212, 71);
            this.Login_button.TabIndex = 0;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.Teal;
            this.Register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Register_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Register_button.Location = new System.Drawing.Point(287, 176);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(212, 71);
            this.Register_button.TabIndex = 1;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Browse_Artifacts_button
            // 
            this.Browse_Artifacts_button.BackColor = System.Drawing.Color.Green;
            this.Browse_Artifacts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Browse_Artifacts_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Browse_Artifacts_button.Location = new System.Drawing.Point(287, 270);
            this.Browse_Artifacts_button.Name = "Browse_Artifacts_button";
            this.Browse_Artifacts_button.Size = new System.Drawing.Size(212, 71);
            this.Browse_Artifacts_button.TabIndex = 2;
            this.Browse_Artifacts_button.Text = "Browse Artifacts";
            this.Browse_Artifacts_button.UseVisualStyleBackColor = false;
            this.Browse_Artifacts_button.Click += new System.EventHandler(this.Browse_Artifacts_button_Click);
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Welcome_label.Location = new System.Drawing.Point(277, 9);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(231, 55);
            this.Welcome_label.TabIndex = 4;
            this.Welcome_label.Text = "Welcome";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.Browse_Artifacts_button);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Login_button);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Button Browse_Artifacts_button;
        private System.Windows.Forms.Label Welcome_label;
    }
}

