using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using PatientAppiontment.Data;

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


    }
}
