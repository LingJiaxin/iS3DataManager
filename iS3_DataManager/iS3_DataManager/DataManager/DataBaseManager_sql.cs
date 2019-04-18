using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3_DataManager.Models;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using iS3_DataManager.Interface;

namespace iS3_DataManager.DataManager
{
    public class DataBaseManager_SQL : IDataBaseManager
    {
        //readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=..\default.mdf;Integrated Security=True;Connect Timeout=30";
        public void Data2DB(DataSet ds, DataStandardDef standardDef)
        {
            try
            {
                LinkDB();
                System.Windows.MessageBox.Show("数据导入成功");
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




        /// <summary>
        /// link2Default DataBase
        /// </summary>
        /// <returns></returns>
        private void LinkDB()
        {
            try
            {
                SqlConnection connection = new SqlConnection
                {
                    ConnectionString = connectionString
                };
                connection.Open();
                System.Windows.MessageBox.Show(connection.State.ToString());
                connection.Close();
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }

        void Insert(DataTable table, SqlConnection connection)
        {

            //var q = from c in connection select; 
        }




    }

}
