using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//include
using PatientAppointment.Common;
using PatientAppointment.DataPackage;
using PatientAppointment.ServiceData;

namespace PatientAppointment.TestUnit
{
    class TestPatientCheck
    {
        /// <summary>
        /// 测试创建患者检查
        /// </summary>
        /// <returns>返回测试结果</returns>
        public Status TestCreate()
        {
            PatientCheck mnServiceDataPatientCheck = new PatientCheck();
            DataPackPatientCheck mnDataPackPatientCheck = new DataPackPatientCheck() { ArchiveCode = "201507180001" };

            return new Status();
        }

        /// <summary>
        /// 测试更新患者检查
        /// </summary>
        /// <returns></returns>
        public Status TestUpdate()
        {
            return new Status();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Status TestDelete()
        {
            return new Status();
        }
    }
}
