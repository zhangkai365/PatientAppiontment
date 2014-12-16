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
        /// 数据库地址
        /// </summary>
        public string DataSource
        {
            get { return _dataSource; }
            set { _dataSource = value; }
        }

        /// <summary>
        /// 数据库验证方式
        /// </summary>
        public bool IntegratedSecurity
        {
            get { return _intergratedSecurity; }
            set { _intergratedSecurity = value; }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public string InitialCatalog
        {
            get { return _initialCatalog; }
            set { _initialCatalog = value; }
        }

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
            _dataSource = @"192.168.1.1";
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
        private string Generation()
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
