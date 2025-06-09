namespace GIS应用系统.KDE核密度计算.KDEFrm
{
    partial class frmParameter
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TP1_paraKDE_input = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button1_input_next_page = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1_selected_layer = new System.Windows.Forms.Label();
            this.comboBox2_selected_layer = new System.Windows.Forms.ComboBox();
            this.label1_weigh_field = new System.Windows.Forms.Label();
            this.comboBox2_weigh_field = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1_raster_resolution = new System.Windows.Forms.Label();
            this.numericUpDown2_raster_resolution = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1_radius = new System.Windows.Forms.Label();
            this.numericUpDown2_radius_unit = new System.Windows.Forms.NumericUpDown();
            this.label1_radius_unit = new System.Windows.Forms.Label();
            this.comboBox2_radius = new System.Windows.Forms.ComboBox();
            this.TP2_paraKDE_output = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1_output_path = new System.Windows.Forms.TextBox();
            this.label2_text_output_path = new System.Windows.Forms.Label();
            this.label1_output_path = new System.Windows.Forms.Label();
            this.button1_output_path = new System.Windows.Forms.Button();
            this.checkBox1_add_to_map = new System.Windows.Forms.CheckBox();
            this.label2_is_add_to_map = new System.Windows.Forms.Label();
            this.comboBox2_raster_sort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TP3_paraKDE_hyper = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2_info_collection_text = new System.Windows.Forms.Label();
            this.button1_info_collection = new System.Windows.Forms.Button();
            this.button1_recognize_final = new System.Windows.Forms.Button();
            this.label2_tips = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.LBL3_multi_thread = new System.Windows.Forms.Label();
            this.LBL4_normalize = new System.Windows.Forms.Label();
            this.checkBox2_normalize = new System.Windows.Forms.CheckBox();
            this.checkBox1_multi_thread = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.LBL1_kernel_sort = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LBL2_sampling_points = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.TP1_paraKDE_input.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_raster_resolution)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_radius_unit)).BeginInit();
            this.TP2_paraKDE_output.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.TP3_paraKDE_hyper.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TP1_paraKDE_input);
            this.tabControl1.Controls.Add(this.TP2_paraKDE_output);
            this.tabControl1.Controls.Add(this.TP3_paraKDE_hyper);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 651);
            this.tabControl1.TabIndex = 0;
            // 
            // TP1_paraKDE_input
            // 
            this.TP1_paraKDE_input.Controls.Add(this.panel4);
            this.TP1_paraKDE_input.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TP1_paraKDE_input.Location = new System.Drawing.Point(4, 35);
            this.TP1_paraKDE_input.Name = "TP1_paraKDE_input";
            this.TP1_paraKDE_input.Padding = new System.Windows.Forms.Padding(3);
            this.TP1_paraKDE_input.Size = new System.Drawing.Size(1174, 612);
            this.TP1_paraKDE_input.TabIndex = 0;
            this.TP1_paraKDE_input.Text = "输入";
            this.TP1_paraKDE_input.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1168, 606);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button1_input_next_page);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 443);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1168, 163);
            this.panel11.TabIndex = 13;
            // 
            // button1_input_next_page
            // 
            this.button1_input_next_page.Location = new System.Drawing.Point(1007, 103);
            this.button1_input_next_page.Name = "button1_input_next_page";
            this.button1_input_next_page.Size = new System.Drawing.Size(147, 44);
            this.button1_input_next_page.TabIndex = 0;
            this.button1_input_next_page.Text = "下一页";
            this.button1_input_next_page.UseVisualStyleBackColor = true;
            this.button1_input_next_page.Click += new System.EventHandler(this.button1_input_next_page_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1_selected_layer);
            this.panel1.Controls.Add(this.comboBox2_selected_layer);
            this.panel1.Controls.Add(this.label1_weigh_field);
            this.panel1.Controls.Add(this.comboBox2_weigh_field);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 172);
            this.panel1.TabIndex = 10;
            // 
            // label1_selected_layer
            // 
            this.label1_selected_layer.AutoSize = true;
            this.label1_selected_layer.Location = new System.Drawing.Point(266, 42);
            this.label1_selected_layer.Name = "label1_selected_layer";
            this.label1_selected_layer.Size = new System.Drawing.Size(112, 27);
            this.label1_selected_layer.TabIndex = 0;
            this.label1_selected_layer.Text = "选择图层";
            // 
            // comboBox2_selected_layer
            // 
            this.comboBox2_selected_layer.FormattingEnabled = true;
            this.comboBox2_selected_layer.Location = new System.Drawing.Point(405, 39);
            this.comboBox2_selected_layer.Name = "comboBox2_selected_layer";
            this.comboBox2_selected_layer.Size = new System.Drawing.Size(499, 34);
            this.comboBox2_selected_layer.TabIndex = 5;
            this.comboBox2_selected_layer.SelectedIndexChanged += new System.EventHandler(this.comboBox2_selected_layer_SelectedIndexChanged);
            // 
            // label1_weigh_field
            // 
            this.label1_weigh_field.AutoSize = true;
            this.label1_weigh_field.Location = new System.Drawing.Point(266, 120);
            this.label1_weigh_field.Name = "label1_weigh_field";
            this.label1_weigh_field.Size = new System.Drawing.Size(112, 27);
            this.label1_weigh_field.TabIndex = 1;
            this.label1_weigh_field.Text = "权重字段";
            // 
            // comboBox2_weigh_field
            // 
            this.comboBox2_weigh_field.FormattingEnabled = true;
            this.comboBox2_weigh_field.Location = new System.Drawing.Point(405, 117);
            this.comboBox2_weigh_field.Name = "comboBox2_weigh_field";
            this.comboBox2_weigh_field.Size = new System.Drawing.Size(499, 34);
            this.comboBox2_weigh_field.TabIndex = 6;
            this.comboBox2_weigh_field.SelectedIndexChanged += new System.EventHandler(this.comboBox2_weigh_field_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1_raster_resolution);
            this.panel3.Controls.Add(this.numericUpDown2_raster_resolution);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1168, 106);
            this.panel3.TabIndex = 12;
            // 
            // label1_raster_resolution
            // 
            this.label1_raster_resolution.AutoSize = true;
            this.label1_raster_resolution.Location = new System.Drawing.Point(250, 42);
            this.label1_raster_resolution.Name = "label1_raster_resolution";
            this.label1_raster_resolution.Size = new System.Drawing.Size(137, 27);
            this.label1_raster_resolution.TabIndex = 4;
            this.label1_raster_resolution.Text = "栅格分辨率";
            this.label1_raster_resolution.Click += new System.EventHandler(this.label1_raster_resolution_Click);
            // 
            // numericUpDown2_raster_resolution
            // 
            this.numericUpDown2_raster_resolution.Location = new System.Drawing.Point(409, 40);
            this.numericUpDown2_raster_resolution.Name = "numericUpDown2_raster_resolution";
            this.numericUpDown2_raster_resolution.Size = new System.Drawing.Size(499, 38);
            this.numericUpDown2_raster_resolution.TabIndex = 9;
            this.numericUpDown2_raster_resolution.ValueChanged += new System.EventHandler(this.numericUpDown2_raster_resolution_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1_radius);
            this.panel2.Controls.Add(this.numericUpDown2_radius_unit);
            this.panel2.Controls.Add(this.label1_radius_unit);
            this.panel2.Controls.Add(this.comboBox2_radius);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 165);
            this.panel2.TabIndex = 11;
            // 
            // label1_radius
            // 
            this.label1_radius.AutoSize = true;
            this.label1_radius.Location = new System.Drawing.Point(266, 34);
            this.label1_radius.Name = "label1_radius";
            this.label1_radius.Size = new System.Drawing.Size(112, 27);
            this.label1_radius.TabIndex = 2;
            this.label1_radius.Text = "搜索半径";
            // 
            // numericUpDown2_radius_unit
            // 
            this.numericUpDown2_radius_unit.Location = new System.Drawing.Point(405, 32);
            this.numericUpDown2_radius_unit.Name = "numericUpDown2_radius_unit";
            this.numericUpDown2_radius_unit.Size = new System.Drawing.Size(499, 38);
            this.numericUpDown2_radius_unit.TabIndex = 8;
            this.numericUpDown2_radius_unit.ValueChanged += new System.EventHandler(this.numericUpDown2_radius_unit_ValueChanged);
            // 
            // label1_radius_unit
            // 
            this.label1_radius_unit.AutoSize = true;
            this.label1_radius_unit.Location = new System.Drawing.Point(266, 106);
            this.label1_radius_unit.Name = "label1_radius_unit";
            this.label1_radius_unit.Size = new System.Drawing.Size(112, 27);
            this.label1_radius_unit.TabIndex = 3;
            this.label1_radius_unit.Text = "半径单位";
            // 
            // comboBox2_radius
            // 
            this.comboBox2_radius.FormattingEnabled = true;
            this.comboBox2_radius.Items.AddRange(new object[] {
            "米(m)",
            "千米(km)"});
            this.comboBox2_radius.Location = new System.Drawing.Point(405, 103);
            this.comboBox2_radius.Name = "comboBox2_radius";
            this.comboBox2_radius.Size = new System.Drawing.Size(499, 34);
            this.comboBox2_radius.TabIndex = 7;
            this.comboBox2_radius.SelectedIndexChanged += new System.EventHandler(this.comboBox2_radius_SelectedIndexChanged);
            // 
            // TP2_paraKDE_output
            // 
            this.TP2_paraKDE_output.Controls.Add(this.panel6);
            this.TP2_paraKDE_output.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TP2_paraKDE_output.Location = new System.Drawing.Point(4, 35);
            this.TP2_paraKDE_output.Name = "TP2_paraKDE_output";
            this.TP2_paraKDE_output.Padding = new System.Windows.Forms.Padding(3);
            this.TP2_paraKDE_output.Size = new System.Drawing.Size(1174, 612);
            this.TP2_paraKDE_output.TabIndex = 1;
            this.TP2_paraKDE_output.Text = "输出";
            this.TP2_paraKDE_output.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1168, 606);
            this.panel6.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1_output_path);
            this.panel5.Controls.Add(this.label2_text_output_path);
            this.panel5.Controls.Add(this.label1_output_path);
            this.panel5.Controls.Add(this.button1_output_path);
            this.panel5.Controls.Add(this.checkBox1_add_to_map);
            this.panel5.Controls.Add(this.label2_is_add_to_map);
            this.panel5.Controls.Add(this.comboBox2_raster_sort);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1168, 351);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // textBox1_output_path
            // 
            this.textBox1_output_path.Location = new System.Drawing.Point(481, 174);
            this.textBox1_output_path.Name = "textBox1_output_path";
            this.textBox1_output_path.Size = new System.Drawing.Size(441, 38);
            this.textBox1_output_path.TabIndex = 7;
            this.textBox1_output_path.TextChanged += new System.EventHandler(this.textBox1_output_path_TextChanged);
            // 
            // label2_text_output_path
            // 
            this.label2_text_output_path.AutoSize = true;
            this.label2_text_output_path.Location = new System.Drawing.Point(270, 177);
            this.label2_text_output_path.Name = "label2_text_output_path";
            this.label2_text_output_path.Size = new System.Drawing.Size(112, 27);
            this.label2_text_output_path.TabIndex = 6;
            this.label2_text_output_path.Text = "路径文本";
            // 
            // label1_output_path
            // 
            this.label1_output_path.AutoSize = true;
            this.label1_output_path.Location = new System.Drawing.Point(270, 254);
            this.label1_output_path.Name = "label1_output_path";
            this.label1_output_path.Size = new System.Drawing.Size(112, 27);
            this.label1_output_path.TabIndex = 0;
            this.label1_output_path.Text = "选择路径";
            this.label1_output_path.Click += new System.EventHandler(this.label1_output_path_Click);
            // 
            // button1_output_path
            // 
            this.button1_output_path.Location = new System.Drawing.Point(587, 247);
            this.button1_output_path.Name = "button1_output_path";
            this.button1_output_path.Size = new System.Drawing.Size(162, 41);
            this.button1_output_path.TabIndex = 1;
            this.button1_output_path.Text = "确定";
            this.button1_output_path.UseVisualStyleBackColor = true;
            this.button1_output_path.Click += new System.EventHandler(this.button1_output_path_Click);
            // 
            // checkBox1_add_to_map
            // 
            this.checkBox1_add_to_map.AutoSize = true;
            this.checkBox1_add_to_map.Location = new System.Drawing.Point(557, 94);
            this.checkBox1_add_to_map.Name = "checkBox1_add_to_map";
            this.checkBox1_add_to_map.Size = new System.Drawing.Size(225, 31);
            this.checkBox1_add_to_map.TabIndex = 4;
            this.checkBox1_add_to_map.Text = "可选(默认不勾选)";
            this.checkBox1_add_to_map.UseVisualStyleBackColor = true;
            this.checkBox1_add_to_map.CheckedChanged += new System.EventHandler(this.checkBox1_add_to_map_CheckedChanged);
            // 
            // label2_is_add_to_map
            // 
            this.label2_is_add_to_map.AutoSize = true;
            this.label2_is_add_to_map.Location = new System.Drawing.Point(224, 98);
            this.label2_is_add_to_map.Name = "label2_is_add_to_map";
            this.label2_is_add_to_map.Size = new System.Drawing.Size(237, 27);
            this.label2_is_add_to_map.TabIndex = 5;
            this.label2_is_add_to_map.Text = "是否选择添加到地图";
            // 
            // comboBox2_raster_sort
            // 
            this.comboBox2_raster_sort.FormattingEnabled = true;
            this.comboBox2_raster_sort.Items.AddRange(new object[] {
            "TIFF",
            "IMG",
            "GRID",
            "ASC"});
            this.comboBox2_raster_sort.Location = new System.Drawing.Point(481, 23);
            this.comboBox2_raster_sort.Name = "comboBox2_raster_sort";
            this.comboBox2_raster_sort.Size = new System.Drawing.Size(441, 34);
            this.comboBox2_raster_sort.TabIndex = 3;
            this.comboBox2_raster_sort.SelectedIndexChanged += new System.EventHandler(this.comboBox2_raster_sort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择栅格格式";
            // 
            // TP3_paraKDE_hyper
            // 
            this.TP3_paraKDE_hyper.Controls.Add(this.panel7);
            this.TP3_paraKDE_hyper.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TP3_paraKDE_hyper.Location = new System.Drawing.Point(4, 35);
            this.TP3_paraKDE_hyper.Name = "TP3_paraKDE_hyper";
            this.TP3_paraKDE_hyper.Size = new System.Drawing.Size(1174, 612);
            this.TP3_paraKDE_hyper.TabIndex = 2;
            this.TP3_paraKDE_hyper.Text = "高级";
            this.TP3_paraKDE_hyper.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1174, 612);
            this.panel7.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label2_info_collection_text);
            this.panel10.Controls.Add(this.button1_info_collection);
            this.panel10.Controls.Add(this.button1_recognize_final);
            this.panel10.Controls.Add(this.label2_tips);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 390);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1174, 222);
            this.panel10.TabIndex = 10;
            // 
            // label2_info_collection_text
            // 
            this.label2_info_collection_text.AutoSize = true;
            this.label2_info_collection_text.Location = new System.Drawing.Point(338, 64);
            this.label2_info_collection_text.Name = "label2_info_collection_text";
            this.label2_info_collection_text.Size = new System.Drawing.Size(112, 27);
            this.label2_info_collection_text.TabIndex = 3;
            this.label2_info_collection_text.Text = "执行信息";
            // 
            // button1_info_collection
            // 
            this.button1_info_collection.Location = new System.Drawing.Point(609, 54);
            this.button1_info_collection.Name = "button1_info_collection";
            this.button1_info_collection.Size = new System.Drawing.Size(120, 46);
            this.button1_info_collection.TabIndex = 2;
            this.button1_info_collection.Text = "汇总";
            this.button1_info_collection.UseVisualStyleBackColor = true;
            this.button1_info_collection.Click += new System.EventHandler(this.button1_info_collection_Click);
            // 
            // button1_recognize_final
            // 
            this.button1_recognize_final.Location = new System.Drawing.Point(609, 138);
            this.button1_recognize_final.Name = "button1_recognize_final";
            this.button1_recognize_final.Size = new System.Drawing.Size(120, 46);
            this.button1_recognize_final.TabIndex = 1;
            this.button1_recognize_final.Text = "确定";
            this.button1_recognize_final.UseVisualStyleBackColor = true;
            this.button1_recognize_final.Click += new System.EventHandler(this.button1_recognize_final_Click);
            // 
            // label2_tips
            // 
            this.label2_tips.AutoSize = true;
            this.label2_tips.Location = new System.Drawing.Point(338, 148);
            this.label2_tips.Name = "label2_tips";
            this.label2_tips.Size = new System.Drawing.Size(112, 27);
            this.label2_tips.TabIndex = 0;
            this.label2_tips.Text = "执行确认";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.LBL3_multi_thread);
            this.panel9.Controls.Add(this.LBL4_normalize);
            this.panel9.Controls.Add(this.checkBox2_normalize);
            this.panel9.Controls.Add(this.checkBox1_multi_thread);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 199);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1174, 191);
            this.panel9.TabIndex = 9;
            // 
            // LBL3_multi_thread
            // 
            this.LBL3_multi_thread.AutoSize = true;
            this.LBL3_multi_thread.Location = new System.Drawing.Point(328, 41);
            this.LBL3_multi_thread.Name = "LBL3_multi_thread";
            this.LBL3_multi_thread.Size = new System.Drawing.Size(137, 27);
            this.LBL3_multi_thread.TabIndex = 4;
            this.LBL3_multi_thread.Text = "使用多线程";
            // 
            // LBL4_normalize
            // 
            this.LBL4_normalize.AutoSize = true;
            this.LBL4_normalize.Location = new System.Drawing.Point(328, 139);
            this.LBL4_normalize.Name = "LBL4_normalize";
            this.LBL4_normalize.Size = new System.Drawing.Size(137, 27);
            this.LBL4_normalize.TabIndex = 5;
            this.LBL4_normalize.Text = "自动归一化";
            // 
            // checkBox2_normalize
            // 
            this.checkBox2_normalize.AutoSize = true;
            this.checkBox2_normalize.Location = new System.Drawing.Point(565, 137);
            this.checkBox2_normalize.Name = "checkBox2_normalize";
            this.checkBox2_normalize.Size = new System.Drawing.Size(225, 31);
            this.checkBox2_normalize.TabIndex = 7;
            this.checkBox2_normalize.Text = "可选(默认不勾选)";
            this.checkBox2_normalize.UseVisualStyleBackColor = true;
            this.checkBox2_normalize.CheckedChanged += new System.EventHandler(this.checkBox2_normalize_CheckedChanged);
            // 
            // checkBox1_multi_thread
            // 
            this.checkBox1_multi_thread.AutoSize = true;
            this.checkBox1_multi_thread.Location = new System.Drawing.Point(565, 40);
            this.checkBox1_multi_thread.Name = "checkBox1_multi_thread";
            this.checkBox1_multi_thread.Size = new System.Drawing.Size(225, 31);
            this.checkBox1_multi_thread.TabIndex = 6;
            this.checkBox1_multi_thread.Text = "可选(默认不勾选)";
            this.checkBox1_multi_thread.UseVisualStyleBackColor = true;
            this.checkBox1_multi_thread.CheckedChanged += new System.EventHandler(this.checkBox1_multi_thread_CheckedChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.LBL1_kernel_sort);
            this.panel8.Controls.Add(this.comboBox1);
            this.panel8.Controls.Add(this.LBL2_sampling_points);
            this.panel8.Controls.Add(this.numericUpDown1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1174, 199);
            this.panel8.TabIndex = 9;
            // 
            // LBL1_kernel_sort
            // 
            this.LBL1_kernel_sort.AutoSize = true;
            this.LBL1_kernel_sort.Location = new System.Drawing.Point(328, 38);
            this.LBL1_kernel_sort.Name = "LBL1_kernel_sort";
            this.LBL1_kernel_sort.Size = new System.Drawing.Size(137, 27);
            this.LBL1_kernel_sort.TabIndex = 1;
            this.LBL1_kernel_sort.Text = "核函数类型";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "高斯核(默认)",
            "均匀核",
            "四分位核"});
            this.comboBox1.Location = new System.Drawing.Point(510, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 34);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LBL2_sampling_points
            // 
            this.LBL2_sampling_points.AutoSize = true;
            this.LBL2_sampling_points.Location = new System.Drawing.Point(338, 132);
            this.LBL2_sampling_points.Name = "LBL2_sampling_points";
            this.LBL2_sampling_points.Size = new System.Drawing.Size(112, 27);
            this.LBL2_sampling_points.TabIndex = 2;
            this.LBL2_sampling_points.Text = "采样点数";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(510, 132);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(345, 38);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // frmParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 651);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmParameter";
            this.Text = "核密度估计参数";
            this.Load += new System.EventHandler(this.frmParameter_Load);
            this.tabControl1.ResumeLayout(false);
            this.TP1_paraKDE_input.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_raster_resolution)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_radius_unit)).EndInit();
            this.TP2_paraKDE_output.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.TP3_paraKDE_hyper.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TP1_paraKDE_input;
        private System.Windows.Forms.TabPage TP2_paraKDE_output;
        private System.Windows.Forms.TabPage TP3_paraKDE_hyper;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LBL1_kernel_sort;
        private System.Windows.Forms.Label LBL2_sampling_points;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label LBL3_multi_thread;
        private System.Windows.Forms.Label LBL4_normalize;
        private System.Windows.Forms.CheckBox checkBox2_normalize;
        private System.Windows.Forms.CheckBox checkBox1_multi_thread;
        private System.Windows.Forms.Label label1_selected_layer;
        private System.Windows.Forms.Label label1_weigh_field;
        private System.Windows.Forms.Label label1_radius;
        private System.Windows.Forms.Label label1_radius_unit;
        private System.Windows.Forms.Label label1_raster_resolution;
        private System.Windows.Forms.ComboBox comboBox2_selected_layer;
        private System.Windows.Forms.ComboBox comboBox2_weigh_field;
        private System.Windows.Forms.ComboBox comboBox2_radius;
        private System.Windows.Forms.NumericUpDown numericUpDown2_radius_unit;
        private System.Windows.Forms.NumericUpDown numericUpDown2_raster_resolution;
        private System.Windows.Forms.Label label1_output_path;
        private System.Windows.Forms.Button button1_output_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2_raster_sort;
        private System.Windows.Forms.Label label2_is_add_to_map;
        private System.Windows.Forms.CheckBox checkBox1_add_to_map;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2_text_output_path;
        private System.Windows.Forms.TextBox textBox1_output_path;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2_tips;
        private System.Windows.Forms.Button button1_recognize_final;
        private System.Windows.Forms.Button button1_info_collection;
        private System.Windows.Forms.Label label2_info_collection_text;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button1_input_next_page;
    }
}