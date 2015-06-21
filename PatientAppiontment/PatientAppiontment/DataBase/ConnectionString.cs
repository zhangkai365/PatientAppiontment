using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//project include
using System.Data.SqlClient;

namespace PatientAppiontment.DataBase
{
    public class ConnectionGroup
    {
        public string dataSource;
        public bool intergratedSecurity = false;
        public string userID;
        public string password;
        public string initialCatalog;
        public string caption;
    }

    public class AppConnection
    {
        /// <summary>
        /// 预约数据库连接字符串分项
        /// </summary>
        public static ConnectionGroup AppiontmentDataBaseConnectionGroup = new ConnectionGroup() { 
            caption = @"预约数据库", 
            dataSource = @"192.168.1.70", 
            intergratedSecurity = false, 
            userID = @"zhangkai365", 
            password = @"@Zhangkai851983", 
            initialCatalog = @"engchaosheng" };
        /// <summary>
        /// 超声工作站数据库连接字符串分项
        /// </summary>
        public static ConnectionGroup UltraSoundDataBaseConnectionGroup = new ConnectionGroup() { 
            caption = @"超声工作站", 
            dataSource = @"192.168.1.70", 
            intergratedSecurity = false, 
            userID = @"zhangkai365", 
            password = @"@Zhangkai851983", 
            initialCatalog = @"appiontment" };
        /// <summary>
        /// 预约数据库的完整字符串
        /// </summary>
        public static string AppiontmentDataBaseConnectionString = @"Data Source = 192.168.1.70; User ID = zhangkai365; Password = @Zhangkai851983; Initial Catalog = appiontment;" ;
        /// <summary>
        /// 超声工作站数据库的完整字符串
        /// </summary>
        public static string UltraSoundDataBaseConnectionString = @"Data Source = 192.168.1.70; User ID = zhangkai365; Password = @Zhangkai851983; Initial Catalog = engchaosheng;"; 
    }

    /// <summary>
    /// 数据库连接字符串
    /// </summary>
    public class ConnectionMethod
    {

        /// <summary>
        /// 构造函数，生成默认的连接字符串
        /// </summary>
        public ConnectionMethod()
        {
        }

        /// <summary>
        /// 重置Ultrasound数据库和Appointment数据库的连接字符串
        /// </summary>
        public void Reset()
        {
            AppConnection.AppiontmentDataBaseConnectionGroup.caption = @"超声工作站数据库";
            AppConnection.AppiontmentDataBaseConnectionGroup.dataSource = @"192.168.1.70";
            AppConnection.AppiontmentDataBaseConnectionGroup.intergratedSecurity = false;
            AppConnection.AppiontmentDataBaseConnectionGroup.userID = @"zhangkai365";
            AppConnection.AppiontmentDataBaseConnectionGroup.password = @"@Zhangkai851983";
            AppConnection.AppiontmentDataBaseConnectionGroup.initialCatalog = @"engchaosheng";

            AppConnection.UltraSoundDataBaseConnectionGroup.caption = @"预约数据库";
            AppConnection.UltraSoundDataBaseConnectionGroup.dataSource = @"192.168.1.70";
            AppConnection.UltraSoundDataBaseConnectionGroup.intergratedSecurity = false;
            AppConnection.UltraSoundDataBaseConnectionGroup.password = @"@Zhangkai851983";
            AppConnection.UltraSoundDataBaseConnectionGroup.userID = @"zhangkai365";
            AppConnection.UltraSoundDataBaseConnectionGroup.initialCatalog = @"appiontment";

            AppConnection.AppiontmentDataBaseConnectionString = Generation(AppConnection.AppiontmentDataBaseConnectionGroup);
            AppConnection.UltraSoundDataBaseConnectionString = Generation(AppConnection.UltraSoundDataBaseConnectionGroup);
        }

        /// <summary>
        /// 生成连接字符串
        /// </summary>
        /// <returns></returns>
        private String Generation(ConnectionGroup _mnConnection)
        {
            SqlConnectionStringBuilder _sqlConnectionString = new SqlConnectionStringBuilder();
            _sqlConnectionString.DataSource = _mnConnection.dataSource;
            _sqlConnectionString.IntegratedSecurity = _mnConnection.intergratedSecurity;
            _sqlConnectionString.UserID = _mnConnection.userID;
            _sqlConnectionString.Password = _mnConnection.password;
            _sqlConnectionString.InitialCatalog = _mnConnection.initialCatalog;
            return _sqlConnectionString.ConnectionString;
        }

        /// <summary>
        /// 根据程序当中的设置值修改连接设置
        /// </summary>
        /// <param name="updateTarget"></param>
        /// <param name="updateConection"></param>
        /// <returns></returns>
        public bool Update(int updateTarget,ConnectionGroup updateConection)
        {
            if (updateTarget == 0)
            {
                AppConnection.AppiontmentDataBaseConnectionGroup.dataSource = updateConection.dataSource;
                AppConnection.AppiontmentDataBaseConnectionGroup.initialCatalog = updateConection.initialCatalog;
                AppConnection.AppiontmentDataBaseConnectionGroup.intergratedSecurity = updateConection.intergratedSecurity;
                AppConnection.AppiontmentDataBaseConnectionGroup.userID = updateConection.userID;
                AppConnection.AppiontmentDataBaseConnectionGroup.password = updateConection.password;
                AppConnection.AppiontmentDataBaseConnectionString = Generation(updateConection);
                return true;
            }
            if (updateTarget == 1)
            {
                AppConnection.UltraSoundDataBaseConnectionGroup.dataSource = updateConection.dataSource;
                AppConnection.UltraSoundDataBaseConnectionGroup.initialCatalog = updateConection.initialCatalog;
                AppConnection.UltraSoundDataBaseConnectionGroup.intergratedSecurity = updateConection.intergratedSecurity;
                AppConnection.UltraSoundDataBaseConnectionGroup.userID = updateConection.userID;
                AppConnection.UltraSoundDataBaseConnectionGroup.password = updateConection.password;
                AppConnection.UltraSoundDataBaseConnectionString = Generation(updateConection);
                return true;
            }
            return false;
        }
    }
}
