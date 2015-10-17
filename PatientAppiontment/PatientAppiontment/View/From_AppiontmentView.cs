using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientAppointment.View
{
    public partial class From_AppiontmentView : Form
    {
        public From_AppiontmentView()
        {
            InitializeComponent();
        }

        private void From_AppiontmentView_Load(object sender, EventArgs e)
        {
            DataSet AppiontmentToday = new DataSet("AppiontmentToday");
            //建立相应的dataColumn
            DataColumn Column_Index = new DataColumn("Index",typeof(int)); 
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
