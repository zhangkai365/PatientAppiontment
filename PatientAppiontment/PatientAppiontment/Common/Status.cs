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
        Error = 2,
        Initial = 9
    }
    public enum Existence
    {
        No = 0,
        Yes = 1,
        Unknown = 2,
        Initial = 9
    }

    public class Status
    {
        /// <summary>
        /// 执行的代码片段名称
        /// </summary>
        public string codeSnippetName;
        /// <summary>
        /// 运行结果
        /// </summary>
        public Result result;
        /// <summary>
        /// 默认的信息
        /// </summary>
        public string message;
        /// <summary>
        /// 信息字典编号
        /// </summary>
        public string index;
    }

    public class Status_Existence
    {
        public string codeSnippetName;
        public Existence exsitence;
        public string message;
        public string index;
    }

}
