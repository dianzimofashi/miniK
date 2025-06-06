namespace GIS应用系统.窗体
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lbl3_hello_title = new System.Windows.Forms.Label();
            this.lbl2_password = new System.Windows.Forms.Label();
            this.lbl1_user = new System.Windows.Forms.Label();
            this.btn2_quit = new System.Windows.Forms.Button();
            this.btn1_login = new System.Windows.Forms.Button();
            this.txb2_password = new System.Windows.Forms.TextBox();
            this.txb1_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl3_hello_title
            // 
            this.lbl3_hello_title.AutoSize = true;
            this.lbl3_hello_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl3_hello_title.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl3_hello_title.Location = new System.Drawing.Point(502, 45);
            this.lbl3_hello_title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl3_hello_title.Name = "lbl3_hello_title";
            this.lbl3_hello_title.Size = new System.Drawing.Size(500, 44);
            this.lbl3_hello_title.TabIndex = 13;
            this.lbl3_hello_title.Text = "你好，有什么能够帮助你的!";
            this.lbl3_hello_title.Click += new System.EventHandler(this.lbl3_hello_title_Click);
            // 
            // lbl2_password
            // 
            this.lbl2_password.AutoSize = true;
            this.lbl2_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl2_password.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2_password.Location = new System.Drawing.Point(211, 330);
            this.lbl2_password.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl2_password.Name = "lbl2_password";
            this.lbl2_password.Size = new System.Drawing.Size(62, 27);
            this.lbl2_password.TabIndex = 12;
            this.lbl2_password.Text = "密码";
            this.lbl2_password.Click += new System.EventHandler(this.lbl2_password_Click);
            // 
            // lbl1_user
            // 
            this.lbl1_user.AutoSize = true;
            this.lbl1_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl1_user.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1_user.Location = new System.Drawing.Point(179, 150);
            this.lbl1_user.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl1_user.Name = "lbl1_user";
            this.lbl1_user.Size = new System.Drawing.Size(155, 27);
            this.lbl1_user.TabIndex = 11;
            this.lbl1_user.Text = "miniK_user";
            this.lbl1_user.Click += new System.EventHandler(this.lbl1_user_Click);
            // 
            // btn2_quit
            // 
            this.btn2_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn2_quit.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2_quit.Location = new System.Drawing.Point(1238, 330);
            this.btn2_quit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn2_quit.Name = "btn2_quit";
            this.btn2_quit.Size = new System.Drawing.Size(144, 31);
            this.btn2_quit.TabIndex = 10;
            this.btn2_quit.Text = "退出";
            this.btn2_quit.UseVisualStyleBackColor = false;
            this.btn2_quit.Click += new System.EventHandler(this.btn2_quit_Click);
            // 
            // btn1_login
            // 
            this.btn1_login.BackColor = System.Drawing.Color.Transparent;
            this.btn1_login.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1_login.Location = new System.Drawing.Point(1238, 150);
            this.btn1_login.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn1_login.Name = "btn1_login";
            this.btn1_login.Size = new System.Drawing.Size(144, 31);
            this.btn1_login.TabIndex = 9;
            this.btn1_login.Text = "登陆";
            this.btn1_login.UseVisualStyleBackColor = false;
            this.btn1_login.Click += new System.EventHandler(this.btn1_login_Click);
            // 
            // txb2_password
            // 
            this.txb2_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb2_password.Location = new System.Drawing.Point(378, 330);
            this.txb2_password.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb2_password.Name = "txb2_password";
            this.txb2_password.Size = new System.Drawing.Size(741, 31);
            this.txb2_password.TabIndex = 8;
            this.txb2_password.UseSystemPasswordChar = true;
            this.txb2_password.TextChanged += new System.EventHandler(this.txb2_password_TextChanged);
            // 
            // txb1_username
            // 
            this.txb1_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb1_username.Location = new System.Drawing.Point(378, 150);
            this.txb1_username.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb1_username.Name = "txb1_username";
            this.txb1_username.Size = new System.Drawing.Size(741, 31);
            this.txb1_username.TabIndex = 7;
            this.txb1_username.TextChanged += new System.EventHandler(this.txb1_username_TextChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GIS应用系统.Properties.Resources.南通大学_logo_512px;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1479, 883);
            this.Controls.Add(this.lbl3_hello_title);
            this.Controls.Add(this.lbl2_password);
            this.Controls.Add(this.lbl1_user);
            this.Controls.Add(this.btn2_quit);
            this.Controls.Add(this.btn1_login);
            this.Controls.Add(this.txb2_password);
            this.Controls.Add(this.txb1_username);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆miniK门户";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl3_hello_title;
        private System.Windows.Forms.Label lbl2_password;
        private System.Windows.Forms.Label lbl1_user;
        private System.Windows.Forms.Button btn2_quit;
        private System.Windows.Forms.Button btn1_login;
        private System.Windows.Forms.TextBox txb2_password;
        private System.Windows.Forms.TextBox txb1_username;
    }
}