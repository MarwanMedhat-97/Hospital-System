namespace DBLAB_EXAM
{
    partial class Patients
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
            this.BUpdate = new System.Windows.Forms.Button();
            this.BNEW = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.BVIEW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BUpdate
            // 
            this.BUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUpdate.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.BUpdate.ForeColor = System.Drawing.Color.Navy;
            this.BUpdate.Location = new System.Drawing.Point(143, 317);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(233, 86);
            this.BUpdate.TabIndex = 0;
            this.BUpdate.Text = "Update Case";
            this.BUpdate.UseVisualStyleBackColor = false;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // BNEW
            // 
            this.BNEW.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BNEW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNEW.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.BNEW.ForeColor = System.Drawing.Color.Navy;
            this.BNEW.Location = new System.Drawing.Point(143, 208);
            this.BNEW.Name = "BNEW";
            this.BNEW.Size = new System.Drawing.Size(233, 86);
            this.BNEW.TabIndex = 2;
            this.BNEW.Text = "New Patient";
            this.BNEW.UseVisualStyleBackColor = false;
            this.BNEW.Click += new System.EventHandler(this.BNEW_Click);
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBack.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BBack.Location = new System.Drawing.Point(424, 12);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(137, 52);
            this.BBack.TabIndex = 3;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // BVIEW
            // 
            this.BVIEW.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BVIEW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVIEW.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.BVIEW.ForeColor = System.Drawing.Color.Navy;
            this.BVIEW.Location = new System.Drawing.Point(143, 97);
            this.BVIEW.Name = "BVIEW";
            this.BVIEW.Size = new System.Drawing.Size(233, 86);
            this.BVIEW.TabIndex = 4;
            this.BVIEW.Text = "View Patients";
            this.BVIEW.UseVisualStyleBackColor = false;
            this.BVIEW.Click += new System.EventHandler(this.BVIEW_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(574, 477);
            this.Controls.Add(this.BVIEW);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BNEW);
            this.Controls.Add(this.BUpdate);
            this.Name = "Patients";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BNEW;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Button BVIEW;
    }
}