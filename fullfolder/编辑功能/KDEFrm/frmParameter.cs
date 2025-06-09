using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GIS应用系统.KDE核密度计算.KDEBinary;
using GIS应用系统.KDE核密度计算.KDEFrm;

namespace GIS应用系统.KDE核密度计算.KDEFrm
{
    public partial class frmParameter : Form
    {

        //这里我在窗体里插入了新的变量
        //在这里声明一个 UpdateInputPageInfoCollection 类型的私有变量
        //这个变量将用来引用我们的“参数数据包”对象
        private UpdateInputPageInfoCollection _kdeParameters; 
        //插入变量，转到第30行“创建一个“参数数据包”的实例变量”


        public frmParameter()
        {
            InitializeComponent();

            //在窗体的构造函数中，创建 UpdateInputPageInfoCollection 类的一个新实例
            //并将其赋值给我们上面声明的 _kdeParameters 变量。
            _kdeParameters = new UpdateInputPageInfoCollection();
            //现在，_kdeParameters 就指向了一个具体的、可以用来存储参数的对象了，转到第34行，在窗体中植入一个私有方法
        }

        private void GatherUIDataIntoKdeParameters()  //是这个喵，这个方法后面会用到
        {

            // 这个方法负责从窗体上的所有相关控件读取用户输入，
            // 并将这些值更新到 _kdeParameters 对象中。
    

            // 开始从界面控件读取值，并存入 _kdeParameters
          
            // 1. 处理“搜索半径” (来自 numericUpDown2_radius_unit)
            _kdeParameters.SearchRadius = (double)numericUpDown2_radius_unit.Value;

            // 2. 处理“选择图层” (来自 comboBox2_selected_layer)
            //    SelectedItem 返回的是选中的对象，ToString() 获取其文本表示。
            //    ?. 操作符用于安全地访问，如果 SelectedItem 为 null (未选择任何项)，则结果为 null。
            _kdeParameters.SelectedLayerName = comboBox2_selected_layer.SelectedItem.ToString();

            // 3. 处理“输出路径” (来自 textBox1_output_path)
            _kdeParameters.OutputPath = textBox1_output_path.Text;

            // 4. 处理“是否添加到地图图层” (来自 checkBox1_add_to_map)
            _kdeParameters.AddResultToMap = checkBox1_add_to_map.Checked;

            // 5. 处理“权重字段” (来自 comboBox2_weigh_field)
            _kdeParameters.WeightField = comboBox2_weigh_field.SelectedItem.ToString();

            // 6. 处理“核函数类型” (来自 comboBox1)
            _kdeParameters.KernelFunctionType = comboBox1.SelectedItem.ToString();

            // 7. 处理“半径单位” (来自 comboBox2_radius)
            _kdeParameters.SearchRadiusUnit = comboBox2_radius.SelectedItem.ToString();

            // 8. 处理“核函数采样点数” (来自 numericUpDown1)
            _kdeParameters.KernelSamplingPoints = (int)numericUpDown1.Value; // 假设 numericUpDown1 的 Value 是 decimal，可以转为 int

            // 9. 处理“栅格分辨率” (来自 numericUpDown2_raster_resolution)
            _kdeParameters.OutputRasterResolution = (double)numericUpDown2_raster_resolution.Value;

            // 10. 处理“栅格格式” (来自 comboBox2_raster_sort)
            _kdeParameters.OutputRasterFormat = comboBox2_raster_sort.SelectedItem.ToString();

            // 11. 处理“使用多线程” (来自 checkBox1_multi_thread)
            _kdeParameters.UseMultiThreading = checkBox1_multi_thread.Checked;

            // 12. 处理“使用自动归一化” (来自 checkBox2_normalize)
            _kdeParameters.UseNormalization = checkBox2_normalize.Checked;

        
        }
        private void button1_recognize_final_Click(object sender, EventArgs e)//高级信息执行决定
        {
            //调用方法、先收集界面参数
            GatherUIDataIntoKdeParameters();

            MessageBox.Show(     //1
                                "即将执行KDE分析：\n" +
                                "搜索半径: {_kdeParameters.SearchRadius}" +
                                "半径单位: {_kdeParameters.SearchRadiusUnit}" +
                                "栅格分辨率:{_kdeParameters.OutputRasterResolution}" +
                                "选择图层: {_kdeParameters.SelectedLayerName}\n" +
                                "权重字段: {_kdeParameters.WeightField}" +
                //2
                                "选择栅格格式: {_kdeParameters.OutputRasterFormat}" +
                                "搜索半径: {_kdeParameters.SearchRadius} {_kdeParameters.SearchRadiusUnit}\n" +
                                "输出路径: {_kdeParameters.OutputPath}",
                                "参数确认"
                            );







        }

        private void frmParameter_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//核函数类型选择
        {

        }

        private void comboBox2_weigh_field_SelectedIndexChanged(object sender, EventArgs e)//权重字段
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label1_raster_resolution_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_output_path_Click(object sender, EventArgs e)
        {

        }

        private void button1_output_path_Click(object sender, EventArgs e)//选择输出执行确定的按钮
        {

        }

        private void comboBox2_raster_sort_SelectedIndexChanged(object sender, EventArgs e)//选择栅格格式
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_output_path_TextChanged(object sender, EventArgs e)//输出的路径
        {
            
        }

        private void numericUpDown2_radius_unit_ValueChanged(object sender, EventArgs e)//搜索半径
        {
         
        }

        private void comboBox2_radius_SelectedIndexChanged(object sender, EventArgs e)//半径单位
        {

        }

        private void numericUpDown2_raster_resolution_ValueChanged(object sender, EventArgs e)//栅格分辨率
        {

        }

        private void comboBox2_selected_layer_SelectedIndexChanged(object sender, EventArgs e)//选择图层
        {

        }

        private void checkBox1_add_to_map_CheckedChanged(object sender, EventArgs e)//是否添加到地图图层
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)//核函数采样点数
        {

        }

        private void checkBox1_multi_thread_CheckedChanged(object sender, EventArgs e)//使用多线程的checkBox勾选
        {

        }

        private void checkBox2_normalize_CheckedChanged(object sender, EventArgs e)//使用自动归一化的checkBox勾选
        {

        }

        private void button1_info_collection_Click(object sender, EventArgs e)//高级信息汇总

        {

        }

       

        private void button1_input_next_page_Click(object sender, EventArgs e)//输入page的下一页
        {

        }

        private void textBox1_input_page_info_collection_TextChanged(object sender, EventArgs e)//输入设置页的信息汇总
        {

        }


       
        
    }
}
