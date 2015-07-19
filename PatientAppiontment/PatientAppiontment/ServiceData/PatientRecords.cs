using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//include
using System.Data.SqlClient;
using PatientAppointment.Common;
using PatientAppointment.DataBase;
using PatientAppointment.DataPackage;

namespace PatientAppointment.ServiceData
{
    class PatientRecords
    {
        /// <summary>
        /// 在数据库中新建患者信息
        /// </summary>
        /// <param name="mnDataPackPatientRecords">患者信息数据包</param>
        /// <returns></returns>
        public Status Create(DataPackPatientRecords mnDataPackPatientRecords)
        {
            Status result = new Status(){
                 index = "SD.PR.C000",
                 codeSnippetName = "ServiceData>>PatientRecord>>Create",
                 result = Result.Initial,
                 message = "ServiceData>>PatientRecords>>Create initial."
            };
            //要连接的数据库
            SqlConnection ultrasoundConn = new SqlConnection(DataBaseConnection.UltraSoundConnectionString);
            string SqlCommandText =string.Format( "INSERT INTO [PatientRecords] ("+
                "ArchiveCode,"+
                "PatientName,"+
                "Sex,"+
                "Age,"+
                "AgeSymbol,"+
                "PrintSymbol,"+
                "States,"+
                "Contacts,"+
                "InsuranceNum,"+
                "FoundDate,"+
                "MarriageState,"+
                "PregnancyTimes,"+
                "ProcreationTimes,"+
                "Remark,"+
                "ModifyTimes,"+
                "Stuff)"+
                " VALUES("+
                "@ArchiveCode,"+
                "@PatientName,"+
                "@Sex,"+
                "@Age,"+
                "@AgeSymbol,"+
                "@PrintSymbol,"+
                "@States,"+
                "@Contacts,"+
                "@InsuranceNum,"+
                "@FoundDate,"+
                "@MarriageState,"+
                "@PregnancyTimes,"+
                "@ProcreationTimes,"+
                "@Remark,"+
                "@ModifyTimes,"+
                "@Stuff"+
                ")"
                );
            SqlCommand mnSqlCommand = new SqlCommand(SqlCommandText,ultrasoundConn);
            //填充参数
            //ArchiveCode
            SqlParameter mnPara = new SqlParameter();
            mnPara.ParameterName = "@ArchiveCode";
            mnPara.Value = mnDataPackPatientRecords.ArchiveCode;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //PatientName
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@PatientName";
            mnPara.Value = mnDataPackPatientRecords.PatientName;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //Sex
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Sex";
            mnPara.Value = mnDataPackPatientRecords.Sex;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //Age
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Age";
            mnPara.Value = mnDataPackPatientRecords.Age;
            mnPara.SqlDbType = System.Data.SqlDbType.Int;
            mnSqlCommand.Parameters.Add(mnPara);
            //AgeSymbol
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@AgeSymbol";
            mnPara.Value = mnDataPackPatientRecords.AgeSymbol;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //PrintSymbol
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@PrintSymbol";
            mnPara.Value = mnDataPackPatientRecords.PrintSymbol;
            mnPara.SqlDbType = System.Data.SqlDbType.SmallInt;
            mnSqlCommand.Parameters.Add(mnPara);
            //States
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@States";
            mnPara.Value = mnDataPackPatientRecords.States;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //Contacts
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Contacts";
            mnPara.Value = mnDataPackPatientRecords.Contacts;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 256;
            mnSqlCommand.Parameters.Add(mnPara);
            //InsuranceNum
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@InsuranceNum";
            mnPara.Value = mnDataPackPatientRecords.InsuranceNum;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //FoundDate
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@FoundDate";
            mnPara.Value = mnDataPackPatientRecords.FoundDate;
            mnPara.SqlDbType = System.Data.SqlDbType.SmallDateTime;
            mnSqlCommand.Parameters.Add(mnPara);
            //MarriageState
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@MarriageState";
            mnPara.Value = mnDataPackPatientRecords.MarriageState;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //PregnancyTimes
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@PregnancyTimes";
            mnPara.Value = mnDataPackPatientRecords.PregnancyTimes;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnSqlCommand.Parameters.Add(mnPara);
            //ProcreationTimes
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@ProcreationTimes";
            mnPara.Value = mnDataPackPatientRecords.ProcreationTimes;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnSqlCommand.Parameters.Add(mnPara);
            //Remark
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Remark";
            mnPara.Value = mnDataPackPatientRecords.Remark;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 300;
            mnSqlCommand.Parameters.Add(mnPara);
            //ModifyTimes
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@ModifyTimes";
            mnPara.Value = mnDataPackPatientRecords.ModifyTimes;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //Stuff
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Stuff";
            mnPara.Value = mnDataPackPatientRecords.Stuff;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //执行命令
            try
            {
                ultrasoundConn.Open();
                mnSqlCommand.ExecuteNonQuery();
                result = new Status()
                {
                    index = "SD.PR.C001",
                    codeSnippetName = "ServiceData>>PatientRecords>>Create",
                    result = Result.Success,
                    message = "ServiceData>>PatientRecords>>Create Successfully write the PatientRecord into DataBase."
                };
                return result;
            }
            catch (Exception e)
            {
                result = new Status()
                {
                    index = "SD.PR.C002",
                    codeSnippetName = "ServiceData>>PatientRecords>>Create",
                    result = Result.Error,
                    message = "ServiceData>>PatientRecords>>Create An Error occured when write to the DataBase:" + e.Message
                };
                return result;
            }
            finally
            {
                ultrasoundConn.Close();
            }
        }

        /// <summary>
        /// 在数据库中更新患者信息
        /// </summary>
        /// <param name="mnDataPackPatientRecords">患者信息数据包</param>
        /// <returns></returns>
        public Status Update(DataPackPatientRecords mnDataPackPatientRecords)
        {
            Status result = new Status()
            {
                index = "SD.PR.U001",
                codeSnippetName = "ServiceData>>PatientRecord>>Update",
                result = Result.Initial,
                message = "ServiceData>>PatientRecords>>Update initial."
            };
            //要连接的数据库
            SqlConnection ultrasoundConn = new SqlConnection(DataBaseConnection.UltraSoundConnectionString);
            string SqlCommandText = "UPDATE [PatientRecords] SET" +

                "PatientName = '@PatientName'," +
                "Sex = '@Sex'," +
                "Age = '@Age'," +
                "AgeSymbol = '@AgeSymbol'," +
                "PrintSymbol = '@PrintSymbol'," +
                "States = '@States'," +
                "Contacts = '@Contacts'," +
                "InsuranceNum = '@InsuranceNum'," +
                "FoundDate = '@FoundDate'," +
                "MarriageState = '@MarriageState'," +
                "PregnancyTimes = '@PregnancyTimes'," +
                "ProcreationTimes = '@ProcreationTimes'," +
                "Remark = '@Remark'," +
                "ModifyTimes = '@ModifyTimes'," +
                "Stuff = '@Stuff'" +
                "WHERE ArchiveCode = '@ArchiveCode'" ;
            SqlCommand mnSqlCommand = new SqlCommand(SqlCommandText, ultrasoundConn);
            //填充参数
            //ArchiveCode
            SqlParameter mnPara = new SqlParameter();
            mnPara.ParameterName = "@ArchiveCode";
            mnPara.Value = mnDataPackPatientRecords.ArchiveCode;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //PatientName
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@PatientName";
            mnPara.Value = mnDataPackPatientRecords.PatientName;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //Sex
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Sex";
            mnPara.Value = mnDataPackPatientRecords.Sex;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //Age
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Age";
            mnPara.Value = mnDataPackPatientRecords.Age;
            mnPara.SqlDbType = System.Data.SqlDbType.Int;
            mnSqlCommand.Parameters.Add(mnPara);
            //AgeSymbol
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@AgeSymbol";
            mnPara.Value = mnDataPackPatientRecords.AgeSymbol;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //PrintSymbol
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@PrintSymbol";
            mnPara.Value = mnDataPackPatientRecords.PrintSymbol;
            mnPara.SqlDbType = System.Data.SqlDbType.Int;
            mnSqlCommand.Parameters.Add(mnPara);
            //States
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@States";
            mnPara.Value = mnDataPackPatientRecords.States;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //Contacts
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Contacts";
            mnPara.Value = mnDataPackPatientRecords.Contacts;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 256;
            mnSqlCommand.Parameters.Add(mnPara);
            //InsuranceNum
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@InsuranceNum";
            mnPara.Value = mnDataPackPatientRecords.InsuranceNum;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //FoundDate
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@FoundDate";
            mnPara.Value = mnDataPackPatientRecords.FoundDate;
            mnPara.SqlDbType = System.Data.SqlDbType.SmallDateTime;
            mnSqlCommand.Parameters.Add(mnPara);
            //<arroageState
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@MarriageState";
            mnPara.Value = mnDataPackPatientRecords.MarriageState;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //PregnancyTimes
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@PregnancyTimes";
            mnPara.Value = mnDataPackPatientRecords.PregnancyTimes;
            mnPara.SqlDbType = System.Data.SqlDbType.Int;
            mnSqlCommand.Parameters.Add(mnPara);
            //ProcreationTimes
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@ProcreationTimes";
            mnPara.Value = mnDataPackPatientRecords.ProcreationTimes;
            mnPara.SqlDbType = System.Data.SqlDbType.Int;
            mnSqlCommand.Parameters.Add(mnPara);
            //Remark
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Remark";
            mnPara.Value = mnDataPackPatientRecords.Remark;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 300;
            mnSqlCommand.Parameters.Add(mnPara);
            //ModifyTimes
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@ModifyTimes";
            mnPara.Value = mnDataPackPatientRecords.ModifyTimes;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //Stuff
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Stuff";
            mnPara.Value = mnDataPackPatientRecords.Stuff;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //执行命令
            try
            {
                ultrasoundConn.Open();
                mnSqlCommand.ExecuteNonQuery();
                result = new Status()
                {
                    index = "SD.PR.U002",
                    codeSnippetName = "ServiceData>>PatientRecords>>Update",
                    result = Result.Success,
                    message = "ServiceData>>PatientRecords>>Update Successfully Update the PatientRecord."
                };
                return result;
            }
            catch (Exception e)
            {
                result = new Status()
                {
                    index = "SD.PR.U003",
                    codeSnippetName = "ServiceData>>PatientRecords>>Update",
                    result = Result.Error,
                    message = "ServiceData>>PatientRecords>>Update An Error occured when Update the PatientRecord:" + e.Message
                };
                return result;
            }
            finally
            {
                ultrasoundConn.Close();
            }
        }

        /// <summary>
        /// 在数据库中删除指定患者信息
        /// </summary>
        /// <param name="mnArchiveCode">要删除的患者ArchiveCode</param>
        /// <returns></returns>
        public Status Delete(string mnArchiveCode)
        {
            Status result = new Status()
            {
                index = "SD.PR.D000",
                codeSnippetName = "ServiceData>>PatientRecords>>Delete",
                result = Result.Initial,
                message = "ServiceData>>PatientRecords>>Delete"
            };
            string txtCommandDelete = "DELETE FROM [PatientRecords] WHERE ArchiveCode = '@ArchiveCode'";
            SqlConnection mnUltrasoundConn = new SqlConnection(DataBaseConnection.UltraSoundConnectionString);
            SqlCommand mnSqlCommand = new SqlCommand(txtCommandDelete, mnUltrasoundConn);
            SqlParameter mnSqlParam = new SqlParameter();
            mnSqlParam.TypeName = "@ArchiveCode";
            mnSqlParam.Value = mnArchiveCode;
            mnSqlParam.SqlDbType = System.Data.SqlDbType.VarChar;
            mnSqlParam.Size = 50;
            mnSqlCommand.Parameters.Add(mnSqlParam);
            //执行
            try
            {
                mnUltrasoundConn.Open();
                mnSqlCommand.ExecuteNonQuery();
                result = new Status()
                {
                    index = "SD.PR.D001",
                    codeSnippetName = "ServiceData>>PatientRecords>>Delete",
                    result = Result.Success,
                    message = "ServiceData>>PatientRecords>>Delete Successfully Delete the Patient that ArchiveCode is " + mnArchiveCode
                };
                return result;
            }
            catch (Exception e)
            {
                result = new Status()
                {
                    index = "SD.PR.D002",
                    codeSnippetName = "ServiceData>>PatientRecords>>Delete",
                    result = Result.Error,
                    message = "ServiceData>>PatientRecords>>Delete An error ocurred when delete the PatientRecord that ArchiveCode is "+ mnArchiveCode + " The error messages is: " + e.Message
                };
                return result;
            }
            finally
            {
                mnUltrasoundConn.Close();
            }
        }

    }
}
