using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Project Include
using System.Data.SqlClient;
using PatientAppiontment.Common;
using PatientAppiontment.Data;


namespace PatientAppiontment.Control
{
    /// <summary>
    /// 获取今日可用的预约号
    /// </summary>
    public class GetArchiveCode
    {

        public string Get()
        {
            //ArchiveCode 的三个组成部分 “6 20150101 0001” 
            //6 第一位不同计算机的编码，防止冲突
            //20150101 今日的日期
            //0001 四位的序号
            string _archiveCode = "";
            string _pcid = PCID._index.ToString();
            string _today_string = DateTime.Now.Date.ToString("yyyyMMdd");
            _archiveCode = _pcid + _today_string + "0001";
            SqlConnection mnSqlConnection = new SqlConnection(AppConnection.UltraSoundDataBaseConnectionString);
            try
            {
                mnSqlConnection.Open();
                DateTime today = DateTime.Now.Date;
                string mnCmdText = String.Format("SELECT [ArchiveCode] FROM [PatientRecords] WHERE [FoundDate] = '{0}' ORDER BY [ArchiveCode] DESC", today.ToString());
                SqlCommand mnCmd = new SqlCommand(mnCmdText, mnSqlConnection);
                //may occured error
                SqlDataReader mnDataReader = mnCmd.ExecuteReader();
                List<string> List_ArchiveCode = new List<string>();
                while (mnDataReader.Read())
                {
                    List_ArchiveCode.Add(mnDataReader.GetString(0));
                }
                if (List_ArchiveCode == null)
                {
                    System.Windows.Forms.MessageBox.Show("这是第一位预约病人,预约号为：" + _archiveCode);
                }
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
                                    _archiveCode = _pcid + _today_string + (todayIndex + 1).ToString().PadLeft(4, '0');
                                    break;
                                }
                            }
                        }
                    }
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
            return _archiveCode;
        }
    }
}
