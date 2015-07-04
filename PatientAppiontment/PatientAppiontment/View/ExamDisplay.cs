using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Project Include
using PatientAppointment.Common;
using PatientAppointment.DataBase;
using PatientAppointment.Control;
using System.Data.SqlClient;
using PatientAppointment.DataPackage;

namespace PatientAppointment.View
{
    public partial class ExamDisplay : Form
    {
        /// <summary>
        /// 视窗的显示模式
        /// </summary>
        private ViewType _viewType = ViewType.Initial;
        private DataPackPatientCheck _packageExam;

        public ExamDisplay(ViewType mnViewType)
        {
            InitializeComponent();
            _viewType = mnViewType; 
        }

        private void btn_Confrom_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 以添加新记录模式初始化窗体
        /// </summary>
        public void AddNewExamInitialize()
        {
            GetArchiveCode mnGetArchiveCode = new GetArchiveCode();
            string _ExamArchiveCode = "";
            Status _Result_GetArchiveCode = mnGetArchiveCode.Get(out _ExamArchiveCode);
            //成功获取患者编号
            if (_Result_GetArchiveCode.result == Result.Success)
            {
                lab_PatientArchiveCode.Text = _ExamArchiveCode;
                _packageExam.ArchiveCode = _ExamArchiveCode;
            }
            if (_Result_GetArchiveCode.result != Result.Success)
            {
                MessageBox.Show("获取患者编号出现问题!\n" + _Result_GetArchiveCode.codeSnippetName + "\n" + _Result_GetArchiveCode.result.ToString() + "\n" + _Result_GetArchiveCode.message + "\n" + _Result_GetArchiveCode.index);
                this.Close();
            }
        }

        


    }
}
