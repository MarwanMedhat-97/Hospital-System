namespace DBLAB_EXAM
{
    partial class Hospital_Entities_Funcionalties
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
            this.BPharmacy = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.BDEPOPETION = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BPharmacy
            // 
            this.BPharmacy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BPharmacy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BPharmacy.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BPharmacy.ForeColor = System.Drawing.Color.Navy;
            this.BPharmacy.Location = new System.Drawing.Point(179, 75);
            this.BPharmacy.Name = "BPharmacy";
            this.BPharmacy.Size = new System.Drawing.Size(231, 85);
            this.BPharmacy.TabIndex = 0;
            this.BPharmacy.Text = "Pharmacy Options";
            this.BPharmacy.UseVisualStyleBackColor = false;
            this.BPharmacy.Click += new System.EventHandler(this.BPharmacy_Click);
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BBack.Location = new System.Drawing.Point(488, 12);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(131, 46);
            this.BBack.TabIndex = 1;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // BDEPOPETION
            // 
            this.BDEPOPETION.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BDEPOPETION.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDEPOPETION.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BDEPOPETION.ForeColor = System.Drawing.Color.Navy;
            this.BDEPOPETION.Location = new System.Drawing.Point(179, 201);
            this.BDEPOPETION.Name = "BDEPOPETION";
            this.BDEPOPETION.Size = new System.Drawing.Size(231, 85);
            this.BDEPOPETION.TabIndex = 2;
            this.BDEPOPETION.Text = "Department Options";
            this.BDEPOPETION.UseVisualStyleBackColor = false;
            this.BDEPOPETION.Click += new System.EventHandler(this.BDEPOPETION_Click);
            // 
            // Hospital_Entities_Funcionalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 518);
            this.Controls.Add(this.BDEPOPETION);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BPharmacy);
            this.Name = "Hospital_Entities_Funcionalties";
            this.Text = "Hospital_Entities_Funcionalties";
            this.Load += new System.EventHandler(this.Hospital_Entities_Funcionalties_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BPharmacy;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Button BDEPOPETION;
    }
}