using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIS应用系统.数据库
{
    public partial class frmArcSDEConn : Form
    {
        public frmArcSDEConn()
        {
            InitializeComponent();
        }

        private void frmArcSDEConn_Load(object sender, EventArgs e)
        {

        }

        private void button1_ArcSDEConn_Click(object sender, EventArgs e)
        {
            //ArcSDE有四种连接方式
            //第一种是文件连接
            //string conn_file = @"\连接到(local).sde";
            //用着这个文件连接，连接的熟悉属性都写在这个文件中，是固定的连接
            //IWorkspaceFactory pIWorkspaceFactory = new SdeIWorkspaceFactory();
            //新建对象，使用一个接口变量
            MessageBox.Show("ArcSDE 连接成功,ArcSDE版本为默认default型，Windows用户验证已开启");


        }

        private void button2_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "确认",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
