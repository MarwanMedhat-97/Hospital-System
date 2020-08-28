namespace DBLAB_EXAM
{
    partial class Removing_Employees
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
            this.BDocRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BDocRemove
            // 
            this.BDocRemove.Location = new System.Drawing.Point(148, 96);
            this.BDocRemove.Name = "BDocRemove";
            this.BDocRemove.Size = new System.Drawing.Size(215, 75);
            this.BDocRemove.TabIndex = 0;
            this.BDocRemove.Text = "Removing Doctor";
            this.BDocRemove.UseVisualStyleBackColor = true;
            // 
            // Removing_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 479);
            this.Controls.Add(this.BDocRemove);
            this.Name = "Removing_Employees";
            this.Text = "Removing_Employees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BDocRemove;
    }
}