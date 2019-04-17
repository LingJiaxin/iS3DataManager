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

namespace iS3_DataManager.DataManager
{
    public class DataBaseManager_EF
    {

        public partial class GeologyDB_EF : DbContext
        {

            public DbSet<Borehole> Boreholes { get; set; }

        }

        public void Initial(DataStandardDef standardDef)
        {

            foreach (DomainDef domain in standardDef.DomainContainer)
            {

            }
        }

        public bool Data2DB(DataSet dataSet, DataStandardDef standardDef)
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
                        foreach (DataTable table in dataSet.Tables)
                        {
                            DGObjectDef objectDef = GetObjectDef(domain,table);

                        }
                    }

                }
                return true;
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary>
        /// 向entity中写入数据
        /// </summary>
        /// <param name="db">entity实例</param>
        /// <param name="data">数据对象</param>
        /// <returns></returns>
        public bool Insert(dynamic db, DGObjectDef objectDef,DataTable table)
        {
            foreach (PropertyMeta property in objectDef.PropertyContainer )
            {

            }
            return false;
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
