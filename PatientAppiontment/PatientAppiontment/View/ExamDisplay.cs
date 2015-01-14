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
            if (isAllChecked())
            {
                MessageBox.Show("写入数据库！");
                Exam_Add exam_Add = new Exam_Add();
                //将数据写入数据库
                Status result_ExamAdd = exam_Add.AddToDatabase(_packageExam);
                MessageBox.Show("SnappetCodeName:" + result_ExamAdd.codeSnippetName + "\n" + "Result:" + result_ExamAdd.result.ToString() + "\n" + "Message:" + result_ExamAdd.message + "\n" + result_ExamAdd.index);
            }
        }

        /// <summary>
        /// 检查输入
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            bool _CheckResultAllNecessary = false;
            //检查患者编号,目前无检查规则
            _packageExam.Checked_ArchiveCode = true;
            //检查输入——患者姓名
            CheckInput_PatientName _CheckInput_PatientName = new CheckInput_PatientName();
            CheckResult _CheckResult_PatientName = _CheckInput_PatientName.Check(txt_PatientName.Text);
            if (_CheckResult_PatientName.Result == false)
            {
                ToolTip Tip_PatientName = new ToolTip();
                Tip_PatientName.Show(_CheckResult_PatientName.Tips,txt_PatientName,3000);
            }
            if (_CheckResult_PatientName.Result == true)
            {
                _packageExam.Checked_PatientName = true;
                _packageExam.PatientName = txt_PatientName.Text;
            }

            //检查输入——患者性别
            CheckInput_Sex _CheckInput_Sex = new CheckInput_Sex();
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
                if (_CheckResult_Sex.Result == true)
                {
                    _packageExam.Checked_Sex = true;
                    _packageExam.Sex = cmb_PatientSex.SelectedItem.ToString();
                }
            }

            //检查输入—患者年龄
            //检查有无输入，提示—请输入年龄
            if (txt_PatientAge.Text == string.Empty)
            {
                ToolTip Tip_Age = new ToolTip();
                Tip_Age.Show("请输入年龄！", txt_PatientAge, 3000);
            }
            else
            {
                //检查是否输入的是数字（有可能是字母），提示—请输入数字
                int age = 0;
                bool result_Parse = int.TryParse(txt_PatientAge.Text,out age);
                if (result_Parse == false)
                {
                    ToolTip Tip_Age_NotNumber = new ToolTip();
                    Tip_Age_NotNumber.Show("请输入数字！", txt_PatientAge, 3000);
                }
                //检查输入的数字是否在范围内（0-120岁），提示——请输入0-120岁的数字
                if (result_Parse == true)
                {
                    CheckInput_Age _CheckInput_Age = new CheckInput_Age();
                    CheckResult _CheckResult_Age = _CheckInput_Age.Check(age);
                    if (_CheckResult_Age.Result == false)
                    {
                        ToolTip Tip_Age_OutofRange = new ToolTip();
                        Tip_Age_OutofRange.Show(_CheckResult_Age.Tips, txt_PatientAge, 3000);
                    }
                    if (_CheckResult_Age.Result == true)
                    {
                        //将转换过的值赋给PackageExam
                        _packageExam.Checked_Age = true;
                        _packageExam.Age = age;
                    }
                }
                //其他不需要检查的变量，直接赋值为True
                //年龄类型
                _packageExam.AgeSymbol = "岁";
                _packageExam.Checked_AgeSymbol = true;
                //楼层,注意使用combox时要注意里面可能什么都没有选择
                if (cmb_PatientFloor.SelectedItem != null)
                {
                    _packageExam.PatientFloor = cmb_PatientFloor.SelectedItem.ToString();
                }
                if (cmb_PatientFloor.SelectedItem == null)
                {
                    _packageExam.PatientFloor = "";
                }
                _packageExam.Checked_PatientFloor = true;
                //床号
                _packageExam.PatientBedNum = txt_PatientBedNum.Text;
                _packageExam.Checked_PatientBedNum = true;
                //送诊医师，注意使用combox时要注意里面可能什么都没有选择
                if (cmb_PatientDoctor.SelectedItem != null)
                {
                    _packageExam.PatientDoctor = cmb_PatientDoctor.SelectedItem.ToString();
                }
                if (cmb_PatientDoctor.SelectedItem == null)
                {
                    _packageExam.PatientDoctor = "";
                }
                _packageExam.Checked_PatientDoctor = true;
            }

            //检查所有项目结束
            return _CheckResultAllNecessary;
        }

        /// <summary>
        /// 是否全部的输入项目都已经通过检查
        /// </summary>
        /// <returns></returns>
        public bool isAllChecked()
        {
            bool _isAllChecked = false;
            if (_packageExam.Checked_ArchiveCode == true &&
                _packageExam.Checked_PatientName == true && 
                _packageExam.Checked_Sex == true && 
                _packageExam.Checked_Age == true && 
                _packageExam.Checked_AgeSymbol == true && 
                _packageExam.Checked_PatientFloor == true && 
                _packageExam.Checked_PatientBedNum == true &&
                _packageExam.Checked_PatientDoctor == true ) _isAllChecked = true;
            return _isAllChecked;
        }

        /// <summary>
        /// 将数据写入数据库
        /// </summary>
        /// <returns></returns>
        public bool InsertIntoDatabase()
        {
            bool Result_InsertIntoDatabase = false;
            return Result_InsertIntoDatabase;
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

        /// <summary>
        /// 以添加新记录模式初始化窗体
        /// </summary>
        public void AddNewExamInitialize()
        {
            GetArchiveCode mnGetArchiveCode = new GetArchiveCode();
            lab_PatientArchiveCode.Text = mnGetArchiveCode.Get();  
        }
        /// <summary>
        /// 以修改记录模式初始化窗体
        /// </summary>
        public void ModifyExamInitialize()
        {
 
        }

    }
}
