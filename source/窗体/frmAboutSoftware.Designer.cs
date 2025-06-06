namespace GIS应用系统
{
    partial class frmAboutSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutSoftware));
            this.lbl2_aboutMiniK = new System.Windows.Forms.Label();
            this.lbl1_aboutminiK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl2_aboutMiniK
            // 
            this.lbl2_aboutMiniK.AutoSize = true;
            this.lbl2_aboutMiniK.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2_aboutMiniK.Location = new System.Drawing.Point(153, 171);
            this.lbl2_aboutMiniK.Name = "lbl2_aboutMiniK";
            this.lbl2_aboutMiniK.Size = new System.Drawing.Size(621, 69);
            this.lbl2_aboutMiniK.TabIndex = 2;
            this.lbl2_aboutMiniK.Text = "miniK是地理信息专业ArcGIS Engine C#二次开发课程实践实习\r\n\r\nGitHub URL: https://github.com/dianzimo" +
    "fashi/miniK\r\n";
            // 
            // lbl1_aboutminiK
            // 
            this.lbl1_aboutminiK.AutoSize = true;
            this.lbl1_aboutminiK.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1_aboutminiK.Location = new System.Drawing.Point(34, 43);
            this.lbl1_aboutminiK.Name = "lbl1_aboutminiK";
            this.lbl1_aboutminiK.Size = new System.Drawing.Size(137, 27);
            this.lbl1_aboutminiK.TabIndex = 3;
            this.lbl1_aboutminiK.Text = "关于miniK";
            // 
            // frmAboutSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(924, 454);
            this.Controls.Add(this.lbl1_aboutminiK);
            this.Controls.Add(this.lbl2_aboutMiniK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAboutSoftware";
            this.Text = "关于软件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2_aboutMiniK;
        private System.Windows.Forms.Label lbl1_aboutminiK;

    }
}