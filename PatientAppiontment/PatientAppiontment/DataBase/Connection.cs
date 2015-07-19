using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//project include
using System.Data.SqlClient;

namespace PatientAppointment.DataBase
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

    public class DataBaseConnection
    {
        /// <summary>
        /// 预约数据库连接字符串分项
        /// </summary>
        public static ConnectionGroup AppointmentConnectionGroup = new ConnectionGroup() { 
            caption = @"预约数据库", 
            dataSource = @"192.168.1.70", 
            intergratedSecurity = false, 
            userID = @"zhangkai365", 
            password = @"@Zhangkai851983", 
            initialCatalog = @"appiontment" 
        };
        /// <summary>
        /// 超声工作站数据库连接字符串分项
        /// </summary>
        public static ConnectionGroup UltraSoundConnectionGroup = new ConnectionGroup() { 
            caption = @"超声工作站", 
            dataSource = @"192.168.1.70", 
            intergratedSecurity = false, 
            userID = @"zhangkai365", 
            password = @"@Zhangkai851983", 
            initialCatalog = @"engchaosheng" 
        };
        /// <summary>
        /// 预约数据库的完整字符串
        /// </summary>
        public static string AppointmentConnectionString = @"Data Source = 192.168.1.70; User ID = zhangkai365; Password = @Zhangkai851983; Initial Catalog = Appointment;" ;
        /// <summary>
        /// 超声工作站数据库的完整字符串
        /// </summary>
        public static string UltraSoundConnectionString = @"Data Source = 192.168.1.70; User ID = zhangkai365; Password = @Zhangkai851983; Initial Catalog = engchaosheng;"; 
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
            DataBaseConnection.AppointmentConnectionGroup.caption = @"超声工作站数据库";
            DataBaseConnection.AppointmentConnectionGroup.dataSource = @"192.168.1.70";
            DataBaseConnection.AppointmentConnectionGroup.intergratedSecurity = false;
            DataBaseConnection.AppointmentConnectionGroup.userID = @"zhangkai365";
            DataBaseConnection.AppointmentConnectionGroup.password = @"@Zhangkai851983";
            DataBaseConnection.AppointmentConnectionGroup.initialCatalog = @"appointment";

            DataBaseConnection.UltraSoundConnectionGroup.caption = @"预约数据库";
            DataBaseConnection.UltraSoundConnectionGroup.dataSource = @"192.168.1.70";
            DataBaseConnection.UltraSoundConnectionGroup.intergratedSecurity = false;
            DataBaseConnection.UltraSoundConnectionGroup.password = @"@Zhangkai851983";
            DataBaseConnection.UltraSoundConnectionGroup.userID = @"zhangkai365";
            DataBaseConnection.UltraSoundConnectionGroup.initialCatalog = @"engchaosheng";

            DataBaseConnection.AppointmentConnectionString = Generation(DataBaseConnection.AppointmentConnectionGroup);
            DataBaseConnection.UltraSoundConnectionString = Generation(DataBaseConnection.UltraSoundConnectionGroup);
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
                DataBaseConnection.AppointmentConnectionGroup.dataSource = updateConection.dataSource;
                DataBaseConnection.AppointmentConnectionGroup.initialCatalog = updateConection.initialCatalog;
                DataBaseConnection.AppointmentConnectionGroup.intergratedSecurity = updateConection.intergratedSecurity;
                DataBaseConnection.AppointmentConnectionGroup.userID = updateConection.userID;
                DataBaseConnection.AppointmentConnectionGroup.password = updateConection.password;
                DataBaseConnection.AppointmentConnectionString = Generation(updateConection);
                return true;
            }
            if (updateTarget == 1)
            {
                DataBaseConnection.UltraSoundConnectionGroup.dataSource = updateConection.dataSource;
                DataBaseConnection.UltraSoundConnectionGroup.initialCatalog = updateConection.initialCatalog;
                DataBaseConnection.UltraSoundConnectionGroup.intergratedSecurity = updateConection.intergratedSecurity;
                DataBaseConnection.UltraSoundConnectionGroup.userID = updateConection.userID;
                DataBaseConnection.UltraSoundConnectionGroup.password = updateConection.password;
                DataBaseConnection.UltraSoundConnectionString = Generation(updateConection);
                return true;
            }
            return false;
        }
    }

}
