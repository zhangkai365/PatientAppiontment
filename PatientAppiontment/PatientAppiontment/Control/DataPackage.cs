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

        /// <summary>
        /// 超声—腹部
        /// </summary>
        public ExamItem Abdominal;
        /// <summary>
        /// 超声—心脏
        /// </summary>
        public ExamItem Heart;
        /// <summary>
        /// 超声—颈部血管
        /// </summary>
        public ExamItem CervicalVascular;
        /// <summary>
        /// 超声—甲状腺
        /// </summary>
        public ExamItem Thyrod;
        /// <summary>
        /// 超声—下肢动脉
        /// </summary>
        public ExamItem LowerExtremityArtery;
        /// <summary>
        /// 超声—下肢静脉
        /// </summary>
        public ExamItem LowerExtremityVein;
        /// <summary>
        /// 胸腔
        /// </summary>
        public ExamItem ThoracicCavity;

        public ExamItem Urinary;
        public ExamItem ResidualUrine;
        public ExamItem LymphNode;
        public ExamItem Others;

        public ExamItem Holter;
        public ExamItem TCD;
        public ExamItem HeartFunction;
        public ExamItem Arteriosclerosis;

        public ExamItem PulFuc_Respiratory;
        public ExamItem PulFuc_Diffusion;
        public ExamItem BMD;
        public ExamItem EEG;
    }
}
