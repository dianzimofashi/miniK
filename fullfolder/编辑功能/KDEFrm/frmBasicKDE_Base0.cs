using ESRI.ArcGIS.Carto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIS应用系统.KDE核密度计算.KDEFrm

{
    public partial class frmBasicKDE_Base0 : Form
    {
        //public IMap Map { get; set; }// +++++++

        public frmBasicKDE_Base0()
        {
            InitializeComponent();
        }



        private void frmBasicKDE_Base0_Load(object sender, EventArgs e)
        {
           
        }
  


        private void comboBox1_selected_layer_SelectedIndexChanged(object sender, EventArgs e)//选择点图层
        {

        }

        private void numericUpDown1_search_distance_ValueChanged(object sender, EventArgs e)//搜索距离
        {

        }

        private void comboBox2_distance_unit_SelectedIndexChanged(object sender, EventArgs e)//距离单位
        {

        }

        private void numericUpDown1_raster_resolution_ValueChanged(object sender, EventArgs e)//栅格分辨率
        {

        }

        private void comboBox4_kernel_function_SelectedIndexChanged(object sender, EventArgs e)//核函数
        {

        }

        private void comboBox4_raster_sort_SelectedIndexChanged(object sender, EventArgs e)//栅格格式
        {

        }

        private void button1_path_set_Click(object sender, EventArgs e)//浏览选择路径
        {

        }

        private void textBox1_output_path_TextChanged(object sender, EventArgs e)//负责展示选择路径的文本textbox
        {

        }


    }
}
