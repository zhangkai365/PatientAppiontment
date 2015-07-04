using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//include
using PatientAppointment.DataPackage;
using PatientAppointment.ServiceData;
using PatientAppointment.Common;

namespace PatientAppointment.Control
{
    class PatientCheck
    {
        public Status Create()
        {
            PatientCheckCreate mnPatientCheckCreate = new PatientCheckCreate();
            DataPackPatientCheck mnDataPackPatientCheck = new DataPackPatientCheck()
            {
                ArchiveCode = "201506210002",
                CheckCode = "1",
                ReDiagnosisTimes = 0,
                DiagnosisDevice = "Philips IU22",
                Origin = "住院",
                CheckPart = "腹部+双肾",
                CheckPrice = 250,
                HospitalizedNum = "",
                SickbedNum = "29",
                ClinicalOffice = "10B",
                BookinDoctor = "刘苏筠",
                CheckDoctor = "",
                ClinicalDiagnosis = "", 
                PatientDictation = "",
                Findings = "",
                Prompt = "",
                BookinDate = DateTime.Today,
                CheckDate = DateTime.Today.AddDays(1),
                PositiveSymbol = 3,
                DoctorDictation = "",
                Report = "",
                PrintSymbol = 0,
                ExportSymbol = 0,
                Remark = "",
                ListNum = "",
                DictationName = "",
                ReportName = "",
                States = "预约后",
                Clinicians = "孔晓东",
                Appointment = DateTime.Today.AddDays(1),
                Reservationnum = 1,
                Priority = "默认",
                RoomName = "",
                groups = "",
                ordering = 1,
                Free = 1,
                PatientGroup = "B超室1",
                code = "",
                disease = "",
                Category = "",
                tipofabstract = "",
                diagnosis = "",
                PatientPriority = 1
            };
            return mnPatientCheckCreate.Create(mnDataPackPatientCheck);
        }

        public bool Updata()
        {
            return false;
        }

        public bool Delete()
        {
            return true;
        }
    }
}
