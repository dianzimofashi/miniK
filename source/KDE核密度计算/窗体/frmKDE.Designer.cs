namespace GIS应用系统.KDE核密度计算.KDEFrm
{
    partial class frmKDE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKDE));
            this.label_select_layer = new System.Windows.Forms.Label();
            this.label_raster_sort = new System.Windows.Forms.Label();
            this.label_kernel_func = new System.Windows.Forms.Label();
            this.label_raster_resolution = new System.Windows.Forms.Label();
            this.label_save_path = new System.Windows.Forms.Label();
            this.label_search_unit = new System.Windows.Forms.Label();
            this.label_radius_unit = new System.Windows.Forms.Label();
            this.comboBox_select_layer = new System.Windows.Forms.ComboBox();
            this.comboBox_fields = new System.Windows.Forms.ComboBox();
            this.textBox_raster_resolution = new System.Windows.Forms.TextBox();
            this.comboBox_kernel_fuc = new System.Windows.Forms.ComboBox();
            this.textBox_search_radius = new System.Windows.Forms.TextBox();
            this.textBox_save_path = new System.Windows.Forms.TextBox();
            this.comboBox_radius_unit = new System.Windows.Forms.ComboBox();
            this.label_process = new System.Windows.Forms.Label();
            this.progressBar_process = new System.Windows.Forms.ProgressBar();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_para_collect = new System.Windows.Forms.Label();
            this.textBox_para = new System.Windows.Forms.TextBox();
            this.label_tips = new System.Windows.Forms.Label();
            this.textBox_tips = new System.Windows.Forms.TextBox();
            this.button_broswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_select_layer
            // 
            this.label_select_layer.AutoSize = true;
            this.label_select_layer.Location = new System.Drawing.Point(57, 43);
            this.label_select_layer.Name = "label_select_layer";
            this.label_select_layer.Size = new System.Drawing.Size(67, 15);
            this.label_select_layer.TabIndex = 0;
            this.label_select_layer.Text = "选择图层";
            // 
            // label_raster_sort
            // 
            this.label_raster_sort.AutoSize = true;
            this.label_raster_sort.Location = new System.Drawing.Point(271, 43);
            this.label_raster_sort.Name = "label_raster_sort";
            this.label_raster_sort.Size = new System.Drawing.Size(67, 15);
            this.label_raster_sort.TabIndex = 1;
            this.label_raster_sort.Text = "选择字段";
            // 
            // label_kernel_func
            // 
            this.label_kernel_func.AutoSize = true;
            this.label_kernel_func.Location = new System.Drawing.Point(775, 43);
            this.label_kernel_func.Name = "label_kernel_func";
            this.label_kernel_func.Size = new System.Drawing.Size(82, 15);
            this.label_kernel_func.TabIndex = 2;
            this.label_kernel_func.Text = "核函数类型";
            // 
            // label_raster_resolution
            // 
            this.label_raster_resolution.AutoSize = true;
            this.label_raster_resolution.Location = new System.Drawing.Point(513, 43);
            this.label_raster_resolution.Name = "label_raster_resolution";
            this.label_raster_resolution.Size = new System.Drawing.Size(82, 15);
            this.label_raster_resolution.TabIndex = 3;
            this.label_raster_resolution.Text = "栅格分辨率";
            // 
            // label_save_path
            // 
            this.label_save_path.AutoSize = true;
            this.label_save_path.Location = new System.Drawing.Point(330, 206);
            this.label_save_path.Name = "label_save_path";
            this.label_save_path.Size = new System.Drawing.Size(67, 15);
            this.label_save_path.TabIndex = 4;
            this.label_save_path.Text = "保存路径";
            // 
            // label_search_unit
            // 
            this.label_search_unit.AutoSize = true;
            this.label_search_unit.Location = new System.Drawing.Point(1008, 43);
            this.label_search_unit.Name = "label_search_unit";
            this.label_search_unit.Size = new System.Drawing.Size(67, 15);
            this.label_search_unit.TabIndex = 5;
            this.label_search_unit.Text = "搜索半径";
            // 
            // label_radius_unit
            // 
            this.label_radius_unit.AutoSize = true;
            this.label_radius_unit.Location = new System.Drawing.Point(57, 206);
            this.label_radius_unit.Name = "label_radius_unit";
            this.label_radius_unit.Size = new System.Drawing.Size(67, 15);
            this.label_radius_unit.TabIndex = 6;
            this.label_radius_unit.Text = "半径单位";
            // 
            // comboBox_select_layer
            // 
            this.comboBox_select_layer.FormattingEnabled = true;
            this.comboBox_select_layer.Location = new System.Drawing.Point(12, 102);
            this.comboBox_select_layer.Name = "comboBox_select_layer";
            this.comboBox_select_layer.Size = new System.Drawing.Size(170, 23);
            this.comboBox_select_layer.TabIndex = 7;
            this.comboBox_select_layer.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_layer_SelectedIndexChanged);
            // 
            // comboBox_fields
            // 
            this.comboBox_fields.FormattingEnabled = true;
            this.comboBox_fields.Location = new System.Drawing.Point(223, 102);
            this.comboBox_fields.Name = "comboBox_fields";
            this.comboBox_fields.Size = new System.Drawing.Size(174, 23);
            this.comboBox_fields.TabIndex = 8;
            this.comboBox_fields.SelectedIndexChanged += new System.EventHandler(this.comboBox_fields_SelectedIndexChanged);
            // 
            // textBox_raster_resolution
            // 
            this.textBox_raster_resolution.Location = new System.Drawing.Point(471, 102);
            this.textBox_raster_resolution.Name = "textBox_raster_resolution";
            this.textBox_raster_resolution.Size = new System.Drawing.Size(173, 25);
            this.textBox_raster_resolution.TabIndex = 9;
            this.textBox_raster_resolution.Text = "50";
            this.textBox_raster_resolution.TextChanged += new System.EventHandler(this.textBox_raster_resolution_TextChanged);
            // 
            // comboBox_kernel_fuc
            // 
            this.comboBox_kernel_fuc.FormattingEnabled = true;
            this.comboBox_kernel_fuc.Items.AddRange(new object[] {
            "默认ArcGIS内置核函数"});
            this.comboBox_kernel_fuc.Location = new System.Drawing.Point(729, 102);
            this.comboBox_kernel_fuc.Name = "comboBox_kernel_fuc";
            this.comboBox_kernel_fuc.Size = new System.Drawing.Size(173, 23);
            this.comboBox_kernel_fuc.TabIndex = 10;
            // 
            // textBox_search_radius
            // 
            this.textBox_search_radius.Location = new System.Drawing.Point(957, 102);
            this.textBox_search_radius.Name = "textBox_search_radius";
            this.textBox_search_radius.Size = new System.Drawing.Size(176, 25);
            this.textBox_search_radius.TabIndex = 11;
            this.textBox_search_radius.Text = "600";
            this.textBox_search_radius.TextChanged += new System.EventHandler(this.textBox_search_radius_TextChanged);
            // 
            // textBox_save_path
            // 
            this.textBox_save_path.Location = new System.Drawing.Point(223, 275);
            this.textBox_save_path.Name = "textBox_save_path";
            this.textBox_save_path.Size = new System.Drawing.Size(174, 25);
            this.textBox_save_path.TabIndex = 12;
            // 
            // comboBox_radius_unit
            // 
            this.comboBox_radius_unit.FormattingEnabled = true;
            this.comboBox_radius_unit.Items.AddRange(new object[] {
            "Meter"});
            this.comboBox_radius_unit.Location = new System.Drawing.Point(13, 276);
            this.comboBox_radius_unit.Name = "comboBox_radius_unit";
            this.comboBox_radius_unit.Size = new System.Drawing.Size(169, 23);
            this.comboBox_radius_unit.TabIndex = 13;
            // 
            // label_process
            // 
            this.label_process.AutoSize = true;
            this.label_process.Location = new System.Drawing.Point(821, 206);
            this.label_process.Name = "label_process";
            this.label_process.Size = new System.Drawing.Size(67, 15);
            this.label_process.TabIndex = 14;
            this.label_process.Text = "执行处理";
            // 
            // progressBar_process
            // 
            this.progressBar_process.Location = new System.Drawing.Point(604, 276);
            this.progressBar_process.Name = "progressBar_process";
            this.progressBar_process.Size = new System.Drawing.Size(529, 23);
            this.progressBar_process.TabIndex = 15;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(926, 444);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 34);
            this.button_OK.TabIndex = 16;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(1058, 444);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 34);
            this.button_cancel.TabIndex = 17;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_para_collect
            // 
            this.label_para_collect.AutoSize = true;
            this.label_para_collect.Location = new System.Drawing.Point(162, 363);
            this.label_para_collect.Name = "label_para_collect";
            this.label_para_collect.Size = new System.Drawing.Size(67, 15);
            this.label_para_collect.TabIndex = 18;
            this.label_para_collect.Text = "参数汇总";
            // 
            // textBox_para
            // 
            this.textBox_para.Location = new System.Drawing.Point(12, 390);
            this.textBox_para.Multiline = true;
            this.textBox_para.Name = "textBox_para";
            this.textBox_para.Size = new System.Drawing.Size(385, 156);
            this.textBox_para.TabIndex = 19;
            // 
            // label_tips
            // 
            this.label_tips.AutoSize = true;
            this.label_tips.Location = new System.Drawing.Point(625, 363);
            this.label_tips.Name = "label_tips";
            this.label_tips.Size = new System.Drawing.Size(67, 15);
            this.label_tips.TabIndex = 20;
            this.label_tips.Text = "提示说明";
            // 
            // textBox_tips
            // 
            this.textBox_tips.Location = new System.Drawing.Point(471, 390);
            this.textBox_tips.Multiline = true;
            this.textBox_tips.Name = "textBox_tips";
            this.textBox_tips.Size = new System.Drawing.Size(386, 156);
            this.textBox_tips.TabIndex = 21;
            // 
            // button_broswer
            // 
            this.button_broswer.Location = new System.Drawing.Point(422, 276);
            this.button_broswer.Name = "button_broswer";
            this.button_broswer.Size = new System.Drawing.Size(75, 25);
            this.button_broswer.TabIndex = 22;
            this.button_broswer.Text = "浏览";
            this.button_broswer.UseVisualStyleBackColor = true;
            this.button_broswer.Click += new System.EventHandler(this.button_broswer_Click);
            // 
            // frmKDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1145, 641);
            this.Controls.Add(this.button_broswer);
            this.Controls.Add(this.textBox_tips);
            this.Controls.Add(this.label_tips);
            this.Controls.Add(this.textBox_para);
            this.Controls.Add(this.label_para_collect);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.progressBar_process);
            this.Controls.Add(this.label_process);
            this.Controls.Add(this.comboBox_radius_unit);
            this.Controls.Add(this.textBox_save_path);
            this.Controls.Add(this.textBox_search_radius);
            this.Controls.Add(this.comboBox_kernel_fuc);
            this.Controls.Add(this.textBox_raster_resolution);
            this.Controls.Add(this.comboBox_fields);
            this.Controls.Add(this.comboBox_select_layer);
            this.Controls.Add(this.label_radius_unit);
            this.Controls.Add(this.label_search_unit);
            this.Controls.Add(this.label_save_path);
            this.Controls.Add(this.label_raster_resolution);
            this.Controls.Add(this.label_kernel_func);
            this.Controls.Add(this.label_raster_sort);
            this.Controls.Add(this.label_select_layer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKDE";
            this.Text = "精简核密度";
            this.Load += new System.EventHandler(this.frmKDE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_select_layer;
        private System.Windows.Forms.Label label_raster_sort;
        private System.Windows.Forms.Label label_kernel_func;
        private System.Windows.Forms.Label label_raster_resolution;
        private System.Windows.Forms.Label label_save_path;
        private System.Windows.Forms.Label label_search_unit;
        private System.Windows.Forms.Label label_radius_unit;
        private System.Windows.Forms.ComboBox comboBox_select_layer;
        private System.Windows.Forms.ComboBox comboBox_fields;
        private System.Windows.Forms.TextBox textBox_raster_resolution;
        private System.Windows.Forms.ComboBox comboBox_kernel_fuc;
        private System.Windows.Forms.TextBox textBox_search_radius;
        private System.Windows.Forms.TextBox textBox_save_path;
        private System.Windows.Forms.ComboBox comboBox_radius_unit;
        private System.Windows.Forms.Label label_process;
        private System.Windows.Forms.ProgressBar progressBar_process;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_para_collect;
        private System.Windows.Forms.TextBox textBox_para;
        private System.Windows.Forms.Label label_tips;
        private System.Windows.Forms.TextBox textBox_tips;
        private System.Windows.Forms.Button button_broswer;
    }
}