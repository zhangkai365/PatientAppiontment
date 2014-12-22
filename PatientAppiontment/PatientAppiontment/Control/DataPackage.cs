using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientAppiontment.Control
{
    public struct ExamItem
    {
        public bool hasReservation;
        public DateTime ReservationDateTime;

    }

    public class DataPackage
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string PatientName
        {
            get;
            set;
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string PatientSex
        {
            get;
            set;
        }
        /// <summary>
        /// 年龄
        /// </summary>
        public int PatientAge
        {
            get;
            set;
        }
        /// <summary>
        /// 楼层
        /// </summary>
        public string PatientFloor
        {
            get;
            set;
        }
        /// <summary>
        /// 床号
        /// </summary>
        public string PatientBedNum
        {
            get;
            set;
        }
        /// <summary>
        /// 送诊医师
        /// </summary>
        public string PatientDoctor
        {
            get;
            set;
        }

        public ExamItem Abdominal;
        public ExamItem Heart;
        public ExamItem CervicalVascular;
        public ExamItem Thyrod;
        public ExamItem LowerExtremityArtery;
        public ExamItem LowerExtremityVein;
        public ExamItem ThoracicCavity;
        public ExamItem Urinary;
        public ExamItem ResidualUrine;
        public ExamItem LymphNode;
        public ExamItem Others;
    }
}
