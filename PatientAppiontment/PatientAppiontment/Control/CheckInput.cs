using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Project Include
using PatientAppointment.Common;

namespace PatientAppointment.Control
{
    class CheckInput
    {
    }

    /// <summary>
    /// 检查ArchiveCode
    /// </summary>
    public class CheckInput_ArchiveCode : ICheckInput_string
    {
        public CheckResult Check(string checkArchiveCode)
        {
            CheckResult _checkResult = new CheckResult()
            {
                Result = false,
                Tips = "Initial",
                Necessary = true
            };
            _checkResult.Result = true;
            _checkResult.Tips = "Correct";
            return _checkResult;
        }
    }
    /// <summary>
    /// 检查患者姓名
    /// 规则：不能为空（目前，将来加入字符串的识别）
    /// </summary>
    public class CheckInput_PatientName : ICheckInput_string
    {
        public CheckResult Check(string PatientName)
        {
            CheckResult _CheckResult_PatientName = new CheckResult()
            {
                Result = false,
                Tips = "Initial",
                Necessary = true
            };
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
    public class CheckInput_Sex : ICheckInput_string
    {

        public CheckResult Check(string inputValue)
        {
            CheckResult _CheckResult_Sex = new CheckResult()
            {
                Result = false,
                Tips = "Initial",
                Necessary = true
            };
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
    /// <summary>
    /// 检查年龄
    /// 规则：只能在0-120岁之间
    /// </summary>
    public class CheckInput_Age : ICheckInput_int
    {
        public CheckResult Check(int inputInt)
        {
            CheckResult _checkResult_Age = new CheckResult() {
                Result = false,
                Tips = "Initial", 
                Necessary = true };
            if (inputInt <= 0 || inputInt >= 120)
            {
                _checkResult_Age.Tips = "年龄输入错误！年龄在0-120岁之间。";
            }
            if (inputInt > 0 && inputInt < 120)
            {
                _checkResult_Age.Result = true;
                _checkResult_Age.Tips = "Correct Age.";
            }
            return _checkResult_Age;
        }
    }
}
