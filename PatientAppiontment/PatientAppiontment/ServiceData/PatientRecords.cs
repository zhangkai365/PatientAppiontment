using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//include
using PatientAppointment.Common;
using System.Data.SqlClient;

namespace PatientAppointment.ServiceData
{
    class PatientRecords
    {
        public Status Create(DataPackage.DataPackPatientRecords mnDataPackPatientRecodes)
        {
            Status result = new Status(){
                 codeSnippetName = "ServiceData>>PatientRecord>>Create",
                 index = "SD.01.01.00",
                 result = Result.Initial,
                 message = "ServiceData>>PatientRecords>>Create intial."
            };
            //要连接的数据库
            SqlConnection ultrasoundConn = new SqlConnection(DataBase.DataBaseConnection.UltraSoundConnectionString);
            string SqlCommandText = "INSERT INTO [PatientRecords]"+
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
                "Stuff"+
                " VALUES("+
                "'@ArchiveCode',"+
                "'@PatientName',"+
                "'@Sex',"+
                "'@Age',"+
                "'@AgeSymbol',"+
                "'@PrintSymbol',"+
                "'@States',"+
                "'@Contacts',"+
                "'@InsuranceNum',"+
                "'@FoundDate',"+
                "'@MarriageState',"+
                "'@PregnancyTimes',"+
                "'@ProcreationTimes',"+
                "'@Remark',"+
                "'@ModifyTimes',"+
                "'@Stuff'"+
                ")";
            SqlCommand mnSqlCommand = new SqlCommand(SqlCommandText,ultrasoundConn);
            //填充参数
            //ArchiveCode
            SqlParameter mnPara = new SqlParameter();
            mnPara.ParameterName = "@ArchiveCode";
            mnPara.Value = mnDataPackPatientRecodes.ArchiveCode;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //PatientName
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@PatientName";
            mnPara.Value = mnDataPackPatientRecodes.PatientName;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //Sex
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Sex";
            mnPara.Value = mnDataPackPatientRecodes.Sex;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //Age
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@Age";
            mnPara.Value = mnDataPackPatientRecodes.Age;
            mnPara.SqlDbType = System.Data.SqlDbType.Int;
            mnSqlCommand.Parameters.Add(mnPara);
            //AgeSymbol
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@AgeSymbol";
            mnPara.Value = mnDataPackPatientRecodes.AgeSymbol;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);
            //PrintSymbol
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@PrintSymbol";
            mnPara.Value = mnDataPackPatientRecodes.PrintSymbol;
            mnPara.SqlDbType = System.Data.SqlDbType.Int;
            mnSqlCommand.Parameters.Add(mnPara);
            //States
            mnPara = new SqlParameter();
            mnPara.ParameterName = "@States";
            mnPara.Value = mnDataPackPatientRecodes.States;
            mnPara.SqlDbType = System.Data.SqlDbType.VarChar;
            mnPara.Size = 50;
            mnSqlCommand.Parameters.Add(mnPara);








            return result;
        }

        public Status Update()
        {
            return new Status();
        }

        public Status Delete()
        {
            return new Status();
        }
    }
}
