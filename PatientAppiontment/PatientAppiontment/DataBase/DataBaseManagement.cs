using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Project include
using System.Data.SqlClient;
using PatientAppointment.Common;

namespace PatientAppointment.DataBase
{
    /// <summary>
    /// Appointment数据库管理
    /// </summary>
    public class DataBaseManagement
    {
        /// <summary>
        /// Appointment数据库连接字符串
        /// </summary>
        private string connWithoutDatabase = @"Data Source = 192.168.1.70; User ID = zhangkai365; Password = @Zhangkai851983; ";
        private string connWithDatabase = @"Data Source = 192.168.1.70; User ID = zhangkai365; Password = @Zhangkai851983; Initial Catalog = Appointment; ";
        /// <summary>
        /// 检测Appointment数据库是否存在
        /// </summary>
        /// <returns></returns>
        public Status_Existence DatabaseExistStatus()
        {
            //默认的返回值，是程序运行出现错误
            Status_Existence status_Exist = new Status_Existence() { 
                codeSnippetName = @"Data>>DataBaseManagement>>DataBaseExistStatus",
                exsitence = Existence.Initial,
                message = @"This is the initial Exsistence",
                index = @"Data.DBM.009" };
            SqlConnection mnSqlConnection = new SqlConnection(connWithoutDatabase);
            mnSqlConnection.Open();
            try
            {
                string cmdText = @"SELECT 1 FROM [master]..[sysdatabases] WHERE name = 'Appointment' ";
                SqlCommand mnSqlCommand = new SqlCommand(cmdText,mnSqlConnection);
                SqlDataReader mnDataReader = mnSqlCommand.ExecuteReader();
                if (mnDataReader.Read())
                {
                    status_Exist.exsitence = Existence.Yes;
                    status_Exist.message = @"Appointment DataBase is exist.";
                    status_Exist.index = @"Data.DBM.001";
                }
                else
                {
                    status_Exist.exsitence = Existence.No;
                    status_Exist.message = @"DataBase don't exist.";
                    status_Exist.index = @"Data.DBM.000";
                }
            }
            catch (Exception e)
            {
                status_Exist.exsitence = Existence.Unknown;
                status_Exist.message = @"Programe error," + e.Message.ToString();
                status_Exist.index = @"Data.DBM.002";
            }
            finally
            {
                mnSqlConnection.Close();
            }
            return status_Exist;
        }
        /// <summary>
        /// 创建Appointment数据库
        /// </summary>
        /// <returns></returns>
        public Status CreateDatabase()
        {
            Status status_CreateDatabase = new Status() { 
                codeSnippetName = @"Data>>DataBaseManagement>>Create",
                result = Result.Initial,
                message = @"This is the initial status.",
                index = @"Data.DBM.C.009" };
            //检测Appointment数据库是否存在
            Status_Existence status_Existence = DatabaseExistStatus();
            if (!(status_Existence.exsitence == Existence.No))
            {
                status_CreateDatabase.result = Result.Fail;
                status_CreateDatabase.message = @"Appointment DataBase already exists or its exsistence is Unknown!";
                status_CreateDatabase.index = @"Data.DBM.C.000";
                return status_CreateDatabase;
            }
            SqlConnection mnSqlConnection = new SqlConnection(connWithoutDatabase);
            try
            {
                //may cause error
                mnSqlConnection.Open();
                string cmdText = @"CREATE DATABASE Appointment";    
                SqlCommand mnSqlCommand = new SqlCommand(cmdText, mnSqlConnection);
                //may cause error
                int result = mnSqlCommand.ExecuteNonQuery();
                status_CreateDatabase.result = Result.Success;
                status_CreateDatabase.message = @"Finished Creating the Appointment database.";
                status_CreateDatabase.index = @"Data.DBM.C.001";
            }
            catch (Exception e)
            {
                status_CreateDatabase.result = Result.Error;
                status_CreateDatabase.message = @"There is an error when the Appointment database is creating." + e.Message;
                status_CreateDatabase.index = @"Data.DBM.C.002";
            }
            finally
            {
                mnSqlConnection.Close();
            }
            return status_CreateDatabase;
        }

        /// <summary>
        /// 在Appointment数据库当中新建表
        /// </summary>
        /// <returns></returns>
        public Status CreateTable()
        {
            Status status_CreateTable = new Status() {
                codeSnippetName = @"Data>>DataBaseManagement>>CreateTable",
                result = Result.Initial,
                message = @"This is the initial status of creating table.",
                index = @"Data.DBM.CT.009" };
            Status_Existence checkDataBaseExsitence = DatabaseExistStatus();
            if (!(checkDataBaseExsitence.exsitence == Existence.Yes))
            {
                status_CreateTable.result = Result.Fail;
                status_CreateTable.message = @"Failed to create the tables of Appionetment database. because there is no existence of Appointment database.";
                status_CreateTable.index = @"Data.DBM.CT.000";
                return status_CreateTable;
            }
            SqlConnection mnSqlConnection = new SqlConnection(connWithDatabase);
            try
            {
                //may occure error
                mnSqlConnection.Open();
                string cmdText2 = @"CREATE TABLE PatientRecords(ArchiveCode varchar(50) NOT NULL, PatientName varchar(50), Sex varchar(50), Age int, AgeSymbol varchar(50), FoundDate datetime, States carchar(50))";
                SqlCommand cmd = new SqlCommand(cmdText2, mnSqlConnection);
                //may occure error
                cmd.ExecuteNonQuery();
                status_CreateTable.result = Result.Success;
                status_CreateTable.message = @"Tables are successfully created.";
                status_CreateTable.index = @"Data.DBM.CT.001";
            }
            catch (Exception e)
            {
                status_CreateTable.result = Result.Error;
                status_CreateTable.message = @"An error occured while creating the tables." + e.Message;
                status_CreateTable.index = @"Data.DBM.CT.002";
            }
            finally
            {
                mnSqlConnection.Close();
            }
            return status_CreateTable;
        }

        public Status CreateDatabaseAndTables()
        {
            Status status_CreateDataBaseAndTables = new Status() {
                codeSnippetName = @"Data>>DataBaseManagement>>CreateDataBaseAndTables",
                result = Result.Initial,
                message = @"This is the initial of creating database and tables",
                index = @"Data.DBM.CDAT.009" };
            Status status_CreateDataBase = CreateDatabase();
            if (!(status_CreateDataBase.result == Result.Success)) return status_CreateDataBase;
            Status status_CreateTables = CreateTable();
            if (!(status_CreateTables.result == Result.Success)) return status_CreateTables;
            return new Status() { 
                codeSnippetName = @"Data>>DataBaseManagement>>CreateDatabaseAndTables", 
                result = Result.Success, 
                message = @"Create database and tables succesfully.",
                index = @"Data.DBM.CT.001" };
        }
    }
}
