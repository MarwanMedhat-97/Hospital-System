namespace DBLAB_EXAM
{
    partial class Provided_Functionalities
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
            this.Bentities = new System.Windows.Forms.Button();
            this.BEmployees = new System.Windows.Forms.Button();
            this.Blogout = new System.Windows.Forms.Button();
            this.BPatients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bentities
            // 
            this.Bentities.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Bentities.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Bentities.ForeColor = System.Drawing.Color.Navy;
            this.Bentities.Location = new System.Drawing.Point(149, 51);
            this.Bentities.Name = "Bentities";
            this.Bentities.Size = new System.Drawing.Size(193, 88);
            this.Bentities.TabIndex = 0;
            this.Bentities.Text = "Hospital enities";
            this.Bentities.UseVisualStyleBackColor = false;
            this.Bentities.Click += new System.EventHandler(this.Bentities_Click);
            // 
            // BEmployees
            // 
            this.BEmployees.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BEmployees.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BEmployees.ForeColor = System.Drawing.Color.Navy;
            this.BEmployees.Location = new System.Drawing.Point(149, 145);
            this.BEmployees.Name = "BEmployees";
            this.BEmployees.Size = new System.Drawing.Size(193, 88);
            this.BEmployees.TabIndex = 1;
            this.BEmployees.Text = "Employees";
            this.BEmployees.UseVisualStyleBackColor = false;
            this.BEmployees.Click += new System.EventHandler(this.BEmployees_Click);
            // 
            // Blogout
            // 
            this.Blogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Blogout.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Blogout.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Blogout.Location = new System.Drawing.Point(9, 360);
            this.Blogout.Name = "Blogout";
            this.Blogout.Size = new System.Drawing.Size(137, 48);
            this.Blogout.TabIndex = 2;
            this.Blogout.Text = "Log Out";
            this.Blogout.UseVisualStyleBackColor = false;
            this.Blogout.Click += new System.EventHandler(this.Blogout_Click);
            // 
            // BPatients
            // 
            this.BPatients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BPatients.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BPatients.ForeColor = System.Drawing.Color.Navy;
            this.BPatients.Location = new System.Drawing.Point(149, 239);
            this.BPatients.Name = "BPatients";
            this.BPatients.Size = new System.Drawing.Size(193, 88);
            this.BPatients.TabIndex = 3;
            this.BPatients.Text = "Patients";
            this.BPatients.UseVisualStyleBackColor = false;
            this.BPatients.Click += new System.EventHandler(this.BPatients_Click);
            // 
            // Provided_Functionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(523, 416);
            this.Controls.Add(this.BPatients);
            this.Controls.Add(this.Blogout);
            this.Controls.Add(this.BEmployees);
            this.Controls.Add(this.Bentities);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "Provided_Functionalities";
            this.Text = "Provided_Functionalities";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Provided_Functionalities_FormClosed);
            this.Load += new System.EventHandler(this.Provided_Functionalities_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bentities;
        private System.Windows.Forms.Button BEmployees;
        private System.Windows.Forms.Button Blogout;
        private System.Windows.Forms.Button BPatients;
    }
}