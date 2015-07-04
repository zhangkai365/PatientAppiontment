using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//include
using PatientAppointment.Common;
using System.Data.SqlClient;
using PatientAppointment.DataBase;

namespace PatientAppointment.ServiceData
{
    class PatientCheckDelete
    {
        public Status Delete(string mnCheckCode)
        {
            Status result = new Status() { 
                codeSnippetName = "DataService>>PatientCheckDelete>>Delete",
                index = "DS.30000",
                result = Result.Initial,
                message = "DataService>>PatientCheckDelete>>Delete intial" 
            };

            string sqlText = "DELETE FROM [PatientCheck] WHERE CheckCode = @CheckCode ";
            SqlConnection mnDatabaseConnection = new SqlConnection(DataBaseConnection.UltraSoundConnectionString);
            SqlCommand mnSqlCommand = new SqlCommand(sqlText,mnDatabaseConnection);
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
