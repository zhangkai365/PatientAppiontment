using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Project Include
using PatientAppointment.DataBase;
using PatientAppointment.Common;

namespace PatientAppointment.View
{
    public partial class Form_DataBaseManagement : Form
    {
        public Form_DataBaseManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 判断数据库是否存在的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_IsDataBaseExist_Appointment_Click(object sender, EventArgs e)
        {
            DataBaseManagement mnDataBaseManagement = new DataBaseManagement();
            Status_Existence mnStatus_Existence = mnDataBaseManagement.DatabaseExistStatus();
            if (mnStatus_Existence.exsitence == Existence.Yes) lab_DataBaseStatus.Text = @"数据库存在";
            if (mnStatus_Existence.exsitence == Existence.No)
            { 
                lab_DataBaseStatus.Text = @"数据库不存在";
                btn_CreateDataBase_Appointment.Enabled = true;
            }
            if (mnStatus_Existence.exsitence == Existence.Unknown) lab_DataBaseStatus.Text = @"数据库状态未知";
        }

        /// <summary>
        /// 界面初始化，禁用创建数据库的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_DataBaseManagement_Load(object sender, EventArgs e)
        {
            btn_CreateDataBase_Appointment.Enabled = false;
        }

        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CreateDataBase_Appointment_Click(object sender, EventArgs e)
        {
            lab_DataBaseStatus.Text = @"正在创建数据库";
            btn_CreateDataBase_Appointment.Enabled = false;
            DataBaseManagement dataBaseManagement = new DataBaseManagement();
            Status Result_CreateDataBase = dataBaseManagement.CreateDatabaseAndTables();
            if (Result_CreateDataBase.result == Result.Success)
            {
                btn_CreateDataBase_Appointment.Enabled = false;
                lab_DataBaseStatus.Text = @"创建数据库、表成功";
            }
            if (!(Result_CreateDataBase.result == Result.Success))
            {
                lab_DataBaseStatus.Text = @"创建数据库、表失败";
                MessageBox.Show("创建数据库失败!"+ "\n" + Result_CreateDataBase.codeSnippetName + "\n" + Result_CreateDataBase.result.ToString() + "\n" + Result_CreateDataBase.message);
                btn_IsDataBaseExist_Appointment_Click(sender, e);
            }
        }
    }
}
