namespace GIS应用系统.窗体
{
    partial class frmAboutCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutCreator));
            this.lbl1_aboutCreator = new System.Windows.Forms.Label();
            this.lbl2_aboutMiniK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1_aboutCreator
            // 
            this.lbl1_aboutCreator.AutoSize = true;
            this.lbl1_aboutCreator.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1_aboutCreator.Location = new System.Drawing.Point(47, 83);
            this.lbl1_aboutCreator.Name = "lbl1_aboutCreator";
            this.lbl1_aboutCreator.Size = new System.Drawing.Size(137, 27);
            this.lbl1_aboutCreator.TabIndex = 4;
            this.lbl1_aboutCreator.Text = "关于创作者";
            // 
            // lbl2_aboutMiniK
            // 
            this.lbl2_aboutMiniK.AutoSize = true;
            this.lbl2_aboutMiniK.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2_aboutMiniK.Location = new System.Drawing.Point(113, 164);
            this.lbl2_aboutMiniK.Name = "lbl2_aboutMiniK";
            this.lbl2_aboutMiniK.Size = new System.Drawing.Size(897, 299);
            this.lbl2_aboutMiniK.TabIndex = 5;
            this.lbl2_aboutMiniK.Text = resources.GetString("lbl2_aboutMiniK.Text");
            // 
            // frmAboutCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 689);
            this.Controls.Add(this.lbl2_aboutMiniK);
            this.Controls.Add(this.lbl1_aboutCreator);
            this.Name = "frmAboutCreator";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1_aboutCreator;
        private System.Windows.Forms.Label lbl2_aboutMiniK;
    }
}