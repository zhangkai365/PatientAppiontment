using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Project Include
using PatientAppiontment.Common;
using PatientAppiontment.Data;
using PatientAppiontment.Control;
using System.Data.SqlClient;

namespace PatientAppiontment.View
{
    public partial class ExamDisplay : Form
    {
        /// <summary>
        /// 视窗的显示模式
        /// </summary>
        private ViewType _viewType = ViewType.Initial;
        private PackageExam _packageExam = new PackageExam();

        public ExamDisplay(ViewType mnViewType)
        {
            InitializeComponent();
            _viewType = mnViewType; 
        }

        private void btn_Confrom_Click(object sender, EventArgs e)
        {
            CheckInput();
        }

        /// <summary>
        /// 检查输入
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            bool _CheckResultAllNecessary = false;
            //检查输入——患者姓名
            checkInput_PatientName _CheckInput_PatientName = new checkInput_PatientName();
            CheckResult _CheckResult_PatientName = _CheckInput_PatientName.Check(txt_PatientName.Text);
            if (_CheckResult_PatientName.Result == false)
            {
                ToolTip Tip_PatientName = new ToolTip();
                Tip_PatientName.Show(_CheckResult_PatientName.Tips,txt_PatientName,3000);
            }
            //检查输入——患者性别
            checkInput_Sex _CheckInput_Sex = new checkInput_Sex();
            if (cmb_PatientSex.SelectedItem == null)
            {
                ToolTip Tip_Sex = new ToolTip();
                Tip_Sex.Show("选择患者的性别！", cmb_PatientSex, 3000); 
            }
            else
            {
                CheckResult _CheckResult_Sex = _CheckInput_Sex.Check(cmb_PatientSex.SelectedItem.ToString());
                if (_CheckResult_Sex.Result == false)
                {
                    ToolTip Tip_Sex = new ToolTip();
                    Tip_Sex.Show(_CheckResult_Sex.Tips, cmb_PatientSex, 3000);
                }
            }
            //检查输入——患者年龄

            return _CheckResultAllNecessary;
        }

        public bool InsertIntoDatabase()
        {
            bool Result_InsertIntoDatabase = false;
            return Result_InsertIntoDatabase;
        }

        public void UpdataUI()
        {
            
        }

        /// <summary>
        /// 窗体加载时候的初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExamDisplay_Load(object sender, EventArgs e)
        {
            switch (_viewType)
            {
                case ViewType.Create:
                    AddNewExamInitialize();break;
                case ViewType.Update:
                    ModifyExamInitialize();break;
                default:
                    MessageBox.Show(" CodeSnippetName : View>>ExamDisplay>>ExamDisplay_Load\n Message : The initial process of ExamDisplay is not correct.");
                    this.Close();
                    break;
            }
        }

        public void AddNewExamInitialize()
        {
            GetArchiveCode mnGetArchiveCode = new GetArchiveCode();
            lab_PatientArchiveCode.Text = mnGetArchiveCode.Get();  
        }

        public void ModifyExamInitialize()
        {
 
        }

    }
}
