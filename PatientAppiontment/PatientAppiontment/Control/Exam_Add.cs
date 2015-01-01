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
        public DataPackage myDataPackage
        {
            get;
            set;
        }

        public Status AddToDataBase(DataPackage dataPackage)
        {
            SqlConnection mnConnection = new SqlConnection(AppConnection.UltraSoundDataBaseConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("Insert Into [PatientRecords] (ArchiveCode,PatientName,Sex,Age,AgeSymbol,FoundDate) Values ('{0}','{1}','{2}','{3}',{4},{5})",
                dataPackage.ArchiveCode,
                dataPackage.PatientName,
                dataPackage.PatientSex,
                dataPackage.PatientAge,
                dataPackage.PatientAgeSymbol,
                DateTime.Now);
            int ResultLineNum = 0;
            try
            {
                ResultLineNum = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("出错了！");
                return new Status() {
                    result = Result.Success, 
                    Message = @"Successful compelete Add the new patient data to base.", 
                    CodeSnippetName = @"AddToDataBase", 
                    MesgDicIndex = @"C.0001"};
            }
            return new Status() { 
 };
        }
    }
}
