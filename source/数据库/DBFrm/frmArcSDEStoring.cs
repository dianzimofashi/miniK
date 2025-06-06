using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIS应用系统.数据库.DBFrm
{
    public partial class frmArcSDEStoring : Form
    {
        public frmArcSDEStoring()
        {
            InitializeComponent();
        }

        private void button_store_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ArcSDE 连接成功,ArcSDE版本为默认default型，Windows用户验证已开启,所选图层已导入至ArcSDE数据库");
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
    }
}
