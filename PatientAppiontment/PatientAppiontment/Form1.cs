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
            myConnection.ConnectionString = AppConnection.UltraSoundDataBaseConnectionString;
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

        public void ReadPatient()
        {
            DateTime viewDate = new DateTime();
            viewDate = dateTimePicker1.Value.Date;
            DataSetPatientRecord _dataSetPatientRecord = new DataSetPatientRecord();
            SqlDataAdapter _dataAdapterArchiveCode = new SqlDataAdapter("Select [ArchiveCode] FROM [PatientCheck] WHERE [BookinDate]='"+ viewDate + "'", AppConnection.UltraSoundDataBaseConnectionString);
            _dataAdapterArchiveCode.Fill(_dataSetPatientRecord);
            DataView myDataView = new DataView(_dataSetPatientRecord.PatientCheck);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadPatientCheck();
        }

        public void ReadPatientCheck()
        {
            DateTime viewDate = new DateTime();
            viewDate = dateTimePicker1.Value.Date;
            string commandText = @"SELECT [ArchiveCode],[CheckCode],[ReDiagnosisTimes],[DiagnosisDevice],[Origin] FROM [dbo].[PatientCheck] WHERE [BookinDate] = '"+ viewDate + @"'";
            SqlConnection cn = new SqlConnection(AppConnection.UltraSoundDataBaseConnectionString);
            cn.Open();
            SqlCommand mnSqlCommand = new SqlCommand(commandText,cn);
            SqlDataReader mnDataReader = mnSqlCommand.ExecuteReader();
            List<mnTablePatientCheck> mnListTablePatientCheck = new List<mnTablePatientCheck>();
            while (mnDataReader.Read())
            {
                mnListTablePatientCheck.Add(new mnTablePatientCheck() { 
                    ArchiveCode = mnDataReader.GetString(0), 
                    CheckCode = mnDataReader.GetString(1),
                    ReDiagnosisTimes = mnDataReader.GetInt32(2),
                    DiagnosisDevice = mnDataReader.GetString(3),
                    Origin = mnDataReader.GetString(4)
                });
            }
            cn.Close();
            
            //ColumnHeader[] CH = new ColumnHeader[5];
            //CH[0].Text = @"ArchiveCode";
            //CH[1].Text = @"CheckCode";
            //CH[2].Text = @"ReDiagnosisTimes";
            //CH[3].Text = @"DiagnosisDevice";
            //CH[4].Text = @"Origin";
            //listView1.Columns.AddRange(CH);
            //ListViewItem[] LV = new ListViewItem[5];
            listView1.GridLines = true;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add(@"Index");
            listView1.Columns.Add(@"ArchiveCode");
            listView1.Columns.Add(@"CheckCode");
            listView1.Columns.Add(@"ReDiagnosisTimes");
            listView1.Columns.Add(@"DiagnosisDevice");
            listView1.Columns.Add(@"Origin");

            int recordNum = mnListTablePatientCheck.Count();
            label2.Text = recordNum.ToString();
            for (int i = 0; i < mnListTablePatientCheck.Count; i++)
            {
                ListViewItem tempItem = new ListViewItem();
                tempItem.Text = i.ToString();
                tempItem.SubItems.Add(mnListTablePatientCheck[i].ArchiveCode.ToString());
                tempItem.SubItems.Add(mnListTablePatientCheck[i].CheckCode.ToString());
                tempItem.SubItems.Add(mnListTablePatientCheck[i].ReDiagnosisTimes.ToString());
                tempItem.SubItems.Add(mnListTablePatientCheck[i].DiagnosisDevice.ToString());
                tempItem.SubItems.Add(mnListTablePatientCheck[i].Origin.ToString());
                listView1.Items.Add(tempItem);
            }
        }

        private void btn_AddNewExam_Click(object sender, EventArgs e)
        {
            AddNewExam _addNewExam = new AddNewExam();
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


    }
}
