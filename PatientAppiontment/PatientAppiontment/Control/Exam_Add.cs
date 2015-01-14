using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Include Project
using PatientAppiontment.Common;
using System.Data.SqlClient;
using PatientAppiontment.Data;

namespace PatientAppiontment.Control
{
    public class Exam_Add
    {
        public Status AddToDatabase(PackageExam packageExam)
        {
            Status result_AddToDataBase = new Status() { 
                codeSnippetName = "Control>>Exam_Add>>AddToDatabase", 
                result = Result.Initial, 
                message = "Initial.", 
                index = "Control.EA.ATD.009" };
            SqlConnection mnConnection = new SqlConnection(AppConnection.UltraSoundDataBaseConnectionString);           
            String mncmd = string.Format("Insert Into [PatientRecords] (ArchiveCode,PatientName,Sex,Age,AgeSymbol,FoundDate,States) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                packageExam.ArchiveCode,
                packageExam.PatientName,
                packageExam.Sex,
                packageExam.Age,
                packageExam.AgeSymbol,
                DateTime.Now,
                "预约后");
            SqlCommand cmd = new SqlCommand(mncmd,mnConnection);
            int ResultLineNum = 0;
            try
            {
                //打开连接
                mnConnection.Open();
                ResultLineNum = cmd.ExecuteNonQuery();
                if (ResultLineNum == 1)
                {
                    result_AddToDataBase.result = Result.Success;
                    result_AddToDataBase.message = "Succed saving the data to the database.";
                    result_AddToDataBase.index = "Control.EA.ATD.001";
                }
                if (ResultLineNum == 0)
                {
                    result_AddToDataBase.result = Result.Fail;
                    result_AddToDataBase.message = "Failed to write the data to the database";
                    result_AddToDataBase.index = "COntrol.EA.ATD.000";
                }
            }
            catch (Exception e)
            {
                result_AddToDataBase.result = Result.Error;
                result_AddToDataBase.message = "An error occued." + e.Message;
                result_AddToDataBase.index = "Contrl.EA.ATD.002";
            }
            finally
            {
                mnConnection.Close();
            }
            return result_AddToDataBase;
        }
    }
}
