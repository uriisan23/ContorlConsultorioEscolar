namespace EasyMed
{
    partial class VisitView
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
            this.VisitGrid = new System.Windows.Forms.DataGridView();
            this.VisitName = new System.Windows.Forms.TextBox();
            this.AddVisit = new System.Windows.Forms.Button();
            this.DelVisit = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.warningText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VisitGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisitGrid
            // 
            this.VisitGrid.AllowUserToAddRows = false;
            this.VisitGrid.AllowUserToDeleteRows = false;
            this.VisitGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.VisitGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VisitGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitGrid.Location = new System.Drawing.Point(47, 130);
            this.VisitGrid.Name = "VisitGrid";
            this.VisitGrid.ReadOnly = true;
            this.VisitGrid.Size = new System.Drawing.Size(317, 189);
            this.VisitGrid.TabIndex = 0;
            this.VisitGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisitGrid_CellContentClick);
            // 
            // VisitName
            // 
            this.VisitName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VisitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitName.Location = new System.Drawing.Point(47, 84);
            this.VisitName.Name = "VisitName";
            this.VisitName.Size = new System.Drawing.Size(317, 20);
            this.VisitName.TabIndex = 1;
            this.VisitName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VisitName_KeyPress);
            // 
            // AddVisit
            // 
            this.AddVisit.FlatAppearance.BorderSize = 0;
            this.AddVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVisit.ForeColor = System.Drawing.Color.GhostWhite;
            this.AddVisit.Location = new System.Drawing.Point(3, 3);
            this.AddVisit.Name = "AddVisit";
            this.AddVisit.Size = new System.Drawing.Size(39, 35);
            this.AddVisit.TabIndex = 2;
            this.AddVisit.Text = "+";
            this.AddVisit.UseVisualStyleBackColor = true;
            this.AddVisit.Click += new System.EventHandler(this.AddVisit_Click);
            // 
            // DelVisit
            // 
            this.DelVisit.FlatAppearance.BorderSize = 0;
            this.DelVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelVisit.ForeColor = System.Drawing.Color.GhostWhite;
            this.DelVisit.Location = new System.Drawing.Point(52, 3);
            this.DelVisit.Name = "DelVisit";
            this.DelVisit.Size = new System.Drawing.Size(39, 35);
            this.DelVisit.TabIndex = 3;
            this.DelVisit.Text = "-";
            this.DelVisit.UseVisualStyleBackColor = true;
            this.DelVisit.Click += new System.EventHandler(this.DelVisit_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.HotTrack;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Lavender;
            this.close.Location = new System.Drawing.Point(366, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 33);
            this.close.TabIndex = 4;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button1_Click);
            // 
            // warningText
            // 
            this.warningText.AutoSize = true;
            this.warningText.Font = new System.Drawing.Font("Aparajita", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningText.ForeColor = System.Drawing.Color.Red;
            this.warningText.Location = new System.Drawing.Point(43, 62);
            this.warningText.Name = "warningText";
            this.warningText.Size = new System.Drawing.Size(41, 19);
            this.warningText.TabIndex = 5;
            this.warningText.Text = "label1";
            this.warningText.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.AddVisit);
            this.panel1.Controls.Add(this.DelVisit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 46);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(250, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de Visitas";
            // 
            // VisitView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(400, 386);
            this.Controls.Add(this.warningText);
            this.Controls.Add(this.VisitName);
            this.Controls.Add(this.VisitGrid);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisitView";
            this.Text = "Configuracion Visitas";
            this.Load += new System.EventHandler(this.VisitView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisitGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VisitGrid;
        private System.Windows.Forms.TextBox VisitName;
        private System.Windows.Forms.Button AddVisit;
        private System.Windows.Forms.Button DelVisit;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label warningText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}