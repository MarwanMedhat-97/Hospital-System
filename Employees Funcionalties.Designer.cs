namespace DBLAB_EXAM
{
    partial class Employees_Funcionalties
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
            this.BRemove = new System.Windows.Forms.Button();
            this.BUpdate = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BADD
            // 
            this.BADD.Location = new System.Drawing.Point(264, 79);
            this.BADD.Name = "BADD";
            this.BADD.Size = new System.Drawing.Size(206, 87);
            this.BADD.TabIndex = 0;
            this.BADD.Text = "Add new Employee";
            this.BADD.UseVisualStyleBackColor = true;
            this.BADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // BRemove
            // 
            this.BRemove.Location = new System.Drawing.Point(264, 172);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(206, 87);
            this.BRemove.TabIndex = 1;
            this.BRemove.Text = "Remove an Employee";
            this.BRemove.UseVisualStyleBackColor = true;
            this.BRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // BUpdate
            // 
            this.BUpdate.Location = new System.Drawing.Point(264, 265);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(206, 87);
            this.BUpdate.TabIndex = 2;
            this.BUpdate.Text = "Update an employee";
            this.BUpdate.UseVisualStyleBackColor = true;
            // 
            // BBack
            // 
            this.BBack.Location = new System.Drawing.Point(589, 12);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(142, 49);
            this.BBack.TabIndex = 3;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // Employees_Funcionalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 526);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BUpdate);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.BADD);
            this.Name = "Employees_Funcionalties";
            this.Text = "Employees_Funcionalties";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Employees_Funcionalties_FormClosed);
            this.Load += new System.EventHandler(this.Employees_Funcionalties_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BADD;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BBack;
    }
}