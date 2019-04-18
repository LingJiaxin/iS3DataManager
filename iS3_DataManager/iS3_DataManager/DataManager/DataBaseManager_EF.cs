using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3_DataManager.Models;
using iS3_DataManager.ObjectModels;
using System.Data;
using System.Reflection;
using Newtonsoft.Json;

namespace iS3_DataManager.DataManager
{
    public class DataBaseManager_EF:iS3_DataManager.Interface.IDataBaseManager
    {

        public partial class GeologyDB_EF : DbContext
        {
            public DbSet<Borehole> Boreholes { get; set; }
        }


        
        public void Data2DB(DataSet dataSet, DataStandardDef standardDef)
        {
            try
            {
                string domainName = dataSet.DataSetName;
                foreach (DomainDef domain in standardDef.DomainContainer)
                {
                    if (domain.Code != domainName)
                    {
                        // get current assembly(程序集) 
                        Assembly assembly = Assembly.GetExecutingAssembly();

                        //create Entity for specific domain                   
                        dynamic db = assembly.CreateInstance("iS3_DataManager.DataManager." + domainName + "DB_EF");
                        //GeologyDB_EF db = new GeologyDB_EF();
                        foreach (DataTable table in dataSet.Tables)
                        {
                            DGObjectDef objectDef = GetObjectDef(domain,table);
                            Insert(db, objectDef, table);
                        }
                    }

                }
                System.Windows.MessageBox.Show("数据导入成功");
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
               
            }

        }

        /// <summary>
        /// 向entity中写入数据,实例形式
        /// </summary>
        /// <param name="db">entity实例</param>
        /// <param name="data">数据对象</param>
        /// <returns></returns>
        public bool BoreholeInsert(GeologyDB_EF db,DGObjectDef objectDef, DataTable table)
        {
            
            for (int i = 3; i < table.Rows.Count; i++)
            {
                int j = 0;
                List<object> data = new List<object>();
                foreach (PropertyMeta property in objectDef.PropertyContainer)
                {
                    data.Add(table.Rows[i][j.ToString()]);
                }

                Borehole borehole = new Borehole { };
                db.Boreholes.Add(borehole);
                
            }
            db.SaveChanges();
            return false;
        }

        /// <summary>
        /// 向entity中写入数据，SQL语句形式
        /// </summary>
        /// <param name="db">entity实例</param>
        /// <param name="data">数据对象</param>
        /// <returns></returns>
        public bool Insert(dynamic db,DGObjectDef objectDef,DataTable table)        
        {
            try
            {
                for (int i = 3; i < table.Rows.Count; i++)
                {
                    GeologyDB_EF test = new GeologyDB_EF();
                    int j = 0;
                    string sql = "INSERT INTO " + objectDef.Code;
                    string column = "(";
                    string value = " VALUES(";
                    foreach (PropertyMeta property in objectDef.PropertyContainer)
                    {
                        string dataCell = table.Rows[i][j++.ToString()].ToString();
                        if (dataCell != null)
                        {
                            column += property.PropertyName + ", ";
                            value += "'" + dataCell + "', ";
                        }
                    }
                    column += ")  ";
                    value += ")";
                    sql += column + value;
                    test.Database.ExecuteSqlCommand(sql);
                    test.SaveChanges();
                }
                return true;
            }
            catch(Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
                return false;
            }
            
        }

        /// <summary>
        /// 根据table名去寻找对应的数据类型
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public DGObjectDef GetObjectDef(DomainDef domain, DataTable table)
        {
            try
            {
                foreach (DGObjectDef objectDef in domain.DGObjectContainer)
                {
                    if (objectDef.Code == table.TableName) { return objectDef; }
                } return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

       
    }
}
