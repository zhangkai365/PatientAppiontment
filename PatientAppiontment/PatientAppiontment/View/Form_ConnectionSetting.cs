using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Project Include
using PatientAppiontment.Data;

namespace PatientAppiontment.View
{
    public partial class Form_ConnectionSetting : Form
    {
        public Form_ConnectionSetting()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_ConnectionSetting_Load(object sender, EventArgs e)
        {
            textBoxUpdate();
        }

        /// <summary>
        /// 恢复默认设置按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ResetDefalut_Click(object sender, EventArgs e)
        {
            //连接字符串初始化
            ConnectionString _connectionString = new ConnectionString();
            _connectionString.Reset();
            textBoxUpdate();

        }

        /// <summary>
        /// 保存并测试按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveAndTest_Click(object sender, EventArgs e)
        {
            ConnectionString._dataSource = txt_DataSource.Text;
            ConnectionString._initialCatalog = txt_InitialCatalog.Text;
            ConnectionString._userID = txt_UserID.Text;
            ConnectionString._password = txt_Password.Text;
            ConnectionString _connectionString = new ConnectionString();
            _connectionString.Update();
        }

        /// <summary>
        /// 点击返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 更新文本框
        /// </summary>
        public void textBoxUpdate()
        {
            txt_DataSource.Text = ConnectionString._dataSource;
            txt_InitialCatalog.Text = ConnectionString._initialCatalog;
            txt_UserID.Text = ConnectionString._userID;
            txt_Password.Text = ConnectionString._password;
        }

    }
}
