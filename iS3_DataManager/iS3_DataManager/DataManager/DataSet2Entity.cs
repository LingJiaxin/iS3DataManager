using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3_DataManager.Models;


namespace iS3_DataManager.DataManager
{
   public class DataSet2Entity
    {
        /// <summary>
        /// 通过反射 将dataRow 转化为实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="row"></param>
        /// <returns></returns>
        public  T CreatInstance<T>(DataRow row) where T : new()
        {
            var entity = new T();
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                //Get the description attribute
                var descriptionAttribute = property.GetCustomAttributes(typeof(T), true).SingleOrDefault();
                if (descriptionAttribute == null)
                    continue;

                property.SetValue(entity, row[""]);
            }
            return entity;
        }
        public void Data2DataBase(DataSet dataSet,StandardDef standard)
        {
            try
            {
                foreach (DataTable table in dataSet.Tables)
                {
                    DGObjectDef dGObject = standard.GetDGObjectDefByName(table.TableName);
                    string typeName = "iS3_DataManager.ObjectModels." + dGObject.Code;
                    Type type = Type.GetType(typeName);
                    var properties = type.GetProperties();
                    int count = properties.Length;
                    foreach (DataRow row in table.Rows)
                    {                        
                        object[] project = new object[35];
                        int index = 0;
                        foreach(PropertyMeta meta in dGObject.PropertyContainer)
                        {
                            project[index++]=row[meta.LangStr];
                        }
                        var instance=Activator.CreateInstance(type, project);
                    }
                }
            }
            catch (Exception x)
            {
                throw x;
            }
            
        }

    }
}
