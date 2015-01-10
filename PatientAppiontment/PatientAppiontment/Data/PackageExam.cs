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
        //编号
        public string ArchiveCode;
        public bool Checked_ArchiveCode;
        //姓名
        public string PatientName;
        public bool Checked_PatientName;
        //性别
        public string Sex;
        public bool Checked_Sex;
        //年龄
        public int Age;
        public bool Checked_Age;
        //年龄单位
        public string AgeSymbol;
        public bool Checked_AgeSymbol;
        //楼层
        public string PatientFloor;
        public bool Checked_PatientFloor;
        //床号
        public string PatientBedNum;
        public bool Checked_PatientBedNum;
        //送诊医师
        public string PatientDoctor;
        public bool Checked_PatientDoctor;

        DateTime FoundDate;
        //默认的构造函数
        //全部赋值为阴性值
        public PackageExam()
        {
            ArchiveCode = "9201501010001";
            Checked_ArchiveCode = false;

            PatientName = "";
            Checked_PatientName = false;

            Sex = "";
            Checked_Sex = false;

            Age = 0;
            Checked_Age = false;

            AgeSymbol = "岁";
            Checked_AgeSymbol = false;

            PatientFloor = "";
            Checked_PatientFloor = false;

            PatientBedNum = "";
            Checked_PatientBedNum = false;

            PatientDoctor = "";
            Checked_PatientDoctor = false;

            //建立时间以服务器时间为基准
            FoundDate = new DateTime(2015,1,1);
        }

    }

}
