using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIS应用系统.窗体
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn1_login_Click(object sender, EventArgs e)
        {
            string username = txb1_username.Text.Trim();
            string password = txb2_password.Text;

            // 简单判断（可替换为数据库验证等）
            if (username == "sa" && password == "123")
            {
                // 登录成功，设置结果为 OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb1_username.Clear();  // 清空密码框
                txb2_password.Focus();  // 聚焦回密码框
            }
        }

        private void btn2_quit_Click(object sender, EventArgs e)
        {
            // 可以直接退出程序，或关闭窗体
            Application.Exit();
            // 或 this.Close();（用于只关闭当前窗体）
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txb1_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb2_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_user_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_password_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_hello_title_Click(object sender, EventArgs e)
        {
            lbl3_hello_title.BackColor = Color.Transparent;

        }

  
    }
}
