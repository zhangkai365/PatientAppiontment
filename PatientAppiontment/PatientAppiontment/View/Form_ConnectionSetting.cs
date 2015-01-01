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
using System.Data.SqlClient;

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
            cmb_DataBaseSelect.Items.Add(@"预约数据库连接");
            cmb_DataBaseSelect.Items.Add(@"超声工作站数据库连接");
            cmb_DataBaseSelect.SelectedIndex = 0;
            UIUpdate(cmb_DataBaseSelect.SelectedIndex);
        }

        /// <summary>
        /// 恢复默认设置按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ResetDefalut_Click(object sender, EventArgs e)
        {
            //连接字符串初始化
            ConnectionMethod _connectionString = new ConnectionMethod();
            _connectionString.Reset();
            UIUpdate(cmb_DataBaseSelect.SelectedIndex);
        }

        /// <summary>
        /// 保存并测试按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveAndTest_Click(object sender, EventArgs e)
        {
            string testConnectionResult = @"测试程序出现问题，";
            ConnectionGroup updateConnection = new ConnectionGroup() { 
                dataSource = txt_DataSource.Text, 
                initialCatalog = txt_InitialCatalog.Text, 
                userID = txt_UserID.Text, 
                password = txt_Password.Text, 
                intergratedSecurity = false };
            ConnectionMethod connectionMethod = new ConnectionMethod();
            connectionMethod.Update(cmb_DataBaseSelect.SelectedIndex, updateConnection);
            if (cmb_DataBaseSelect.SelectedIndex == 0)
            {
                if (IsConnectionAvailable(AppConnection.AppiontmentDataBaseConnectionString))
                {
                    testConnectionResult = @"连接" + cmb_DataBaseSelect.SelectedItem.ToString() + "成功！";
                }
                else
                {
                    testConnectionResult = @"连接" + cmb_DataBaseSelect.SelectedItem.ToString() + "失败！";
                }
            }
            if (cmb_DataBaseSelect.SelectedIndex == 1)
            {
                if (IsConnectionAvailable(AppConnection.UltraSoundDataBaseConnectionString))
                {
                    testConnectionResult = "连接" + cmb_DataBaseSelect.SelectedItem.ToString() + "成功！";
                }
                else
                {
                    testConnectionResult = "连接" + cmb_DataBaseSelect.SelectedItem.ToString() + "失败";
                }
            }
            MessageBox.Show(testConnectionResult);
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
        /// 根据传入的参数更新文本框
        /// </summary>
        public void UIUpdate(int selectDatabaseConnectionIndex)
        {
            if (selectDatabaseConnectionIndex == 0)
            {
                txt_DataSource.Text = AppConnection.AppiontmentDataBaseConnectionGroup.dataSource;
                txt_InitialCatalog.Text = AppConnection.AppiontmentDataBaseConnectionGroup.initialCatalog;
                txt_UserID.Text = AppConnection.AppiontmentDataBaseConnectionGroup.userID;
                txt_Password.Text = AppConnection.AppiontmentDataBaseConnectionGroup.password; 
            }
            if (selectDatabaseConnectionIndex == 1)
            {
                txt_DataSource.Text = AppConnection.UltraSoundDataBaseConnectionGroup.dataSource;
                txt_InitialCatalog.Text = AppConnection.UltraSoundDataBaseConnectionGroup.initialCatalog;
                txt_UserID.Text = AppConnection.UltraSoundDataBaseConnectionGroup.userID;
                txt_Password.Text = AppConnection.UltraSoundDataBaseConnectionGroup.password;
            }
        }

        /// <summary>
        /// 下拉选择框选择其他的选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_DataBaseSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIUpdate(cmb_DataBaseSelect.SelectedIndex);
        }

        public bool IsConnectionAvailable(string connectionString)
        {
            bool IsAvailable = false;
            SqlConnection testConnection = new SqlConnection(connectionString);
            try
            {
                testConnection.Open();
                IsAvailable = true;
            }
            catch
            {
                IsAvailable = false;
            }
            finally
            {
                testConnection.Close();
            }
            return IsAvailable;
        }
    }
}
