using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Project Include
using System.Data.SqlClient;
using PatientAppointment.DataBase;
using PatientAppointment.View;
using PatientAppointment.Common;
using PatientAppointment.Control;
using PatientAppointment.TestUnit;

namespace PatientAppointment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();        
        }

        public void StartConnectiont()
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = DataBaseConnection.UltraSoundConnectionString;
            myConnection.Open();
            System.Diagnostics.Stopwatch dataReadTime = new System.Diagnostics.Stopwatch();
            dataReadTime.Start();
            DateTime myDate = dateTimePicker1.Value.Date;
            string sql = @"SELECT [FoundDate] FROM [engchaosheng].[dbo].[PatientRecords] WHERE [FoundDate]= '"+ myDate.ToString() + @"' ORDER BY [FoundDate] DESC ";
            SqlCommand mycommand = new SqlCommand(sql, myConnection);
            SqlDataReader myDataReader = mycommand.ExecuteReader();

            DataSet myDataSet = new DataSet();
            DataTable myDataTable = new DataTable();
            //DataColumn
            DataColumn ColumnArchiveCode = new DataColumn("ArchiveCode",typeof(int));
            ColumnArchiveCode.Caption = "序号";
            DataColumn ColumnFoundDate = new DataColumn("FoundDate",typeof(DateTime));
            ColumnFoundDate.Caption = "创建日期";
            //myDataTable.Columns.Add(ColumnArchiveCode);
            myDataTable.Columns.Add(ColumnFoundDate);
            DataRow oneRow = myDataTable.NewRow();
            while (myDataReader.Read())
            {
                myDataTable.Rows.Add(myDataTable.NewRow()["FoundDate"] = myDataReader.GetSqlDateTime(0).ToString());
            }
            myConnection.Close();
            dataReadTime.Stop();
            label1.Text = dataReadTime.ElapsedMilliseconds.ToString();
            myDataSet.Tables.Add(myDataTable);
            DataView dataViewSource = new DataView(myDataTable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartConnectiont();
        }

        /// <summary>
        /// 程序退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 设置数据库连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_ConnectionSetting_Click(object sender, EventArgs e)
        {
            Form_ConnectionSetting _form_connectionSetting = new Form_ConnectionSetting();
            _form_connectionSetting.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadPatientCheck();
        }

        public void ReadPatientCheck()
        {

        }

        private void btn_AddNewExam_Click(object sender, EventArgs e)
        {

            ExamDisplay _addNewExam = new ExamDisplay(ViewType.Create);
            _addNewExam.ShowDialog();
        }

        private void 测试建立数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder ssb = new SqlConnectionStringBuilder();
            ssb.DataSource = @"192.168.1.70";
            ssb.UserID = @"zhangkai365";
            ssb.Password = @"@Zhangkai851983";

            string testconnection = @"Data Source = 192.168.1.70; User ID = zhangkai365; Password = @Zhangkai851983; Initial Catalog = engchaosheng;";
            SqlConnection testConnection = new SqlConnection(testconnection);
            testConnection.Open();
            MessageBox.Show(testconnection);
        }

        private void Menu_DataBaseManagement_Click(object sender, EventArgs e)
        {
            Form_DataBaseManagement mnForm_DataBaseManagement = new Form_DataBaseManagement();
            mnForm_DataBaseManagement.ShowDialog();
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TestUnit mnForm_TestUnit = new Form_TestUnit();
            mnForm_TestUnit.ShowDialog();
        }

        public void ShowAppiontment()
        {
            DataSet AppiontmentToday = new DataSet("AppiontmentToday");
            //建立相应的dataColumn
            DataColumn Column_Index = new DataColumn("Index", typeof(int));
            Column_Index.Caption = "序号";
            Column_Index.ReadOnly = true;

            DataColumn Column_PatientName = new DataColumn("PatientName", typeof(string));
            Column_PatientName.Caption = "姓名";
            Column_PatientName.ReadOnly = true;

            DataColumn Column_Sex = new DataColumn("Sex", typeof(string));
            Column_Sex.Caption = "性别";
            Column_Sex.ReadOnly = true;

            DataColumn Column_Age = new DataColumn("Age", typeof(int));
            Column_Age.Caption = "年龄";
            Column_Age.ReadOnly = true;

            DataColumn Column_AppiontmentTime = new DataColumn("AppiontmentTime", typeof(DateTime));
            Column_AppiontmentTime.Caption = "预约时间";
            Column_AppiontmentTime.ReadOnly = true;

        }
    }
}
