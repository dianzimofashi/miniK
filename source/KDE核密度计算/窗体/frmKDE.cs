using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geoprocessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GIS应用系统.窗体;
using ESRI.ArcGIS.SpatialAnalystTools;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.GeoAnalyst;
using ESRI.ArcGIS.SpatialAnalyst;

namespace GIS应用系统.KDE核密度计算.KDEFrm
{
    public partial class frmKDE : Form
    {
        private AxMapControl _mapControl;  // 

        public frmKDE(AxMapControl mapControl)  // 
        {
            InitializeComponent();
            _mapControl = mapControl; // 将传进来的对象保存下来

            //初始化授权和环境对象：移动至构造函数
            IAoInitialize aoInit = new AoInitializeClass();
            esriLicenseStatus licenseStatus = aoInit.Initialize(esriLicenseProductCode.esriLicenseProductCodeEngine);

            if (licenseStatus != esriLicenseStatus.esriLicenseCheckedOut)
            {
                MessageBox.Show("ArcGIS Engine 授权失败，请检查许可状态。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            esriLicenseStatus saStatus = aoInit.CheckOutExtension(esriLicenseExtensionCode.esriLicenseExtensionCodeSpatialAnalyst);
            if (saStatus != esriLicenseStatus.esriLicenseCheckedOut)
            {
                MessageBox.Show("Spatial Analyst 扩展未授权或不可用。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //初始化密度分析对象和环境对象
            densityOp = new RasterDensityOpClass();
            rasterEnv = densityOp as IRasterAnalysisEnvironment;

            if (rasterEnv == null)
            {
                MessageBox.Show("RasterAnalysisEnvironment 初始化失败，请确认 Spatial Analyst 扩展授权已成功。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void frmKDE_Load(object sender, EventArgs e)
        {
            IAoInitialize aoInit = new AoInitializeClass();


            // 初始化 MapControl 图层
            comboBox_select_layer.Items.Clear();
            for (int i = 0; i < _mapControl.LayerCount; i++)
            {
                ILayer layer = _mapControl.get_Layer(i);
                if (layer is IFeatureLayer)
                {
                    comboBox_select_layer.Items.Add(layer.Name);
                }
            }
            if (comboBox_select_layer.Items.Count > 0)
                comboBox_select_layer.SelectedIndex = 0;


        }

        private void button_broswer_Click(object sender, EventArgs e)//设置保存栅格文件的路径
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "栅格文件 (*.TIFF)|*.TIFF";
            sfd.Title = "选择输出路径";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBox_save_path.Text = sfd.FileName;
            }

        }
        //定义GetFeatureLayerByName，传入mapcontrol
        private IFeatureLayer GetFeatureLayerByName(string name)
        {
            for (int i = 0; i < _mapControl.LayerCount; i++)
            {
                ILayer layer = _mapControl.get_Layer(i);
                if (layer.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && layer is IFeatureLayer)
                    return layer as IFeatureLayer;
            }
            return null;
        }

//__________________________________________________________________________________________________________
//----------------------------------------------------------------------------------------------------------
        private double cellSize = 50;
        private double radioDis = 600;
        private object Missing = Type.Missing;
        private object extentProviderObj;
        private object cellSizeObj;
        private object radioDisObj;
        private IRasterAnalysisEnvironment rasterEnv;//环境分析对象
        private IDensityOp densityOp;//密度分析对象
        private IFeatureClass featureClass;
        private IFeatureClassDescriptor featureDes;
        private IGeoDataset inGeoDataset;//输入数据集
        private IGeoDataset outGeoDataset;//输出数据集
//
        private ILayer getLayerFromName(string layerName)//加入新的getLayerFromName方法
        {
            for (int i = 0; i < _mapControl.LayerCount; i++)
            {
                ILayer layer = _mapControl.get_Layer(i);
                if (layer != null && layer.Name == layerName)
                    return layer;
            }
            return null;
        }

        /// <summary>
        /// 显示结果栅格图层
        /// </summary>
        /// <param name="result">核密度分析返回的栅格数据集</param>
        /// <param name="layerName">显示图层名称</param>
        private void ShowResult(IGeoDataset result, string layerName)//加入ShowResult方法
        {
            IRasterLayer rasterLayer = new RasterLayerClass();
            rasterLayer.CreateFromRaster(result as IRaster);
            rasterLayer.Name = layerName;
            _mapControl.AddLayer(rasterLayer as ILayer);
            _mapControl.Refresh();
        }

      

        private void comboBox_select_layer_SelectedIndexChanged(object sender, EventArgs e)//选择的图层
        {
            // 获取图层
            ILayer layer = getLayerFromName(comboBox_select_layer.SelectedItem.ToString());
            if (layer == null)
                return;

            IFeatureLayer fLayer = layer as IFeatureLayer;
            if (fLayer == null)
                return;

            featureClass = fLayer.FeatureClass;
            if (featureClass == null)
                return;

            // 设置分析范围
            extentProviderObj = layer;
            // 设置分析范围前进行判空处理 //加的测试
            if (rasterEnv != null)
            {
                extentProviderObj = layer;
                rasterEnv.SetExtent(esriRasterEnvSettingEnum.esriRasterEnvValue, ref extentProviderObj, Missing);
            }
            else
            {
                MessageBox.Show("RasterAnalysisEnvironment 未初始化，无法设置分析范围。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           // rasterEnv.SetExtent(esriRasterEnvSettingEnum.esriRasterEnvValue, ref extentProviderObj, Missing);//bug//多调用了一次，2025.6.5

            // 现在再加载字段
            comboBox_fields.Items.Clear();
            for (int i = 0; i < featureClass.Fields.FieldCount; i++)
            {
                IField field = featureClass.Fields.get_Field(i);
                if (field.Type == esriFieldType.esriFieldTypeInteger || field.Type == esriFieldType.esriFieldTypeDouble)
                {
                    comboBox_fields.Items.Add(field.Name);
                }
            }

        }

        //设置计数字段
        private void comboBox_fields_SelectedIndexChanged(object sender, EventArgs e)
        {
            //字段选择后设置 featureDes 和 inGeoDataset
            if (featureClass == null || comboBox_fields.SelectedItem == null)
                return;

            string fieldName = comboBox_fields.SelectedItem.ToString();

            //featureDes = (IFeatureClassDescriptor)new FeatureClassDescriptionClass();//错误，2025.6.5
            featureDes = new FeatureClassDescriptorClass();
            featureDes.Create(featureClass, null, fieldName);
            inGeoDataset = featureDes as IGeoDataset;

        }
        
        //设置输出栅格的大小
        private void textBox_raster_resolution_TextChanged(object sender, EventArgs e)
        {
            string input = textBox_raster_resolution.Text;
            double result;

            if (string.IsNullOrWhiteSpace(input))
            {
                cellSizeObj = null;
                return;
            }

            if (double.TryParse(input, out result))
            {
                cellSize = result;
                cellSizeObj = cellSize;

                if (rasterEnv != null)
                {
                    rasterEnv.SetCellSize(esriRasterEnvSettingEnum.esriRasterEnvValue, ref cellSizeObj);
                }
            }
            else
            {
                cellSizeObj = null;
                MessageBox.Show("栅格大小必须是有效数字（例如：50、100.5）。", "输入格式错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_raster_resolution.Clear(); // 可选
            }
        }

        //设置搜索半径大小
        private void textBox_search_radius_TextChanged(object sender, EventArgs e)
        {
            string input = textBox_search_radius.Text;
            double result; // 先声明变量

            if (string.IsNullOrWhiteSpace(input))
            {
                radioDisObj = null;
                return;
            }

            if (double.TryParse(input, out result))
            {
                radioDis = result;
                radioDisObj = radioDis;
            }
            else
            {
                radioDisObj = null;
                MessageBox.Show("搜索半径必须是有效数字（例如：100、500.5）。", "输入格式错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_search_radius.Clear(); // 可选：清除错误输入
            }


            
        }

        private void button_OK_Click(object sender, EventArgs e)//OK按钮    -> //核密度分析
        {
            if (inGeoDataset == null)
            {
                MessageBox.Show("输入数据未正确设置。请检查是否选择了图层和字段。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioDisObj == null)
            {
                MessageBox.Show("搜索半径未设置或格式错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (densityOp == null)
            {
                densityOp = new RasterDensityOpClass();
            }

            try
            {
                outGeoDataset = densityOp.KernelDensity(inGeoDataset, ref radioDisObj, Missing);
                ShowResult(outGeoDataset, "KernelDensity");
            }
            catch (Exception ex)
            {
                MessageBox.Show("执行核密度分析失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "确认",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        public string SELECT_LAYER//combo
        {
            get { return comboBox_select_layer.SelectedItem == null ? string.Empty : comboBox_select_layer.SelectedItem.ToString(); }
        }


        public string RASTER_RESOLUTION//文本
        {
            get { return comboBox_fields.Text.Trim(); }
        }


        public string RASTER_SORT//
        {
            get { return comboBox_fields.SelectedItem == null ? string.Empty : comboBox_fields.SelectedItem.ToString(); }
        }

        public string KERNEL_FUNCTION
        {
            get { return comboBox_kernel_fuc.SelectedItem == null ? string.Empty : comboBox_kernel_fuc.SelectedItem.ToString(); }
        }

        public string SEARCH_RADIUS
        {
            get { return textBox_search_radius.Text.Trim(); }
        }

        public string RADIUS_UNIT
        {
            get { return comboBox_radius_unit.SelectedItem == null ? string.Empty : comboBox_radius_unit.SelectedItem.ToString(); }
        }

        public string SAVE_PATH
        {
            get { return textBox_save_path.Text.Trim(); }
        }










    }
}
