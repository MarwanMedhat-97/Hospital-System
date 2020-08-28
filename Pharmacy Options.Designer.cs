namespace DBLAB_EXAM
{
    partial class PharmacyOption
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
            this.BView = new System.Windows.Forms.Button();
            this.BADD = new System.Windows.Forms.Button();
            this.BUpdate = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BView
            // 
            this.BView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BView.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BView.ForeColor = System.Drawing.Color.Navy;
            this.BView.Location = new System.Drawing.Point(138, 105);
            this.BView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BView.Name = "BView";
            this.BView.Size = new System.Drawing.Size(359, 129);
            this.BView.TabIndex = 0;
            this.BView.Text = "View Drugs Shortage";
            this.BView.UseVisualStyleBackColor = false;
            this.BView.Click += new System.EventHandler(this.TBView_Click);
            // 
            // BADD
            // 
            this.BADD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BADD.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BADD.ForeColor = System.Drawing.Color.Navy;
            this.BADD.Location = new System.Drawing.Point(138, 242);
            this.BADD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BADD.Name = "BADD";
            this.BADD.Size = new System.Drawing.Size(359, 129);
            this.BADD.TabIndex = 1;
            this.BADD.Text = "Insert/Remove New Drug";
            this.BADD.UseVisualStyleBackColor = false;
            this.BADD.Click += new System.EventHandler(this.BADD_Click);
            // 
            // BUpdate
            // 
            this.BUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BUpdate.ForeColor = System.Drawing.Color.Navy;
            this.BUpdate.Location = new System.Drawing.Point(138, 379);
            this.BUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(359, 129);
            this.BUpdate.TabIndex = 3;
            this.BUpdate.Text = "Update Drug Information";
            this.BUpdate.UseVisualStyleBackColor = false;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.BBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BBack.Location = new System.Drawing.Point(518, 13);
            this.BBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(158, 54);
            this.BBack.TabIndex = 4;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // PharmacyOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 545);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BUpdate);
            this.Controls.Add(this.BADD);
            this.Controls.Add(this.BView);
            this.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PharmacyOption";
            this.Text = "Pharmacy_Options";
            this.Load += new System.EventHandler(this.B_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BView;
        private System.Windows.Forms.Button BADD;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BBack;
    }
}