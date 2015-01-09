using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Project Include
using PatientAppiontment.Common;

namespace PatientAppiontment.Data
{
    public class PackageExam
    {
        public string ArchiveCode;
        public string PatientName;
        public string Sex;
        public int Age;
        public string AgeSymbol;
        DateTime FoundDate;

        public PackageExam()
        {
            ArchiveCode = @"9201501010001";
            PatientName = @"";
            Sex = @"";
            Age = 0;
            AgeSymbol = @"岁";
            FoundDate = new DateTime(2015,1,1);
        }

    }

    /// <summary>
    /// 检查ArchiveCode
    /// </summary>
    public class chekInput_ArchiveCode : ICheckInput
    {
        public CheckResult Check(string checkArchiveCode) 
        {
            CheckResult _checkResult = new CheckResult() { 
                Result = false, 
                Tips = "Initial", 
                Necessary = true };
            _checkResult.Result = true;
            _checkResult.Tips = "Correct";
            return _checkResult;
        }
    }
    /// <summary>
    /// 检查患者姓名
    /// 规则：不能为空（目前，将来加入字符串的识别）
    /// </summary>
    public class checkInput_PatientName : ICheckInput
    {
        public CheckResult Check(string PatientName)
        {
            CheckResult _CheckResult_PatientName = new CheckResult() { 
                Result = false,
                Tips = "Initial",
                Necessary = true };
            if (PatientName == string.Empty)
            {
                _CheckResult_PatientName.Result = false;
                _CheckResult_PatientName.Tips = "姓名不能为空！";
            }
            if (PatientName != string.Empty)
            {
                _CheckResult_PatientName.Result = true;
                _CheckResult_PatientName.Tips = "输入正确";
            }
            return _CheckResult_PatientName;
        }
    }
    /// <summary>
    /// 检查性别
    /// 规则：只能为男或者女（目前，将来加入其它）
    /// </summary>
    public class checkInput_Sex : ICheckInput
    {

        public CheckResult Check(string inputValue)
        {
            CheckResult _CheckResult_Sex = new CheckResult() { 
                Result = false, 
                Tips = "Initial", 
                Necessary = true };
            if (inputValue == string.Empty)
            {
                _CheckResult_Sex.Tips = "还没有选择性别";
            }
            if (inputValue == "男" || inputValue == "女")
            {
                _CheckResult_Sex.Result = true;
                _CheckResult_Sex.Tips = "Correct Input.";
            }
            return _CheckResult_Sex;
        }
    }

    public class checkInput_PackageExam
    {
        public bool ArchiveCode;
        public string Tip_ArchiveCode;

        public bool PaitentName;
        public string Tip_PatientName;

        public bool Sex;
        public string Tip_Sex;

        public bool Age;
        public string Tip_Age;

        public bool AgeSymbol;
        public string Tip_AgeSymbol;

        public bool FoundDate;
        public string Tip_FoundDate;

        private bool Rule_ArchiveCode(string check_ArchiveCode)
        {
            return true;
        }


        public bool Check(PackageExam mnPackageExam)
        {
            bool CheckResult = false;
            bool CheckArchiveCode = Rule_ArchiveCode(mnPackageExam.ArchiveCode);

            return CheckResult;
        }
    }
}
