﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Include Project
using PatientAppointment.Common;
using System.Data.SqlClient;
using PatientAppointment.DataBase;

namespace PatientAppointment.Control
{
    public class Exam_Add
    {

        /// <summary>
        /// 将数据写入数据库，使用代码参数的方式
        /// </summary>
        /// <param name="packageExam"></param>
        /// <returns></returns>
        public Status AddExamToDatabase(DataCheck mnDataCheck)
        {
            //方法运行状态初始化
            Status result = new Status() { 
                codeSnippetName = "Control>>Exam_Add>>AddExamToDatabase",
                result = Result.Initial,
                message = "Initial",
                index = "Control.EA.AETD.009" };
            //打开连接
            SqlConnection UltrasoundConnection = new SqlConnection(DataBaseConnection.UltraSoundConnectionString);
            SqlConnection AppointmentConnection = new SqlConnection(DataBaseConnection.AppointmentConnectionString);
            //写入语句，和参变量
            string cmdAdd = "Insert Into [PatientChecks] (" + 
                "ArchiveCode,"+
                "CheckCode,"+
                "ReDiagnosisTimes,"+
                "DiagnosisDevice,"+
                "Origin," + 
                "CheckPart,"+
                "CheckPrice,"+
                "HospitalizedNum,"+
                "SickbedNum,"+
                "ClinicalOffice," +
                "BookinDoctor,"+
                "CheckDoctor,"+
                "ClinicalDiagnosis,"+
                "PatientDictation,"+
                "Findings,"+
                "Prompt,"+
                "BookinDate,"+
                "CheckDate,"+
                "PositiveSymbol,"+
                "ExportSymbol,"+
                "Remark,"+
                "ListNum,"+
                "DictationName,"+
                "ReportName,"+
                "States,"+
                "Clinicians,"+
                "Appointment,"+
                "ReservationNum,"+
                "Priority,"+
                "RoomName,"+
                "groups,"+
                "ordering,"+
                "Free,"+
                "PatientGroup,"+
                "Code,"+
                "disease,"+
                "Category,"+
                "tipsofabstract,"+
                "diagnosis,"+
                "PatientPriority"+
                ")"+
                " Values ("+
                "@ArchiveCode,"+
                "@CheckCode,"+
                "@ReDiagnosisTimes,"+
                "@DiagnosisDevice,"+
                "@Origin,"+
                "@CheckPart,"+
                "@CheckPrice,"+
                "@HospitalizedNum,"+
                "@SickbedNum,"+
                "@ClinicalOffice,"+
                "@BookinDoctor,"+
                "@CheckDoctor,"+
                "@ClinicalDiagnosis,"+
                "@PatientDictation,"+
                "@Report,"+
                "@PrintSymbol,"+
                "@ExportSymbol,"+
                "@Remark,"+
                "@ListNum,"+
                "@DictationName,"+
                "@ReportName,"+
                "@States,"+
                "@Clinicans,"+
                "@Appointment,"+
                "@Reservationnum,"+
                "@Priority,"+
                "@RoomName,"+
                "@groups,"+
                "@Ordering," +
                "@Free,"+
                "@PatientGroup,"+
                "@Code,"+
                "@disease,"+
                "@Category,"+
                "@tipsofabstract,"+
                "@diagnosis,"+
                "@PatientPriority"+
                ")";
            //写入语句
            SqlCommand cmdSql = new SqlCommand(cmdAdd, UltrasoundConnection);
            //填充参数集合
            //患者序号
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ArchiveCode";
            param.Value = mnDataCheck.ArchiveCode;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            param.Size = 50;
            cmdSql.Parameters.Add(param);
            //Checkcode
            param = new SqlParameter();
            param.ParameterName = "@CheckCode";
            param.Value = mnDataCheck.CheckCode;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            param.Size = 50;
            cmdSql.Parameters.Add(param);
            //ReDiagnosisTimes
            param = new SqlParameter();
            param.ParameterName = "@RediagnosisTimes";
            param.Value = mnDataCheck.ReDiagnosisTimes;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //DiagnosisDevice
            param = new SqlParameter();
            param.ParameterName = "@DiagnosisDevice";
            param.Value = mnDataCheck.DiagnosisDevice;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Origin
            param = new SqlParameter();
            param.ParameterName = "@Origin";
            param.Value = mnDataCheck.Origin;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //CheckPart
            param = new SqlParameter();
            param.ParameterName = "@CheckPart";
            param.Value = mnDataCheck.CheckPart;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //CheckPrice
            param = new SqlParameter();
            param.ParameterName = "@CheckPrice";
            param.Value = mnDataCheck.CheckPrice;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //HospitalizedNum
            param = new SqlParameter();
            param.ParameterName = "@HospitalizedNum";
            param.Value = mnDataCheck.HospitalizedNum;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //SickbedNum
            param = new SqlParameter();
            param.ParameterName = "@SickbedNum";
            param.Value = mnDataCheck.SickbedNum;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ClinicalOffice
            param = new SqlParameter();
            param.ParameterName = "@ClinicalOffice";
            param.Value = mnDataCheck.ClinicalOffice;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //BookinDoctor
            param = new SqlParameter();
            param.ParameterName = "@BookinDoctor";
            param.Value = mnDataCheck.BookinDoctor;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //CheckDoctor
            param = new SqlParameter();
            param.ParameterName = "@CheckDoctor";
            param.Value = mnDataCheck.CheckDoctor;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ClinicalDiagnosis
            param = new SqlParameter();
            param.ParameterName = "@ClinicalDiagnosis";
            param.Value = mnDataCheck.ClinicalDiagnosis;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //PatientDictation
            param = new SqlParameter();
            param.ParameterName = "@PatientDictation";
            param.Value = mnDataCheck.PatientDictation;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Findings
            param = new SqlParameter();
            param.ParameterName = "@Findings";
            param.Value = mnDataCheck.Findings;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Prompt
            param = new SqlParameter();
            param.ParameterName = "@Prompt";
            param.Value = mnDataCheck.Prompt;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //BookinDate
            param = new SqlParameter();
            param.ParameterName = "@BookinDate";
            param.Value = mnDataCheck.BookinDate;
            param.SqlDbType = System.Data.SqlDbType.Date;
            cmdSql.Parameters.Add(param);
            //CheckDate
            param = new SqlParameter();
            param.ParameterName = "@CheckDate";
            param.Value = mnDataCheck.CheckDate;
            param.SqlDbType = System.Data.SqlDbType.Date;
            cmdSql.Parameters.Add(param);
            //PositiveSymbol
            param = new SqlParameter();
            param.ParameterName = "@PositiveSymbol";
            param.Value = mnDataCheck.PositiveSymbol;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //DoctorDictation
            param = new SqlParameter();
            param.ParameterName = "@DoctorDictation";
            param.Value = mnDataCheck.DoctorDictation;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Report
            param = new SqlParameter();
            param.ParameterName = "@Report";
            param.Value = mnDataCheck.Report;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //PrintSymbol
            param = new SqlParameter();
            param.ParameterName = "@PrintSymbol";
            param.Value = mnDataCheck.PrintSymbol;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //ExportSymbol
            param = new SqlParameter();
            param.ParameterName = "@ExportSymbol";
            param.Value = mnDataCheck.ExportSymbol;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //ListNum
            param = new SqlParameter();
            param.ParameterName = "@ListNum";
            param.Value = mnDataCheck.ListNum;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //DictationName
            param = new SqlParameter();
            param.ParameterName = "@DictationName";
            param.Value = mnDataCheck.DictationName;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ReportName
            param = new SqlParameter();
            param.ParameterName = "@ReportName";
            param.Value = mnDataCheck.ReportName;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //States
            param = new SqlParameter();
            param.ParameterName = "@CheckPrice";
            param.Value = mnDataCheck.CheckPrice;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Clinicians
            param = new SqlParameter();
            param.ParameterName = "@Clinicians";
            param.Value = mnDataCheck.Clinicians;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Appointment
            param = new SqlParameter();
            param.ParameterName = "@Appointment";
            param.Value = mnDataCheck.Appointment;
            param.SqlDbType = System.Data.SqlDbType.Date;
            cmdSql.Parameters.Add(param);
            //Reservatiannum
            param = new SqlParameter();
            param.ParameterName = "@Reservationnum";
            param.Value = mnDataCheck.Reservationnum;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //Priority
            param = new SqlParameter();
            param.ParameterName = "@Priority";
            param.Value = mnDataCheck.Priority;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //RoomName
            param = new SqlParameter();
            param.ParameterName = "@RoomName";
            param.Value = mnDataCheck.RoomName;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //groups
            param = new SqlParameter();
            param.ParameterName = "@groups";
            param.Value = mnDataCheck.groups;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //ordering
            param = new SqlParameter();
            param.ParameterName = "@ordering";
            param.Value = mnDataCheck.ordering;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //Free
            param = new SqlParameter();
            param.ParameterName = "@Free";
            param.Value = mnDataCheck.Free;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //PatientGroup
            param = new SqlParameter();
            param.ParameterName = "@PatientGroup";
            param.Value = mnDataCheck.PatientGroup;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //code
            param = new SqlParameter();
            param.ParameterName = "@code";
            param.Value = mnDataCheck.code;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //disease
            param = new SqlParameter();
            param.ParameterName = "@disease";
            param.Value = mnDataCheck.disease;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //Category
            param = new SqlParameter();
            param.ParameterName = "@Category";
            param.Value = mnDataCheck.Category;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //tipsofabstract
            param = new SqlParameter();
            param.ParameterName = "@tipsofabstract";
            param.Value = mnDataCheck.tipofabstract;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //diagnosis
            param = new SqlParameter();
            param.ParameterName = "@diagnosis";
            param.Value = mnDataCheck.diagnosis;
            param.SqlDbType = System.Data.SqlDbType.VarChar;
            cmdSql.Parameters.Add(param);
            //PatientPriority
            param = new SqlParameter();
            param.ParameterName = "@PatientPriority";
            param.Value = mnDataCheck.PatientPriority;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmdSql.Parameters.Add(param);
            //执行命令
            try
            {
                cmdSql.ExecuteNonQuery();
                result = new Status()
                {
                    codeSnippetName = "",
                    index = "",
                    message = "",
                    result = Result.Success
                };
            }
            catch (Exception e)
            {
                result = new Status() { 
                    codeSnippetName = "Control>>Exam_Add>>AddExamToDatabase", 
                    index = "CEA0001", 
                    message = e.Message, 
                    result = Result.Error };
            }
            //返回方法运行结果
            return result;
        }

    }
}
