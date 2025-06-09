namespace GIS应用系统.数据库
{
    partial class frmArcSDEConn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArcSDEConn));
            this.label1_DB_ArcSDE = new System.Windows.Forms.Label();
            this.label2_DB_instance = new System.Windows.Forms.Label();
            this.textBox1_instance = new System.Windows.Forms.TextBox();
            this.label3_DB = new System.Windows.Forms.Label();
            this.label4_username = new System.Windows.Forms.Label();
            this.label6_password = new System.Windows.Forms.Label();
            this.label7_version = new System.Windows.Forms.Label();
            this.textBox2_SDE = new System.Windows.Forms.TextBox();
            this.textBox3_username = new System.Windows.Forms.TextBox();
            this.textBox6_version = new System.Windows.Forms.TextBox();
            this.textBox5_password = new System.Windows.Forms.TextBox();
            this.button1_ArcSDEConn = new System.Windows.Forms.Button();
            this.button2_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_DB_ArcSDE
            // 
            this.label1_DB_ArcSDE.AutoSize = true;
            this.label1_DB_ArcSDE.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_DB_ArcSDE.Location = new System.Drawing.Point(47, 34);
            this.label1_DB_ArcSDE.Name = "label1_DB_ArcSDE";
            this.label1_DB_ArcSDE.Size = new System.Drawing.Size(176, 26);
            this.label1_DB_ArcSDE.TabIndex = 0;
            this.label1_DB_ArcSDE.Text = "ArcSDE数据库连接";
            // 
            // label2_DB_instance
            // 
            this.label2_DB_instance.AutoSize = true;
            this.label2_DB_instance.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2_DB_instance.Location = new System.Drawing.Point(47, 127);
            this.label2_DB_instance.Name = "label2_DB_instance";
            this.label2_DB_instance.Size = new System.Drawing.Size(107, 26);
            this.label2_DB_instance.TabIndex = 1;
            this.label2_DB_instance.Text = "数据库实例";
            this.label2_DB_instance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1_instance
            // 
            this.textBox1_instance.Location = new System.Drawing.Point(245, 129);
            this.textBox1_instance.Name = "textBox1_instance";
            this.textBox1_instance.Size = new System.Drawing.Size(377, 25);
            this.textBox1_instance.TabIndex = 2;
            this.textBox1_instance.Text = "sde:sqlserver:MSSQLSERVER";
            // 
            // label3_DB
            // 
            this.label3_DB.AutoSize = true;
            this.label3_DB.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3_DB.Location = new System.Drawing.Point(69, 218);
            this.label3_DB.Name = "label3_DB";
            this.label3_DB.Size = new System.Drawing.Size(69, 26);
            this.label3_DB.TabIndex = 3;
            this.label3_DB.Text = "数据库";
            this.label3_DB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4_username
            // 
            this.label4_username.AutoSize = true;
            this.label4_username.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4_username.Location = new System.Drawing.Point(74, 304);
            this.label4_username.Name = "label4_username";
            this.label4_username.Size = new System.Drawing.Size(69, 26);
            this.label4_username.TabIndex = 4;
            this.label4_username.Text = "用户名";
            this.label4_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6_password
            // 
            this.label6_password.AutoSize = true;
            this.label6_password.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6_password.Location = new System.Drawing.Point(88, 381);
            this.label6_password.Name = "label6_password";
            this.label6_password.Size = new System.Drawing.Size(50, 26);
            this.label6_password.TabIndex = 5;
            this.label6_password.Text = "密码";
            this.label6_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7_version
            // 
            this.label7_version.AutoSize = true;
            this.label7_version.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7_version.Location = new System.Drawing.Point(88, 461);
            this.label7_version.Name = "label7_version";
            this.label7_version.Size = new System.Drawing.Size(50, 26);
            this.label7_version.TabIndex = 6;
            this.label7_version.Text = "版本";
            this.label7_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2_SDE
            // 
            this.textBox2_SDE.Location = new System.Drawing.Point(245, 222);
            this.textBox2_SDE.Name = "textBox2_SDE";
            this.textBox2_SDE.Size = new System.Drawing.Size(377, 25);
            this.textBox2_SDE.TabIndex = 7;
            this.textBox2_SDE.Text = "sde";
            // 
            // textBox3_username
            // 
            this.textBox3_username.Location = new System.Drawing.Point(245, 309);
            this.textBox3_username.Name = "textBox3_username";
            this.textBox3_username.Size = new System.Drawing.Size(377, 25);
            this.textBox3_username.TabIndex = 8;
            this.textBox3_username.Text = "sa";
            // 
            // textBox6_version
            // 
            this.textBox6_version.Location = new System.Drawing.Point(245, 452);
            this.textBox6_version.Name = "textBox6_version";
            this.textBox6_version.Size = new System.Drawing.Size(377, 25);
            this.textBox6_version.TabIndex = 9;
            this.textBox6_version.Text = "SDE_default";
            // 
            // textBox5_password
            // 
            this.textBox5_password.Location = new System.Drawing.Point(245, 386);
            this.textBox5_password.Name = "textBox5_password";
            this.textBox5_password.Size = new System.Drawing.Size(377, 25);
            this.textBox5_password.TabIndex = 10;
            this.textBox5_password.Text = "123";
            // 
            // button1_ArcSDEConn
            // 
            this.button1_ArcSDEConn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1_ArcSDEConn.Location = new System.Drawing.Point(245, 564);
            this.button1_ArcSDEConn.Name = "button1_ArcSDEConn";
            this.button1_ArcSDEConn.Size = new System.Drawing.Size(121, 40);
            this.button1_ArcSDEConn.TabIndex = 11;
            this.button1_ArcSDEConn.Text = "连接";
            this.button1_ArcSDEConn.UseVisualStyleBackColor = true;
            this.button1_ArcSDEConn.Click += new System.EventHandler(this.button1_ArcSDEConn_Click);
            // 
            // button2_cancel
            // 
            this.button2_cancel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2_cancel.Location = new System.Drawing.Point(501, 564);
            this.button2_cancel.Name = "button2_cancel";
            this.button2_cancel.Size = new System.Drawing.Size(121, 39);
            this.button2_cancel.TabIndex = 12;
            this.button2_cancel.Text = "取消";
            this.button2_cancel.UseVisualStyleBackColor = true;
            this.button2_cancel.Click += new System.EventHandler(this.button2_cancel_Click);
            // 
            // frmArcSDEConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 675);
            this.Controls.Add(this.button2_cancel);
            this.Controls.Add(this.button1_ArcSDEConn);
            this.Controls.Add(this.textBox5_password);
            this.Controls.Add(this.textBox6_version);
            this.Controls.Add(this.textBox3_username);
            this.Controls.Add(this.textBox2_SDE);
            this.Controls.Add(this.label7_version);
            this.Controls.Add(this.label6_password);
            this.Controls.Add(this.label4_username);
            this.Controls.Add(this.label3_DB);
            this.Controls.Add(this.textBox1_instance);
            this.Controls.Add(this.label2_DB_instance);
            this.Controls.Add(this.label1_DB_ArcSDE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArcSDEConn";
            this.Text = "ArcSDE数据库";
            this.Load += new System.EventHandler(this.frmArcSDEConn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_DB_ArcSDE;
        private System.Windows.Forms.Label label2_DB_instance;
        private System.Windows.Forms.TextBox textBox1_instance;
        private System.Windows.Forms.Label label3_DB;
        private System.Windows.Forms.Label label4_username;
        private System.Windows.Forms.Label label6_password;
        private System.Windows.Forms.Label label7_version;
        private System.Windows.Forms.TextBox textBox2_SDE;
        private System.Windows.Forms.TextBox textBox3_username;
        private System.Windows.Forms.TextBox textBox6_version;
        private System.Windows.Forms.TextBox textBox5_password;
        private System.Windows.Forms.Button button1_ArcSDEConn;
        private System.Windows.Forms.Button button2_cancel;
    }
}