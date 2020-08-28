namespace DBLAB_EXAM
{
    partial class AddingEmployees
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
            this.BADDDOCTOR = new System.Windows.Forms.Button();
            this.BADDNURSE = new System.Windows.Forms.Button();
            this.BADDPHARM = new System.Windows.Forms.Button();
            this.BRECP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BADDDOCTOR
            // 
            this.BADDDOCTOR.Location = new System.Drawing.Point(207, 27);
            this.BADDDOCTOR.Name = "BADDDOCTOR";
            this.BADDDOCTOR.Size = new System.Drawing.Size(227, 96);
            this.BADDDOCTOR.TabIndex = 0;
            this.BADDDOCTOR.Text = "ADD NEW DOCTOR";
            this.BADDDOCTOR.UseVisualStyleBackColor = true;
            this.BADDDOCTOR.Click += new System.EventHandler(this.BADDDOCTOR_Click);
            // 
            // BADDNURSE
            // 
            this.BADDNURSE.Location = new System.Drawing.Point(207, 129);
            this.BADDNURSE.Name = "BADDNURSE";
            this.BADDNURSE.Size = new System.Drawing.Size(227, 96);
            this.BADDNURSE.TabIndex = 1;
            this.BADDNURSE.Text = "ADD NEW NURSE";
            this.BADDNURSE.UseVisualStyleBackColor = true;
            this.BADDNURSE.Click += new System.EventHandler(this.BADDNURSE_Click);
            // 
            // BADDPHARM
            // 
            this.BADDPHARM.Location = new System.Drawing.Point(207, 231);
            this.BADDPHARM.Name = "BADDPHARM";
            this.BADDPHARM.Size = new System.Drawing.Size(227, 96);
            this.BADDPHARM.TabIndex = 2;
            this.BADDPHARM.Text = "ADD NEW PHARMACIST";
            this.BADDPHARM.UseVisualStyleBackColor = true;
            this.BADDPHARM.Click += new System.EventHandler(this.BADDPHARM_Click);
            // 
            // BRECP
            // 
            this.BRECP.Location = new System.Drawing.Point(207, 333);
            this.BRECP.Name = "BRECP";
            this.BRECP.Size = new System.Drawing.Size(227, 96);
            this.BRECP.TabIndex = 3;
            this.BRECP.Text = "ADD NEW RECP";
            this.BRECP.UseVisualStyleBackColor = true;
            this.BRECP.Click += new System.EventHandler(this.BRECP_Click);
            // 
            // AddingEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 532);
            this.Controls.Add(this.BRECP);
            this.Controls.Add(this.BADDPHARM);
            this.Controls.Add(this.BADDNURSE);
            this.Controls.Add(this.BADDDOCTOR);
            this.Name = "AddingEmployees";
            this.Text = "AddingEmployees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddingEmployees_FormClosed);
            this.Load += new System.EventHandler(this.AddingEmployees_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BADDDOCTOR;
        private System.Windows.Forms.Button BADDNURSE;
        private System.Windows.Forms.Button BADDPHARM;
        private System.Windows.Forms.Button BRECP;
    }
}