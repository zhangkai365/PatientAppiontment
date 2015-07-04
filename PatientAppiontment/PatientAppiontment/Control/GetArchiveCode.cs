using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Project Include
using System.Data.SqlClient;
using PatientAppointment.Common;
using PatientAppointment.DataBase;


namespace PatientAppointment.Control
{
    /// <summary>
    /// 获取今日可用的预约号
    /// </summary>
    public class GetArchiveCode
    {
        /// <summary>
        /// 检查数据库中是否已经有相应的ArchiveCode，避免冲突
        /// </summary>
        /// <param name="archiveCode"></param>
        /// <param name="databaseConnection"></param>
        /// <returns></returns>
        public bool NoConflict(string archiveCode,string databaseConnection)
        {
            bool noConflict = false;
            SqlConnection mnSqlConnection = new SqlConnection(databaseConnection);
            string cmd = string.Format("SELECT [ArchiveCode] FROM [PatientRecords] WHERE [ArchiveCode] = '{0}'", archiveCode);
            SqlCommand mncmd = new SqlCommand(cmd, mnSqlConnection);
            try
            {
                mnSqlConnection.Open();
                SqlDataReader mnSqlDataReader = mncmd.ExecuteReader();
                //如果查询没有结果，证明没有冲突
                if (mnSqlDataReader.Read())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                mnSqlConnection.Close();
            }
            return noConflict;
        }
        /// <summary>
        /// 获取ArchiveCode，以Ultrasound数据库为准
        /// </summary>
        /// <param name="archiveCode"></param>
        /// <returns></returns>
        public Status Get(out string archiveCode)
        {
            //输出编码，如果有错误，输出为空
            archiveCode = "";
            //初始化结果
            Status result = new Status(){ 
                codeSnippetName = "Control>>GetArchiveCode>>Get",
                result = Result.Initial,
                message = "Initial",
                index = "Control.GA.G.009"};
            //ArchiveCode 的三个组成部分 “6 20150101 0001” 
            //6 第一位不同计算机的编码，防止冲突
            //20150101 今日的日期
            //0001 四位的序号
            string _archiveCode = "";
            string _pcid = PCID._index.ToString();
            string _today_string = DateTime.Now.Date.ToString("yyyyMMdd");
            _archiveCode = _pcid + _today_string + "0001";
            //初始化查询语句
            SqlConnection mnSqlConnection = new SqlConnection(DataBaseConnection.UltraSoundConnectionString);
            DateTime today = DateTime.Now.Date;
            string mnCmdText = String.Format("SELECT [ArchiveCode] FROM [PatientRecords] WHERE [FoundDate] = '{0}' ORDER BY [ArchiveCode] DESC", today.ToString());
            try
            {
                mnSqlConnection.Open();
                SqlCommand mnCmd = new SqlCommand(mnCmdText, mnSqlConnection);
                //may occured error
                SqlDataReader mnDataReader = mnCmd.ExecuteReader();
                List<string> List_ArchiveCode = new List<string>();
                //根据查询结果，看看今天是否已经有预约病人
                while (mnDataReader.Read())
                {
                    List_ArchiveCode.Add(mnDataReader.GetString(0));
                }
                //如果查询结果为空，就认为是第一位预约病人
                if (List_ArchiveCode.Count() == 0)
                {
                    for (int i = 0; i < 999; i++)
                    {
                        _archiveCode = _pcid + _today_string + i.ToString().PadLeft(4, '0');
                        if (NoConflict(_archiveCode, DataBaseConnection.UltraSoundConnectionString) && NoConflict(_archiveCode, DataBaseConnection.AppointmentConnectionString))
                        {
                            result.result = Result.Success;
                            result.message = "Succed. The first person make the Appointment today.";
                            result.index = "Control.GAC.G.001";
                            archiveCode = _archiveCode;
                            return result;
                        }
                    }
                }
                //不是第一位预约病人
                else
                {

                    foreach (string mnstring in List_ArchiveCode)
                    {
                        if (mnstring.Count() == 13)
                        {
                            string ArchiveCodePCID_string = "";
                            ArchiveCodePCID_string = mnstring.Substring(0, 1);
                            int ArchiveCodePCID_int = 0;
                            bool reslut_Parse = int.TryParse(ArchiveCodePCID_string, out ArchiveCodePCID_int);
                            //may occured error
                            int todayIndex = 0;
                            string todayLastArchiveCode = "";
                            if (reslut_Parse == true && ArchiveCodePCID_int == PCID._index)
                            {
                                todayLastArchiveCode = mnstring.Substring(9, 4);
                                bool result_ParseTodayLastArchiveCode = int.TryParse(todayLastArchiveCode, out todayIndex);
                                if (result_ParseTodayLastArchiveCode == true)
                                {
                                    for (int i1 = 0; i1 < 999; i1++)
                                    {
                                        _archiveCode = _pcid + _today_string + (todayIndex + i1).ToString().PadLeft(4, '0');
                                        if (NoConflict(_archiveCode, DataBaseConnection.UltraSoundConnectionString) && NoConflict(_archiveCode, DataBaseConnection.AppointmentConnectionString))
                                        {
                                            result.result = Result.Success;
                                            result.message = "Succed. ArchiveCode has been given.";
                                            result.index = "Control.GAC.G.001";
                                            archiveCode = _archiveCode;
                                            return result;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }//else 结束 不是第一位预约患者的流程
                result.result = Result.Fail;
                result.message = "Unable to get an availabe ArchiveCode.Try another day.";
                result.index = "Control.GAC.G.000";
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                result.result = Result.Error;
                result.message = "Error occured." + e.Message;
                result.index = "Control.GAC.G.002";
            }
            finally
            {
                mnSqlConnection.Close();
            }
            return result;
        }
    }
}
