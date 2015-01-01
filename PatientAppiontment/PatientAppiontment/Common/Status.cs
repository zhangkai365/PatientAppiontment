using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientAppiontment.Common
{
    public enum Result
    {
        Fail = 0,
        Success = 1,
        Warning = 2
    }
    public class Status
    {
        /// <summary>
        /// 执行的代码片段名称
        /// </summary>
        public string CodeSnippetName;
        /// <summary>
        /// 运行结果
        /// </summary>
        public Result result;
        /// <summary>
        /// 默认的信息
        /// </summary>
        public string Message;
        /// <summary>
        /// 信息字典编号
        /// </summary>
        public string MesgDicIndex;
    }
}
