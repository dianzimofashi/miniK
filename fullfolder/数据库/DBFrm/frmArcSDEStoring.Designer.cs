namespace GIS应用系统.数据库.DBFrm
{
    partial class frmArcSDEStoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArcSDEStoring));
            this.label_layer = new System.Windows.Forms.Label();
            this.button_store = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_layer
            // 
            this.label_layer.AutoSize = true;
            this.label_layer.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_layer.ForeColor = System.Drawing.Color.Black;
            this.label_layer.Location = new System.Drawing.Point(37, 26);
            this.label_layer.Name = "label_layer";
            this.label_layer.Size = new System.Drawing.Size(316, 26);
            this.label_layer.TabIndex = 0;
            this.label_layer.Text = "选择已加载的要素、要素类、要素集";
            // 
            // button_store
            // 
            this.button_store.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_store.Location = new System.Drawing.Point(745, 579);
            this.button_store.Name = "button_store";
            this.button_store.Size = new System.Drawing.Size(187, 38);
            this.button_store.TabIndex = 1;
            this.button_store.Text = "确认导入ArcSDE";
            this.button_store.UseVisualStyleBackColor = true;
            this.button_store.Click += new System.EventHandler(this.button_store_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_cancel.Location = new System.Drawing.Point(1003, 579);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(141, 36);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1102, 475);
            this.textBox1.TabIndex = 3;
            // 
            // frmArcSDEStoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 668);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_store);
            this.Controls.Add(this.label_layer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArcSDEStoring";
            this.Text = "ArcSDE存储";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_layer;
        private System.Windows.Forms.Button button_store;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox1;
    }
}