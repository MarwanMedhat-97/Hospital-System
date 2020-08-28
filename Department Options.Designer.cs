namespace DBLAB_EXAM
{
    partial class Department_Options
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
            this.BADD = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.BVIEW = new System.Windows.Forms.Button();
            this.BRemove = new System.Windows.Forms.Button();
            this.BUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BADD
            // 
            this.BADD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BADD.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BADD.ForeColor = System.Drawing.Color.Navy;
            this.BADD.Location = new System.Drawing.Point(165, 201);
            this.BADD.Name = "BADD";
            this.BADD.Size = new System.Drawing.Size(231, 85);
            this.BADD.TabIndex = 1;
            this.BADD.Text = "Insert New Department";
            this.BADD.UseVisualStyleBackColor = false;
            this.BADD.Click += new System.EventHandler(this.BADD_Click);
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BBack.Location = new System.Drawing.Point(456, 12);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(131, 46);
            this.BBack.TabIndex = 2;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // BVIEW
            // 
            this.BVIEW.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BVIEW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVIEW.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BVIEW.ForeColor = System.Drawing.Color.Navy;
            this.BVIEW.Location = new System.Drawing.Point(165, 110);
            this.BVIEW.Name = "BVIEW";
            this.BVIEW.Size = new System.Drawing.Size(231, 85);
            this.BVIEW.TabIndex = 3;
            this.BVIEW.Text = "View Departments";
            this.BVIEW.UseVisualStyleBackColor = false;
            this.BVIEW.Click += new System.EventHandler(this.BVIEW_Click);
            // 
            // BRemove
            // 
            this.BRemove.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRemove.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BRemove.ForeColor = System.Drawing.Color.Navy;
            this.BRemove.Location = new System.Drawing.Point(165, 292);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(231, 85);
            this.BRemove.TabIndex = 4;
            this.BRemove.Text = "Remove A Department";
            this.BRemove.UseVisualStyleBackColor = false;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // BUpdate
            // 
            this.BUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUpdate.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BUpdate.ForeColor = System.Drawing.Color.Navy;
            this.BUpdate.Location = new System.Drawing.Point(165, 383);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(231, 85);
            this.BUpdate.TabIndex = 5;
            this.BUpdate.Text = "Update A Department";
            this.BUpdate.UseVisualStyleBackColor = false;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // Department_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 544);
            this.Controls.Add(this.BUpdate);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.BVIEW);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BADD);
            this.Name = "Department_Options";
            this.Text = "Department_Options";
            this.Load += new System.EventHandler(this.Department_Options_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BADD;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Button BVIEW;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.Button BUpdate;
    }
}