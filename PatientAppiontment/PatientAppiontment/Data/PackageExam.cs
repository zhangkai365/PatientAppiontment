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

}
