using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientAppiontment.Common
{

    public interface ICheckInput
    {
        /// <summary>
        /// 检查输入
        /// </summary>
        CheckResult Check(string inputValue);
    }
}
