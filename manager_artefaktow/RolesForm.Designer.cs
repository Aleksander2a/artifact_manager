namespace manager_artefaktow
{
    partial class RolesForm
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
            this.Menu_button = new System.Windows.Forms.Button();
            this.Roles_dataGridView = new System.Windows.Forms.DataGridView();
            this.rolesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artifactManagerDatabaseDataSet = new manager_artefaktow.ArtifactManagerDatabaseDataSet();
            this.SaveChanges_button = new System.Windows.Forms.Button();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new manager_artefaktow.ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Roles_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_button
            // 
            this.Menu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Menu_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Menu_button.Location = new System.Drawing.Point(12, 367);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(212, 71);
            this.Menu_button.TabIndex = 19;
            this.Menu_button.Text = "Back to Admin Panel";
            this.Menu_button.UseVisualStyleBackColor = false;
            this.Menu_button.Click += new System.EventHandler(this.AdminPanel_button_Click);
            // 
            // Roles_dataGridView
            // 
            this.Roles_dataGridView.AutoGenerateColumns = false;
            this.Roles_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Roles_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleName});
            this.Roles_dataGridView.DataSource = this.rolesBindingSource1;
            this.Roles_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Roles_dataGridView.Name = "Roles_dataGridView";
            this.Roles_dataGridView.RowHeadersWidth = 62;
            this.Roles_dataGridView.RowTemplate.Height = 28;
            this.Roles_dataGridView.Size = new System.Drawing.Size(240, 150);
            this.Roles_dataGridView.TabIndex = 20;
            this.Roles_dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Roles_dataGridView_DataError);
            this.Roles_dataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Roles_dataGridView_RowValidating);
            // 
            // rolesBindingSource1
            // 
            this.rolesBindingSource1.DataMember = "Roles";
            this.rolesBindingSource1.DataSource = this.artifactManagerDatabaseDataSet;
            // 
            // artifactManagerDatabaseDataSet
            // 
            this.artifactManagerDatabaseDataSet.DataSetName = "ArtifactManagerDatabaseDataSet";
            this.artifactManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveChanges_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveChanges_button.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveChanges_button.Location = new System.Drawing.Point(576, 367);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(212, 71);
            this.SaveChanges_button.TabIndex = 21;
            this.SaveChanges_button.Text = "Save Changes";
            this.SaveChanges_button.UseVisualStyleBackColor = false;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click);
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
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "RoleName";
            this.RoleName.MinimumWidth = 8;
            this.RoleName.Name = "RoleName";
            this.RoleName.Width = 150;
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveChanges_button);
            this.Controls.Add(this.Roles_dataGridView);
            this.Controls.Add(this.Menu_button);
            this.Name = "RolesForm";
            this.Text = "Roles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RolesForm_FormClosing);
            this.Load += new System.EventHandler(this.RolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Roles_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactManagerDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Menu_button;
        private ArtifactManagerDatabaseDataSet artifactManagerDatabaseDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private ArtifactManagerDatabaseDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.DataGridView Roles_dataGridView;
        private System.Windows.Forms.Button SaveChanges_button;
        private System.Windows.Forms.BindingSource rolesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
    }
}