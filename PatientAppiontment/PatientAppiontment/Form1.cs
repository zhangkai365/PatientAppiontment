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
using PatientAppiontment.Data;
using PatientAppiontment.View;

namespace PatientAppiontment
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
            listBox1.Items.Clear();
            myConnection.ConnectionString = @"Data Source = 192.168.1.70; Initial Catalog = engchaosheng; user id = zhangkai365; password = @Zhangkai851983;";
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
                listBox1.Items.Add(myDataReader.GetSqlDateTime(0).ToString());
                myDataTable.Rows.Add(myDataTable.NewRow()["FoundDate"] = myDataReader.GetSqlDateTime(0).ToString());
            }
            myConnection.Close();
            dataReadTime.Stop();
            label1.Text = dataReadTime.ElapsedMilliseconds.ToString();
            myDataSet.Tables.Add(myDataTable);
            DataView dataViewSource = new DataView(myDataTable);
            dataGridView1.DataSource = dataViewSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartConnectiont();
        }

        public class PatientRecords
        {
            string ArchiveCode;
            string PatientName;
            string Sex;
            int Age;
            DateTime FoundDate;
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
            //连接字符串初始化
            ConnectionString _connectionString = new ConnectionString();
            _connectionString.Initial();
        }


    }
}
