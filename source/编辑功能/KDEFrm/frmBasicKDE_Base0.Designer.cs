namespace GIS应用系统.KDE核密度计算.KDEFrm
{
    partial class frmBasicKDE_Base0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBasicKDE_Base0));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1_path_set = new System.Windows.Forms.Button();
            this.textBox1_output_path = new System.Windows.Forms.TextBox();
            this.label6_output_path = new System.Windows.Forms.Label();
            this.comboBox4_kernel_function = new System.Windows.Forms.ComboBox();
            this.label5_kernel_function = new System.Windows.Forms.Label();
            this.label4_raster_resolution = new System.Windows.Forms.Label();
            this.comboBox2_distance_unit = new System.Windows.Forms.ComboBox();
            this.numericUpDown1_search_distance = new System.Windows.Forms.NumericUpDown();
            this.label3_unit = new System.Windows.Forms.Label();
            this.label2_search_distance = new System.Windows.Forms.Label();
            this.comboBox1_selected_layer = new System.Windows.Forms.ComboBox();
            this.label1_selected_point_layer = new System.Windows.Forms.Label();
            this.numericUpDown1_raster_resolution = new System.Windows.Forms.NumericUpDown();
            this.label7_raster_sort = new System.Windows.Forms.Label();
            this.comboBox4_raster_sort = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_search_distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_raster_resolution)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GIS应用系统.Properties.Resources.WhatsNew16;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox4_raster_sort);
            this.panel1.Controls.Add(this.label7_raster_sort);
            this.panel1.Controls.Add(this.numericUpDown1_raster_resolution);
            this.panel1.Controls.Add(this.button1_path_set);
            this.panel1.Controls.Add(this.textBox1_output_path);
            this.panel1.Controls.Add(this.label6_output_path);
            this.panel1.Controls.Add(this.comboBox4_kernel_function);
            this.panel1.Controls.Add(this.label5_kernel_function);
            this.panel1.Controls.Add(this.label4_raster_resolution);
            this.panel1.Controls.Add(this.comboBox2_distance_unit);
            this.panel1.Controls.Add(this.numericUpDown1_search_distance);
            this.panel1.Controls.Add(this.label3_unit);
            this.panel1.Controls.Add(this.label2_search_distance);
            this.panel1.Controls.Add(this.comboBox1_selected_layer);
            this.panel1.Controls.Add(this.label1_selected_point_layer);
            this.panel1.Name = "panel1";
            // 
            // button1_path_set
            // 
            resources.ApplyResources(this.button1_path_set, "button1_path_set");
            this.button1_path_set.Name = "button1_path_set";
            this.button1_path_set.UseVisualStyleBackColor = true;
            this.button1_path_set.Click += new System.EventHandler(this.button1_path_set_Click);
            // 
            // textBox1_output_path
            // 
            resources.ApplyResources(this.textBox1_output_path, "textBox1_output_path");
            this.textBox1_output_path.Name = "textBox1_output_path";
            this.textBox1_output_path.TextChanged += new System.EventHandler(this.textBox1_output_path_TextChanged);
            // 
            // label6_output_path
            // 
            resources.ApplyResources(this.label6_output_path, "label6_output_path");
            this.label6_output_path.Name = "label6_output_path";
            // 
            // comboBox4_kernel_function
            // 
            this.comboBox4_kernel_function.FormattingEnabled = true;
            this.comboBox4_kernel_function.Items.AddRange(new object[] {
            resources.GetString("comboBox4_kernel_function.Items")});
            resources.ApplyResources(this.comboBox4_kernel_function, "comboBox4_kernel_function");
            this.comboBox4_kernel_function.Name = "comboBox4_kernel_function";
            this.comboBox4_kernel_function.SelectedIndexChanged += new System.EventHandler(this.comboBox4_kernel_function_SelectedIndexChanged);
            // 
            // label5_kernel_function
            // 
            resources.ApplyResources(this.label5_kernel_function, "label5_kernel_function");
            this.label5_kernel_function.Name = "label5_kernel_function";
            // 
            // label4_raster_resolution
            // 
            resources.ApplyResources(this.label4_raster_resolution, "label4_raster_resolution");
            this.label4_raster_resolution.Name = "label4_raster_resolution";
            // 
            // comboBox2_distance_unit
            // 
            this.comboBox2_distance_unit.FormattingEnabled = true;
            this.comboBox2_distance_unit.Items.AddRange(new object[] {
            resources.GetString("comboBox2_distance_unit.Items"),
            resources.GetString("comboBox2_distance_unit.Items1")});
            resources.ApplyResources(this.comboBox2_distance_unit, "comboBox2_distance_unit");
            this.comboBox2_distance_unit.Name = "comboBox2_distance_unit";
            this.comboBox2_distance_unit.SelectedIndexChanged += new System.EventHandler(this.comboBox2_distance_unit_SelectedIndexChanged);
            // 
            // numericUpDown1_search_distance
            // 
            resources.ApplyResources(this.numericUpDown1_search_distance, "numericUpDown1_search_distance");
            this.numericUpDown1_search_distance.Name = "numericUpDown1_search_distance";
            this.numericUpDown1_search_distance.ValueChanged += new System.EventHandler(this.numericUpDown1_search_distance_ValueChanged);
            // 
            // label3_unit
            // 
            resources.ApplyResources(this.label3_unit, "label3_unit");
            this.label3_unit.Name = "label3_unit";
            // 
            // label2_search_distance
            // 
            resources.ApplyResources(this.label2_search_distance, "label2_search_distance");
            this.label2_search_distance.Name = "label2_search_distance";
            // 
            // comboBox1_selected_layer
            // 
            this.comboBox1_selected_layer.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1_selected_layer, "comboBox1_selected_layer");
            this.comboBox1_selected_layer.Name = "comboBox1_selected_layer";
            this.comboBox1_selected_layer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_selected_layer_SelectedIndexChanged);
            // 
            // label1_selected_point_layer
            // 
            resources.ApplyResources(this.label1_selected_point_layer, "label1_selected_point_layer");
            this.label1_selected_point_layer.Name = "label1_selected_point_layer";
            // 
            // numericUpDown1_raster_resolution
            // 
            resources.ApplyResources(this.numericUpDown1_raster_resolution, "numericUpDown1_raster_resolution");
            this.numericUpDown1_raster_resolution.Name = "numericUpDown1_raster_resolution";
            this.numericUpDown1_raster_resolution.ValueChanged += new System.EventHandler(this.numericUpDown1_raster_resolution_ValueChanged);
            // 
            // label7_raster_sort
            // 
            resources.ApplyResources(this.label7_raster_sort, "label7_raster_sort");
            this.label7_raster_sort.Name = "label7_raster_sort";
            // 
            // comboBox4_raster_sort
            // 
            this.comboBox4_raster_sort.FormattingEnabled = true;
            this.comboBox4_raster_sort.Items.AddRange(new object[] {
            resources.GetString("comboBox4_raster_sort.Items"),
            resources.GetString("comboBox4_raster_sort.Items1"),
            resources.GetString("comboBox4_raster_sort.Items2")});
            resources.ApplyResources(this.comboBox4_raster_sort, "comboBox4_raster_sort");
            this.comboBox4_raster_sort.Name = "comboBox4_raster_sort";
            this.comboBox4_raster_sort.SelectedIndexChanged += new System.EventHandler(this.comboBox4_raster_sort_SelectedIndexChanged);
            // 
            // frmBasicKDE_Base0
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmBasicKDE_Base0";
            this.Load += new System.EventHandler(this.frmBasicKDE_Base0_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_search_distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_raster_resolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1_selected_point_layer;
        private System.Windows.Forms.ComboBox comboBox1_selected_layer;
        private System.Windows.Forms.Label label2_search_distance;
        private System.Windows.Forms.Label label3_unit;
        private System.Windows.Forms.ComboBox comboBox2_distance_unit;
        private System.Windows.Forms.NumericUpDown numericUpDown1_search_distance;
        private System.Windows.Forms.Label label4_raster_resolution;
        private System.Windows.Forms.Label label5_kernel_function;
        private System.Windows.Forms.ComboBox comboBox4_kernel_function;
        private System.Windows.Forms.Label label6_output_path;
        private System.Windows.Forms.TextBox textBox1_output_path;
        private System.Windows.Forms.Button button1_path_set;
        private System.Windows.Forms.NumericUpDown numericUpDown1_raster_resolution;
        private System.Windows.Forms.Label label7_raster_sort;
        private System.Windows.Forms.ComboBox comboBox4_raster_sort;

    }
}