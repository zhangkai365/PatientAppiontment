using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientAppiontment.Common
{

    public interface ICheckInput_string
    {
        /// <summary>
        /// 检查输入
        /// </summary>
        CheckResult Check(string inputString);
    }

    public interface ICheckInput_int
    {
        CheckResult Check(int inputInt);
    }

}
