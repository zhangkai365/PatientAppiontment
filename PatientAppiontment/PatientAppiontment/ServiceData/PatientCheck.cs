using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//include
using System.Data.SqlClient;
using PatientAppointment.DataBase;
using PatientAppointment.Common;
using PatientAppointment.DataPackage;

namespace PatientAppointment.ServiceData
{
    class PatientCheck
    {
        /// <summary>
        /// 新建记录到数据库
        /// </summary>
        /// <param name="mnDataPackPatientCheck">记录格式的数据包</param>
        /// <returns></returns>
        public Status Create(DataPackPatientCheck mnDataPackPatientCheck)
        {
            Status DataBaseCreate = new Status()
            {
                result = Result.Initial,
                codeSnippetName = "DataService.PatientCheckCreate.Create",
                index = "DS.10001",
                message = "DataService-PatientCheckCreate-intial"
            };
            SqlConnection UltrasoundConnection = new SqlConnection(DataBaseConnection.UltraSoundConnectionString);
            SqlConnection AppointmentConnection = new SqlConnection(DataBaseConnection.AppointmentConnectionString);
            //写入语句，和参变量
            string cmdAdd = "Insert Into [PatientCheck] (" +
                "ArchiveCode," +
                "CheckCode," +
                "ReDiagnosisTimes," +
                "DiagnosisDevice," +
                "Origin," +
                "CheckPart," +
                "CheckPrice," +
                "HospitalizedNum," +
                "SickbedNum," +
                "ClinicalOffice," +
                "BookinDoctor," +
                "CheckDoctor," +
                "ClinicalDiagnosis," +
                "PatientDictation," +
                "Findings," +
                "Prompt," +
                "BookinDate," +
                "CheckDate," +
                "PositiveSymbol," +
                "DoctorDictation," +
                "Report," +
                "PrintSymbol," +
                "ExportSymbol," +
                "Remark," +
                "ListNum," +
                "DictationName," +
                "ReportName," +
                "States," +
                "Clinicians," +
                "Appointment," +
                "ReservationNum," +
                "Priority," +
                "RoomName," +
                "groups," +
                "ordering," +
                "Free," +
                "PatientGroup," +
                "code," +
                "disease," +
                "Category," +
                "tipsofabstract," +
                "diagnosis," +
                "PatientPriority" +
                ")" +
                " Values (" +
                "@ArchiveCode," +
                "@CheckCode," +
                "@ReDiagnosisTimes," +
                "@DiagnosisDevice," +
                "@Origin," +
                "@CheckPart," +
                "@CheckPrice," +
                "@HospitalizedNum," +
                "@SickbedNum," +
                "@ClinicalOffice," +
                "@BookinDoctor," +
                "@CheckDoctor," +
                "@ClinicalDiagnosis," +
                "@PatientDictation," +
                "@Findings," +
                "@Prompt," +
                "@BookinDate," +
                "@CheckDate," +
                "@PositiveSymbol," +
                "@DoctorDictation," +
                "@Report," +
                "@PrintSymbol," +
                "@ExportSymbol," +
                "@Remark," +
                "@ListNum," +
                "@DictationName," +
                "@ReportName," +
                "@States," +
                "@Clinicians," +
                "@Appointment," +
                "@Reservationnum," +
                "@Priority," +
                "@RoomName," +
                "@groups," +
                "@Ordering," +
                "@Free," +
                "@PatientGroup," +
                "@Code," +
                "@disease," +
                "@Category," +
                "@tipsofabstract," +
                "@diagnosis," +
                "@PatientPriority" +
                ")";
            //写入语句
            SqlCommand cmdSql = new SqlCommand(cmdAdd, UltrasoundConnection);
            //填充参数集合
            //患者序号
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ArchiveCode";
            param.Value = mnDataPackPatientCheck.ArchiveCode;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            param.Size = 50;
            cmdSql.Parameters.Add(param);
            //Checkcode
            param = new SqlParameter();
            param.ParameterName = "@CheckCode";
            param.Value = mnDataPackPatientCheck.CheckCode;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            param.Size = 50;
            cmdSql.Parameters.Add(param);
            //ReDiagnosisTimes
            param = new SqlParameter();
            param.ParameterName = "@RediagnosisTimes";
            param.Value = mnDataPackPatientCheck.ReDiagnosisTimes;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //DiagnosisDevice
            param = new SqlParameter();
            param.ParameterName = "@DiagnosisDevice";
            param.Value = mnDataPackPatientCheck.DiagnosisDevice;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Origin
            param = new SqlParameter();
            param.ParameterName = "@Origin";
            param.Value = mnDataPackPatientCheck.Origin;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //CheckPart
            param = new SqlParameter();
            param.ParameterName = "@CheckPart";
            param.Value = mnDataPackPatientCheck.CheckPart;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //CheckPrice
            param = new SqlParameter();
            param.ParameterName = "@CheckPrice";
            param.Value = mnDataPackPatientCheck.CheckPrice;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //HospitalizedNum
            param = new SqlParameter();
            param.ParameterName = "@HospitalizedNum";
            param.Value = mnDataPackPatientCheck.HospitalizedNum;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //SickbedNum
            param = new SqlParameter();
            param.ParameterName = "@SickbedNum";
            param.Value = mnDataPackPatientCheck.SickbedNum;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ClinicalOffice
            param = new SqlParameter();
            param.ParameterName = "@ClinicalOffice";
            param.Value = mnDataPackPatientCheck.ClinicalOffice;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //BookinDoctor
            param = new SqlParameter();
            param.ParameterName = "@BookinDoctor";
            param.Value = mnDataPackPatientCheck.BookinDoctor;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //CheckDoctor
            param = new SqlParameter();
            param.ParameterName = "@CheckDoctor";
            param.Value = mnDataPackPatientCheck.CheckDoctor;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ClinicalDiagnosis
            param = new SqlParameter();
            param.ParameterName = "@ClinicalDiagnosis";
            param.Value = mnDataPackPatientCheck.ClinicalDiagnosis;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //PatientDictation
            param = new SqlParameter();
            param.ParameterName = "@PatientDictation";
            param.Value = mnDataPackPatientCheck.PatientDictation;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Findings
            param = new SqlParameter();
            param.ParameterName = "@Findings";
            param.Value = mnDataPackPatientCheck.Findings;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Prompt
            param = new SqlParameter();
            param.ParameterName = "@Prompt";
            param.Value = mnDataPackPatientCheck.Prompt;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //BookinDate
            param = new SqlParameter();
            param.ParameterName = "@BookinDate";
            param.Value = mnDataPackPatientCheck.BookinDate;
            param.SqlDbType = System.Data.SqlDbType.SmallDateTime;
            cmdSql.Parameters.Add(param);
            //CheckDate
            param = new SqlParameter();
            param.ParameterName = "@CheckDate";
            param.Value = mnDataPackPatientCheck.CheckDate;
            param.SqlDbType = System.Data.SqlDbType.SmallDateTime;
            cmdSql.Parameters.Add(param);
            //PositiveSymbol
            param = new SqlParameter();
            param.ParameterName = "@PositiveSymbol";
            param.Value = mnDataPackPatientCheck.PositiveSymbol;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //DoctorDictation
            param = new SqlParameter();
            param.ParameterName = "@DoctorDictation";
            param.Value = mnDataPackPatientCheck.DoctorDictation;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Report
            param = new SqlParameter();
            param.ParameterName = "@Report";
            param.Value = mnDataPackPatientCheck.Report;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //PrintSymbol
            param = new SqlParameter();
            param.ParameterName = "@PrintSymbol";
            param.Value = mnDataPackPatientCheck.PrintSymbol;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //ExportSymbol
            param = new SqlParameter();
            param.ParameterName = "@ExportSymbol";
            param.Value = mnDataPackPatientCheck.ExportSymbol;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //Remark
            param = new SqlParameter();
            param.ParameterName = "Remark";
            param.Value = mnDataPackPatientCheck.Remark;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ListNum
            param = new SqlParameter();
            param.ParameterName = "@ListNum";
            param.Value = mnDataPackPatientCheck.ListNum;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //DictationName
            param = new SqlParameter();
            param.ParameterName = "@DictationName";
            param.Value = mnDataPackPatientCheck.DictationName;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ReportName
            param = new SqlParameter();
            param.ParameterName = "@ReportName";
            param.Value = mnDataPackPatientCheck.ReportName;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //States
            param = new SqlParameter();
            param.ParameterName = "@States";
            param.Value = mnDataPackPatientCheck.States;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Clinicians
            param = new SqlParameter();
            param.ParameterName = "@Clinicians";
            param.Value = mnDataPackPatientCheck.Clinicians;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Appointment
            param = new SqlParameter();
            param.ParameterName = "@Appointment";
            param.Value = mnDataPackPatientCheck.Appointment;
            param.SqlDbType = System.Data.SqlDbType.SmallDateTime;
            cmdSql.Parameters.Add(param);
            //Reservatiannum
            param = new SqlParameter();
            param.ParameterName = "@Reservationnum";
            param.Value = mnDataPackPatientCheck.Reservationnum;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //Priority
            param = new SqlParameter();
            param.ParameterName = "@Priority";
            param.Value = mnDataPackPatientCheck.Priority;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //RoomName
            param = new SqlParameter();
            param.ParameterName = "@RoomName";
            param.Value = mnDataPackPatientCheck.RoomName;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //groups
            param = new SqlParameter();
            param.ParameterName = "@groups";
            param.Value = mnDataPackPatientCheck.groups;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ordering
            param = new SqlParameter();
            param.ParameterName = "@ordering";
            param.Value = mnDataPackPatientCheck.ordering;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //Free
            param = new SqlParameter();
            param.ParameterName = "@Free";
            param.Value = mnDataPackPatientCheck.Free;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //PatientGroup
            param = new SqlParameter();
            param.ParameterName = "@PatientGroup";
            param.Value = mnDataPackPatientCheck.PatientGroup;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //code
            param = new SqlParameter();
            param.ParameterName = "@code";
            param.Value = mnDataPackPatientCheck.code;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //disease
            param = new SqlParameter();
            param.ParameterName = "@disease";
            param.Value = mnDataPackPatientCheck.disease;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Category
            param = new SqlParameter();
            param.ParameterName = "@Category";
            param.Value = mnDataPackPatientCheck.Category;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //tipsofabstract
            param = new SqlParameter();
            param.ParameterName = "@tipsofabstract";
            param.Value = mnDataPackPatientCheck.tipofabstract;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //diagnosis
            param = new SqlParameter();
            param.ParameterName = "@diagnosis";
            param.Value = mnDataPackPatientCheck.diagnosis;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //PatientPriority
            param = new SqlParameter();
            param.ParameterName = "@PatientPriority";
            param.Value = mnDataPackPatientCheck.PatientPriority;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);

            //将数据写入数据库
            try
            {
                UltrasoundConnection.Open();
                int writeline = -1;
                writeline = cmdSql.ExecuteNonQuery();
                if (writeline == 1)
                {
                    DataBaseCreate = new Status()
                    {
                        result = Result.Success,
                        codeSnippetName = "DataService.PatientCheckCreate.Create",
                        index = "DS.10001",
                        message = "DataService-PatientCheckCreate-intial"
                    };
                }
                return DataBaseCreate;
            }
            catch (Exception e)
            {
                DataBaseCreate.result = Result.Error;
                DataBaseCreate.index = "DS.10002";
                DataBaseCreate.message = e.Message;
                return DataBaseCreate;
            }
            finally
            {
                UltrasoundConnection.Close();
            }
        }

        /// <summary>
        /// 更改记录内容
        /// </summary>
        /// <param name="mnDataPackPatientCheck">记录格式的数据包</param>
        /// <returns></returns>
        public Status Update(DataPackPatientCheck mnDataPackPatientCheck)
        {
            Status result = new Status()
            {
                result = Result.Initial,
                codeSnippetName = "DataService>>PatientCheckUpdate>>Update",
                index = "DS.20000",
                message = "DataService>>PatientCheckUpdate>>Update is initial"
            };
            string SqlText = "UPDATE [PatientCheck] SET" +
                "CheckCode = '@CheckCode'," +
                "RediagnosisDevice = '@RediagnosisDevice'," +
                "Origin = '@Origin'," +
                "CheckPart = '@CheckPart'," +
                "CheckPrice = '@CheckPrice'," +
                "HospitalizedNum = '@HospitalizedNum'," +
                "SickbedNum = '@SickbedNum'," +
                "ClinicalOffice = '@ClinicalOffice'," +
                "BookinDoctor = '@BookinDoctor'," +
                "CheckDoctor = '@CheckDoctor'," +
                "ClinicalDiagnosis = '@ClinicalDiagnosis'," +
                "PatientDictation = '@PatientDictation'," +
                "Findings = '@Findings'," +
                "Prompt = '@Prompt'," +
                "BookinDate = '@BookinDate'," +
                "CheckDate = '@CheckDate'," +
                "PositiveSymbol = '@PositiveSymbol'," +
                "DoctorDictation = '@DoctorDiction'," +
                "Report = '@Report'," +
                "PrintSymbol = '@PrintSymbol'," +
                "ExportSymbol = '@ExportSymbol'," +
                "Remark = '@Remark'," +
                "ListNum = '@ListNum'," +
                "DictationName = '@DictationName'" +
                "ReportName = '@ReportName'," +
                "States = '@States'," +
                "Clinicians = '@Clinicians'," +
                "Appointment = '@Appointment'," +
                "Reservationnum = '@Reservationnum'," +
                "Priority = '@Priority'," +
                "RoomName = '@RoomName'," +
                "groups = '@groups'," +
                "ordering = '@ordering'," +
                "Free = '@Free'," +
                "PatientGroup = '@PatientGroup'," +
                "code = '@code'," +
                "disease = '@disease'," +
                "Category = '@Category'," +
                "tipsofabstract = '@tipsofabstract'," +
                "diagnosis = '@diagnosis'," +
                "PatientPriority = '@PatientPriority'" +
                "WHERE ArchieveCode = @ArchieveCode"
                ;
            //操作数据库的连接命令
            SqlConnection UltrasoundConnection = new SqlConnection(DataBaseConnection.UltraSoundConnectionString);
            SqlCommand cmdSql = new SqlCommand(SqlText, UltrasoundConnection);
            SqlParameter param = new SqlParameter();
            //填充参数集合
            //患者序号
            param.ParameterName = "@ArchiveCode";
            param.Value = mnDataPackPatientCheck.ArchiveCode;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            param.Size = 50;
            cmdSql.Parameters.Add(param);
            //Checkcode
            param = new SqlParameter();
            param.ParameterName = "@CheckCode";
            param.Value = mnDataPackPatientCheck.CheckCode;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            param.Size = 50;
            cmdSql.Parameters.Add(param);
            //ReDiagnosisTimes
            param = new SqlParameter();
            param.ParameterName = "@RediagnosisTimes";
            param.Value = mnDataPackPatientCheck.ReDiagnosisTimes;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //DiagnosisDevice
            param = new SqlParameter();
            param.ParameterName = "@DiagnosisDevice";
            param.Value = mnDataPackPatientCheck.DiagnosisDevice;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Origin
            param = new SqlParameter();
            param.ParameterName = "@Origin";
            param.Value = mnDataPackPatientCheck.Origin;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //CheckPart
            param = new SqlParameter();
            param.ParameterName = "@CheckPart";
            param.Value = mnDataPackPatientCheck.CheckPart;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //CheckPrice
            param = new SqlParameter();
            param.ParameterName = "@CheckPrice";
            param.Value = mnDataPackPatientCheck.CheckPrice;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //HospitalizedNum
            param = new SqlParameter();
            param.ParameterName = "@HospitalizedNum";
            param.Value = mnDataPackPatientCheck.HospitalizedNum;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //SickbedNum
            param = new SqlParameter();
            param.ParameterName = "@SickbedNum";
            param.Value = mnDataPackPatientCheck.SickbedNum;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ClinicalOffice
            param = new SqlParameter();
            param.ParameterName = "@ClinicalOffice";
            param.Value = mnDataPackPatientCheck.ClinicalOffice;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //BookinDoctor
            param = new SqlParameter();
            param.ParameterName = "@BookinDoctor";
            param.Value = mnDataPackPatientCheck.BookinDoctor;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //CheckDoctor
            param = new SqlParameter();
            param.ParameterName = "@CheckDoctor";
            param.Value = mnDataPackPatientCheck.CheckDoctor;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ClinicalDiagnosis
            param = new SqlParameter();
            param.ParameterName = "@ClinicalDiagnosis";
            param.Value = mnDataPackPatientCheck.ClinicalDiagnosis;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //PatientDictation
            param = new SqlParameter();
            param.ParameterName = "@PatientDictation";
            param.Value = mnDataPackPatientCheck.PatientDictation;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Findings
            param = new SqlParameter();
            param.ParameterName = "@Findings";
            param.Value = mnDataPackPatientCheck.Findings;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Prompt
            param = new SqlParameter();
            param.ParameterName = "@Prompt";
            param.Value = mnDataPackPatientCheck.Prompt;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //BookinDate
            param = new SqlParameter();
            param.ParameterName = "@BookinDate";
            param.Value = mnDataPackPatientCheck.BookinDate;
            param.SqlDbType = System.Data.SqlDbType.SmallDateTime;
            cmdSql.Parameters.Add(param);
            //CheckDate
            param = new SqlParameter();
            param.ParameterName = "@CheckDate";
            param.Value = mnDataPackPatientCheck.CheckDate;
            param.SqlDbType = System.Data.SqlDbType.SmallDateTime;
            cmdSql.Parameters.Add(param);
            //PositiveSymbol
            param = new SqlParameter();
            param.ParameterName = "@PositiveSymbol";
            param.Value = mnDataPackPatientCheck.PositiveSymbol;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //DoctorDictation
            param = new SqlParameter();
            param.ParameterName = "@DoctorDictation";
            param.Value = mnDataPackPatientCheck.DoctorDictation;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Report
            param = new SqlParameter();
            param.ParameterName = "@Report";
            param.Value = mnDataPackPatientCheck.Report;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //PrintSymbol
            param = new SqlParameter();
            param.ParameterName = "@PrintSymbol";
            param.Value = mnDataPackPatientCheck.PrintSymbol;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //ExportSymbol
            param = new SqlParameter();
            param.ParameterName = "@ExportSymbol";
            param.Value = mnDataPackPatientCheck.ExportSymbol;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //Remark
            param = new SqlParameter();
            param.ParameterName = "Remark";
            param.Value = mnDataPackPatientCheck.Remark;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ListNum
            param = new SqlParameter();
            param.ParameterName = "@ListNum";
            param.Value = mnDataPackPatientCheck.ListNum;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //DictationName
            param = new SqlParameter();
            param.ParameterName = "@DictationName";
            param.Value = mnDataPackPatientCheck.DictationName;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ReportName
            param = new SqlParameter();
            param.ParameterName = "@ReportName";
            param.Value = mnDataPackPatientCheck.ReportName;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //States
            param = new SqlParameter();
            param.ParameterName = "@States";
            param.Value = mnDataPackPatientCheck.States;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Clinicians
            param = new SqlParameter();
            param.ParameterName = "@Clinicians";
            param.Value = mnDataPackPatientCheck.Clinicians;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Appointment
            param = new SqlParameter();
            param.ParameterName = "@Appointment";
            param.Value = mnDataPackPatientCheck.Appointment;
            param.SqlDbType = System.Data.SqlDbType.SmallDateTime;
            cmdSql.Parameters.Add(param);
            //Reservatiannum
            param = new SqlParameter();
            param.ParameterName = "@Reservationnum";
            param.Value = mnDataPackPatientCheck.Reservationnum;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //Priority
            param = new SqlParameter();
            param.ParameterName = "@Priority";
            param.Value = mnDataPackPatientCheck.Priority;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //RoomName
            param = new SqlParameter();
            param.ParameterName = "@RoomName";
            param.Value = mnDataPackPatientCheck.RoomName;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //groups
            param = new SqlParameter();
            param.ParameterName = "@groups";
            param.Value = mnDataPackPatientCheck.groups;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ordering
            param = new SqlParameter();
            param.ParameterName = "@ordering";
            param.Value = mnDataPackPatientCheck.ordering;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //Free
            param = new SqlParameter();
            param.ParameterName = "@Free";
            param.Value = mnDataPackPatientCheck.Free;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //PatientGroup
            param = new SqlParameter();
            param.ParameterName = "@PatientGroup";
            param.Value = mnDataPackPatientCheck.PatientGroup;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //code
            param = new SqlParameter();
            param.ParameterName = "@code";
            param.Value = mnDataPackPatientCheck.code;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //disease
            param = new SqlParameter();
            param.ParameterName = "@disease";
            param.Value = mnDataPackPatientCheck.disease;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Category
            param = new SqlParameter();
            param.ParameterName = "@Category";
            param.Value = mnDataPackPatientCheck.Category;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //tipsofabstract
            param = new SqlParameter();
            param.ParameterName = "@tipsofabstract";
            param.Value = mnDataPackPatientCheck.tipofabstract;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //diagnosis
            param = new SqlParameter();
            param.ParameterName = "@diagnosis";
            param.Value = mnDataPackPatientCheck.diagnosis;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //PatientPriority
            param = new SqlParameter();
            param.ParameterName = "@PatientPriority";
            param.Value = mnDataPackPatientCheck.PatientPriority;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //开始写入过程
            try
            {
                UltrasoundConnection.Open();
                cmdSql.ExecuteNonQuery();
                result.result = Result.Success;
                result.index = "DS.20001";
                result.message = "successfully update the data.";
                return result;

            }
            catch (Exception e)
            {
                result.result = Result.Error;
                result.index = "DS.20002";
                result.message = "There is an error happened when update the data to the database,the error is:" + e.Message;
                return result;
            }
            finally
            {
                UltrasoundConnection.Close();
            }
        }

        /// <summary>
        /// 删除数据库中的记录
        /// </summary>
        /// <param name="mnCheckCode">要删除项目的编码</param>
        /// <returns></returns>
        public Status Delete(string mnCheckCode)
        {
            Status result = new Status()
            {
                codeSnippetName = "DataService>>PatientCheckDelete>>Delete",
                index = "DS.30000",
                result = Result.Initial,
                message = "DataService>>PatientCheckDelete>>Delete intial"
            };

            string sqlText = "DELETE FROM [PatientCheck] WHERE CheckCode = @CheckCode ";
            SqlConnection mnDatabaseConnection = new SqlConnection(DataBaseConnection.UltraSoundConnectionString);
            SqlCommand mnSqlCommand = new SqlCommand(sqlText, mnDatabaseConnection);
            SqlParameter mnPara = new SqlParameter();
            mnPara.Value = mnCheckCode;
            mnPara.DbType = System.Data.DbType.String;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //执行删除
            try
            {
                mnDatabaseConnection.Open();
                mnSqlCommand.ExecuteNonQuery();
                result.result = Result.Success;
                result.index = "DS.30001";
                result.message = "DataService>>PatientCheckDelete>>Delete Success";
                return result;
            }
            catch (Exception e)
            {
                result.result = Result.Error;
                result.index = "DS.30002";
                result.message = "DataService>>PatientCheckDelete>>Delete has an error:" + e.Message;
                return result;
            }
            finally
            {
                mnDatabaseConnection.Close();
            }

        }

    }
}
