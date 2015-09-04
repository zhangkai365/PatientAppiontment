using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientAppointment.ServiceDataCheck
{
    /// <summary>
    /// 输入数据检查的返回类，包括结果和消息
    /// </summary>
    public class CheckResult
    {
        /// <summary>
        /// 结果
        /// </summary>
        public bool result;
        /// <summary>
        /// 消息
        /// </summary>
        public string Message;
    }
}
