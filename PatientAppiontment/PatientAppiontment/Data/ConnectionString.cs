using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//project include
using System.Data.SqlClient;

namespace PatientAppiontment.Data
{
    /// <summary>
    /// 数据库连接字符串
    /// </summary>
    public class ConnectionString
    {
        public static string _dataSource;
        public static bool _intergratedSecurity = false;
        public static string _userID;
        public static string _password;
        public static string _initialCatalog;
        /// <summary>
        /// 最终的连接字符串
        /// </summary>
        public static string Setting;

        /// <summary>
        /// 构造函数，生成默认的连接字符串
        /// </summary>
        public ConnectionString()
        {
        }

        public void Initial()
        {
            Reset();
        }

        /// <summary>
        /// 重置连接字符串
        /// </summary>
        public void Reset()
        {
            _dataSource = @"192.168.1.70";
            _intergratedSecurity = false;
            _userID = @"zhangkai365";
            _password = @"@Zhangkai851983";
            _initialCatalog = @"engchaosheng";
            Setting = Generation();
        }

        /// <summary>
        /// 生成连接字符串
        /// </summary>
        /// <returns></returns>
        private String Generation()
        {
            SqlConnectionStringBuilder _sqlConnectionString = new SqlConnectionStringBuilder();
            _sqlConnectionString.DataSource = _dataSource;
            _sqlConnectionString.IntegratedSecurity = _intergratedSecurity;
            _sqlConnectionString.UserID = _userID;
            _sqlConnectionString.Password = _password;
            _sqlConnectionString.InitialCatalog = _initialCatalog;
            return _sqlConnectionString.ConnectionString;
        }

        public void Update()
        {
            Setting = Generation();
        }
    }
}
