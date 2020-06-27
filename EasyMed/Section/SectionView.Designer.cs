namespace EasyMed
{
    partial class SectionView
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
            this.AddSection = new System.Windows.Forms.Button();
            this.DelSection = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.warningText = new System.Windows.Forms.Label();
            this.SectionName = new System.Windows.Forms.TextBox();
            this.SectionGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSection
            // 
            this.AddSection.FlatAppearance.BorderSize = 0;
            this.AddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSection.ForeColor = System.Drawing.Color.GhostWhite;
            this.AddSection.Location = new System.Drawing.Point(10, 4);
            this.AddSection.Name = "AddSection";
            this.AddSection.Size = new System.Drawing.Size(39, 35);
            this.AddSection.TabIndex = 2;
            this.AddSection.Text = "+";
            this.AddSection.UseVisualStyleBackColor = true;
            this.AddSection.Click += new System.EventHandler(this.AddSection_Click);
            // 
            // DelSection
            // 
            this.DelSection.FlatAppearance.BorderSize = 0;
            this.DelSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelSection.ForeColor = System.Drawing.Color.GhostWhite;
            this.DelSection.Location = new System.Drawing.Point(59, 4);
            this.DelSection.Name = "DelSection";
            this.DelSection.Size = new System.Drawing.Size(39, 35);
            this.DelSection.TabIndex = 3;
            this.DelSection.Text = "-";
            this.DelSection.UseVisualStyleBackColor = true;
            this.DelSection.Click += new System.EventHandler(this.DelSection_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.HotTrack;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Lavender;
            this.close.Location = new System.Drawing.Point(373, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 33);
            this.close.TabIndex = 7;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddSection);
            this.panel1.Controls.Add(this.DelSection);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 46);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(286, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Secciones";
            // 
            // warningText
            // 
            this.warningText.AutoSize = true;
            this.warningText.Font = new System.Drawing.Font("Aparajita", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningText.ForeColor = System.Drawing.Color.Red;
            this.warningText.Location = new System.Drawing.Point(35, 57);
            this.warningText.Name = "warningText";
            this.warningText.Size = new System.Drawing.Size(41, 19);
            this.warningText.TabIndex = 11;
            this.warningText.Text = "label1";
            this.warningText.Visible = false;
            // 
            // SectionName
            // 
            this.SectionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionName.Location = new System.Drawing.Point(39, 79);
            this.SectionName.Name = "SectionName";
            this.SectionName.Size = new System.Drawing.Size(317, 20);
            this.SectionName.TabIndex = 10;
            this.SectionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SectionName_KeyPress);
            // 
            // SectionGrid
            // 
            this.SectionGrid.AllowUserToAddRows = false;
            this.SectionGrid.AllowUserToDeleteRows = false;
            this.SectionGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.SectionGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SectionGrid.Location = new System.Drawing.Point(39, 125);
            this.SectionGrid.Name = "SectionGrid";
            this.SectionGrid.ReadOnly = true;
            this.SectionGrid.Size = new System.Drawing.Size(317, 189);
            this.SectionGrid.TabIndex = 9;
            // 
            // SectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 383);
            this.Controls.Add(this.warningText);
            this.Controls.Add(this.SectionName);
            this.Controls.Add(this.SectionGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SectionView";
            this.Text = "SectionView";
            this.Load += new System.EventHandler(this.SectionView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSection;
        private System.Windows.Forms.Button DelSection;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label warningText;
        private System.Windows.Forms.TextBox SectionName;
        private System.Windows.Forms.DataGridView SectionGrid;
        private System.Windows.Forms.Label label1;
    }
}