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
    class TestPatientRecords
    {
        /// <summary>
        /// 测试写入数据库的类
        /// </summary>
        public void TestCreate()
        {
            Status resultTest = new Status()
            {
                index = "",
                codeSnippetName = "",
                result = Result.Initial,
                message = ""
            };
            DataPackPatientRecords testDataPackPatientRecord = new DataPackPatientRecords()
            {
                ArchiveCode = "201507180005",
                PatientName = "张凯",
                Sex = "男",
                Age = 20,
                AgeSymbol = "岁",
                PrintSymbol = "0",
                States = "未检查",
                Contacts = "",
                InsuranceNum = "",
                FoundDate = DateTime.Now.Date.ToString("yyyy/MM/dd"),
                MarriageState = "0",
                PregnancyTimes = 0,
                ProcreationTimes = 0,
                Remark = "",
                ModifyTimes = "0",
                Stuff = ""
            };
            ServiceData.PatientRecords mnServiceDataPatientRecords = new PatientRecords();
            resultTest = mnServiceDataPatientRecords.Create(testDataPackPatientRecord);
            //Show the test Result
            System.Windows.Forms.MessageBox.Show("index:"+ resultTest.index + "\n" + "CodeSnippetName:" + resultTest.codeSnippetName + "\n" + "Result:" + resultTest.result.ToString() + "\n" + "Message:" + resultTest.message);
        }

        public void TestUpDate()
        {
            Status resultTest = new Status()
            {
                index = "",
                codeSnippetName = "",
                result = Result.Initial,
                message = ""
            };
            DataPackPatientRecords mnDataPackPatientRecord = new DataPackPatientRecords()
            {
                ArchiveCode = "201507180001",
                PatientName = "张凯Update",
                Sex = "男",
                Age = 30,
                AgeSymbol = "岁",
                PrintSymbol = "0",
                States = "已检查",
                Contacts = "",
                InsuranceNum = "",
                FoundDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"),
                MarriageState = "0",
                PregnancyTimes = 0,
                ProcreationTimes = 0,
                Remark = "",
                ModifyTimes = "0",
                Stuff = ""
            };
            ServiceData.PatientRecords mnServiceDataPatientRecords = new PatientRecords();
            resultTest = mnServiceDataPatientRecords.Update(mnDataPackPatientRecord);
            System.Windows.Forms.MessageBox.Show("index:" + resultTest.index + "\n" + "CodeSnippetName:" + resultTest.codeSnippetName + "\n" + "Result:" + resultTest.result.ToString() + "\n" + "Message:" + resultTest.message);
        }

        public void TestDelete()
        {
            Status resultTest = new Status()
            {
                index = "",
                codeSnippetName = "",
                result = Result.Initial,
                message = ""
            };
            ServiceData.PatientRecords mnServiceDataPatientRecords = new PatientRecords();
            string deleteArciveCode = "201507180004";
            resultTest =  mnServiceDataPatientRecords.Delete(deleteArciveCode);
            System.Windows.Forms.MessageBox.Show("index:" + resultTest.index + "\n" + "CodeSnippetName:" + resultTest.codeSnippetName + "\n" + "Result:" + resultTest.result.ToString() + "\n" + "Message:" + resultTest.message);
        }
    }
}
