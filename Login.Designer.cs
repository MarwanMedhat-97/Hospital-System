namespace DBLAB_EXAM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Blog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBx_pass = new System.Windows.Forms.TextBox();
            this.TxtBx_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Blog
            // 
            this.Blog.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Blog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Blog.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Blog.ForeColor = System.Drawing.Color.Navy;
            this.Blog.Location = new System.Drawing.Point(495, 180);
            this.Blog.Name = "Blog";
            this.Blog.Size = new System.Drawing.Size(130, 62);
            this.Blog.TabIndex = 0;
            this.Blog.Text = "Login";
            this.Blog.UseVisualStyleBackColor = false;
            this.Blog.Click += new System.EventHandler(this.Blog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label1.Location = new System.Drawing.Point(214, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "user name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label2.Location = new System.Drawing.Point(217, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // TxtBx_pass
            // 
            this.TxtBx_pass.Location = new System.Drawing.Point(318, 231);
            this.TxtBx_pass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_pass.Name = "TxtBx_pass";
            this.TxtBx_pass.PasswordChar = '*';
            this.TxtBx_pass.Size = new System.Drawing.Size(132, 22);
            this.TxtBx_pass.TabIndex = 5;
            this.TxtBx_pass.TextChanged += new System.EventHandler(this.TxtBx_pass_TextChanged);
            this.TxtBx_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_pass_KeyPress);
            // 
            // TxtBx_username
            // 
            this.TxtBx_username.Location = new System.Drawing.Point(318, 172);
            this.TxtBx_username.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_username.Name = "TxtBx_username";
            this.TxtBx_username.Size = new System.Drawing.Size(132, 22);
            this.TxtBx_username.TabIndex = 6;
            this.TxtBx_username.TextChanged += new System.EventHandler(this.TxtBx_username_TextChanged);
            this.TxtBx_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_username_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(664, 374);
            this.Controls.Add(this.TxtBx_username);
            this.Controls.Add(this.TxtBx_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Blog);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Blog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBx_pass;
        private System.Windows.Forms.TextBox TxtBx_username;
    }
}