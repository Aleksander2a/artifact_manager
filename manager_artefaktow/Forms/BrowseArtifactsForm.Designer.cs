namespace manager_artefaktow.Forms
{
    partial class BrowseArtifactsForm
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
            this.Artifacts_button = new System.Windows.Forms.Button();
            this.Categories_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Artifacts_button
            // 
            this.Artifacts_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Artifacts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Artifacts_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Artifacts_button.Location = new System.Drawing.Point(299, 179);
            this.Artifacts_button.Name = "Artifacts_button";
            this.Artifacts_button.Size = new System.Drawing.Size(212, 71);
            this.Artifacts_button.TabIndex = 5;
            this.Artifacts_button.Text = "Artifacts";
            this.Artifacts_button.UseVisualStyleBackColor = false;
            this.Artifacts_button.Click += new System.EventHandler(this.Artifacts_button_Click);
            // 
            // Categories_button
            // 
            this.Categories_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Categories_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Categories_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Categories_button.Location = new System.Drawing.Point(299, 86);
            this.Categories_button.Name = "Categories_button";
            this.Categories_button.Size = new System.Drawing.Size(212, 71);
            this.Categories_button.TabIndex = 4;
            this.Categories_button.Text = "Categories";
            this.Categories_button.UseVisualStyleBackColor = false;
            this.Categories_button.Click += new System.EventHandler(this.Categories_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(299, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrowseArtifactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Artifacts_button);
            this.Controls.Add(this.Categories_button);
            this.Name = "BrowseArtifactsForm";
            this.Text = "Browse Artifacts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrowseArtifactsForm_FormClosing);
            this.Load += new System.EventHandler(this.BrowseArtifactsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Artifacts_button;
        private System.Windows.Forms.Button Categories_button;
        private System.Windows.Forms.Button button1;
    }
}