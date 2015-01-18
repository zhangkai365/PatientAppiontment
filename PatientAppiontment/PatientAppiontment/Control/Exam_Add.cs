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
        /// <summary>
        /// 将数据写入数据库中
        /// </summary>
        /// <param name="packageExam"></param>
        /// <returns></returns>
        public Status AddToDatabase(PackageExam packageExam)
        {
            Status result_AddToDataBase = new Status() { 
                codeSnippetName = "Control>>Exam_Add>>AddToDatabase", 
                result = Result.Initial, 
                message = "Initial.", 
                index = "Control.EA.ATD.009" };
            //超声数据库连接
            SqlConnection UltrasoundConnection = new SqlConnection(AppConnection.UltraSoundDataBaseConnectionString);
            //预约数据库
            SqlConnection AppiontmentConnection = new SqlConnection(AppConnection.AppiontmentDataBaseConnectionString);
            //同样的命令
            String mncmd = string.Format("Insert Into [PatientRecords] (ArchiveCode,PatientName,Sex,Age,AgeSymbol,FoundDate,States) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                packageExam.ArchiveCode,
                packageExam.PatientName,
                packageExam.Sex,
                packageExam.Age,
                packageExam.AgeSymbol,
                DateTime.Now,
                "预约后");
            string cmd_Abdominal = string.Format("",packageExam.Abdominal.ReservDate);

            //操作超声数据库的命令
            SqlCommand cmd_Ultrasound = new SqlCommand(mncmd,UltrasoundConnection);
            //操作预约数据库的命令
            SqlCommand cmd_Appiontment = new SqlCommand(mncmd, AppiontmentConnection);
            //执行结果
            int ResultLineNum_Ultrasound = 0;
            int ResultLineNum_Appiontment = 0;
            //添加事务的方式，不成功就回滚
            SqlTransaction SqlTransaction_Ultrasound = null;
            SqlTransaction SqlTransaction_Appiontment = null;
            //开始执行
            try
            {
                //打开连接
                UltrasoundConnection.Open();
                //事务开始
                SqlTransaction_Ultrasound = UltrasoundConnection.BeginTransaction();
                cmd_Ultrasound.Transaction = SqlTransaction_Ultrasound;
                ResultLineNum_Ultrasound = cmd_Ultrasound.ExecuteNonQuery();
                //打开预约数据库的连接
                AppiontmentConnection.Open();
                //事务开始
                SqlTransaction_Appiontment = AppiontmentConnection.BeginTransaction();
                cmd_Appiontment.Transaction = SqlTransaction_Appiontment;
                ResultLineNum_Appiontment = cmd_Appiontment.ExecuteNonQuery();
                //写入成功
                if (ResultLineNum_Ultrasound == 1 && ResultLineNum_Appiontment == 1)
                {
                    //写入成功就提交
                    SqlTransaction_Ultrasound.Commit();
                    SqlTransaction_Appiontment.Commit();
                    result_AddToDataBase.result = Result.Success;
                    result_AddToDataBase.message = "Complete saving the data into both database.";
                    result_AddToDataBase.index = "Control.EA.ATD.001";
                }
                //写入超声数据库失败，写入预约数据库成功
                if (ResultLineNum_Ultrasound == 0 && ResultLineNum_Appiontment == 1)
                {
                    result_AddToDataBase.result = Result.Fail;
                    result_AddToDataBase.message = "Failed to write into the Ultrasond database";
                    result_AddToDataBase.index = "Control.EA.ATD.000.1";
                }
                //写入超声数据库成功，写入预约数据库失败
                if (ResultLineNum_Ultrasound == 1 && ResultLineNum_Appiontment == 0)
                {
                    result_AddToDataBase.result = Result.Fail;
                    result_AddToDataBase.message = "Failed to write into the Appiontment database";
                    result_AddToDataBase.index = "Control.EA.ATD.000.2"; 
                }
                //写入超声数据库失败，写入预约数据库失败
                if (ResultLineNum_Ultrasound == 0 && ResultLineNum_Appiontment == 0)
                {
                    result_AddToDataBase.result = Result.Fail;
                    result_AddToDataBase.message = "Failed to write into Ultrasound and Appiontment database";
                    result_AddToDataBase.index = "Control.EA.ATD.000.3"; 
                }
            }
            catch (Exception e)
            {
                //产生错误，数据回滚
                SqlTransaction_Ultrasound.Rollback();
                //预约数据库回滚
                SqlTransaction_Appiontment.Rollback();
                //显示错误
                result_AddToDataBase.result = Result.Error;
                result_AddToDataBase.message = "An error occued." + e.Message;
                result_AddToDataBase.index = "Contrl.EA.ATD.002";
            }
            finally
            {
                //关闭数据库连接
                UltrasoundConnection.Close();
                AppiontmentConnection.Close();
            }
            return result_AddToDataBase;
        }
    }
}
