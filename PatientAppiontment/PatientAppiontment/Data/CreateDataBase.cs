using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Project include
using System.Data.SqlClient;

namespace PatientAppiontment.Data
{
    public class CreateDataBase
    {
        private string connectionString = @"Data Source = 192.168.1.70; User ID = zhangkai365; Password = @Zhangkai851983; ";
        public bool IsDataBaseExsit()
        {
            bool isDataBaseExsit = false;
            SqlConnection mnSqlConnection = new SqlConnection(connectionString);
            mnSqlConnection.Open();
            try
            {
                string cmdText = @"SELECT 1 FROM [master]..[sysdatabases] WHERE name = 'engchaosheng' ";
                SqlCommand mnSqlCommand = new SqlCommand(cmdText,mnSqlConnection);
                SqlDataReader mnDataReader = mnSqlCommand.ExecuteReader();
                if (mnDataReader.Read())
                {
                    isDataBaseExsit = true;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("在测试数据库是否存在时出错了！"+ e.Message.ToString());
            }
            finally
            {
                mnSqlConnection.Close();
            }
            System.Windows.Forms.MessageBox.Show("数据库存在。");
            return isDataBaseExsit;
        }
        public bool Create()
        {
            bool isDataBaseCreateSuccess = false;
            if (IsDataBaseExsit()) return isDataBaseCreateSuccess;
            SqlConnection mnSqlConnection = new SqlConnection(connectionString);
            mnSqlConnection.Open();
            string cmdText = @"CREAT DATABASE appiontment";
            SqlCommand mnSqlCommand = new SqlCommand(cmdText, mnSqlConnection);
            int result = mnSqlCommand.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show(result.ToString());
            return true;
        }
    }
}
