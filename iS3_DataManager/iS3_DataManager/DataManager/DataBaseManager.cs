using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using iS3_DataManager.Models;
using System.Data;
using System.IO;
using iS3_DataManager.Interface;

namespace iS3_DataManager.DataManager
{
    public class DataBaseManager: IDataBaseManager
    {
                  
        SQLiteConnection conn;
        SQLiteDataReader dataReader;

        void IDataBaseManager.WriteData(DataSet ds)
        {
            try
            {
                LinkDB();
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.ToString());
            }
        }

        public DataSet DB2Data()
        {
            return null;
        }
             

        public SQLiteDataReader ExecuteQuery(string queryString)
        {
            try
            {
                SQLiteCommand cmd=new SQLiteCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = queryString;
                dataReader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.ToString());
                return null;
            }

            return dataReader;
        }

        /// <summary>
        /// link2Default DataBase
        /// </summary>
        /// <returns></returns>
        private void LinkDB()
        {
            try
            {
                string defaultDB = "DefaultDB.db";
                if (!File.Exists(defaultDB))
                {
                    SQLiteConnection.CreateFile(defaultDB);
                }
                SQLiteConnection conn = new SQLiteConnection();
                SQLiteConnectionStringBuilder connStr = new SQLiteConnectionStringBuilder
                {
                    DataSource = defaultDB,
                    Password = "admin"
                };
                conn.ConnectionString = connStr.ToString();
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                string sql = "CREATE TABLE DefalutTable(username varchar(20),password varchar(20))";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                this.conn = conn;

            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.ToString());               
            }
        }

        public SQLiteDataReader CreateTable(string tableName, string[] colNames, string[] colTypes)
        {
            string queryString = "CREATE TABLE IF NOT EXISTS " + tableName + "( " + colNames[0] + " " + colTypes[0];
            for (int i = 1; i < colNames.Length; i++)
            {
                queryString += ", " + colNames[i] + " " + colTypes[i];
            }
            queryString += "  ) ";
            return ExecuteQuery(queryString);
        }

        /// <summary>
        /// 读表
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="items"></param>
        /// <param name="colNames"></param>
        /// <param name="operations"></param>
        /// <param name="colValues"></param>
        /// <returns></returns>
        public SQLiteDataReader ReadTable(string tableName, string[] items, string[] colNames, string[] operations, string[] colValues)
        {
            string queryString = "SELECT " + items[0];
            for (int i = 1; i < items.Length; i++)
            {
                queryString += ", " + items[i];
            }
            queryString += " FROM " + tableName + " WHERE " + colNames[0] + " " + operations[0] + " " + colValues[0];
            for (int i = 0; i < colNames.Length; i++)
            {
                queryString += " AND " + colNames[i] + " " + operations[i] + " " + colValues[0] + " ";
            }
            return ExecuteQuery(queryString);
        }

        

        
    }

}
