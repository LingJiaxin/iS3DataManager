using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using iS3_DataManager.Models;
using System.IO;

namespace iS3_DataManager.DataManager
{
    public class DataChecker
    {
        public bool Check(DataSet dataSet, DataStandardDef dataStandard)
        {

            DomainDef domain = dataStandard.DomainContainer.Find(x => x.Code == dataSet.DataSetName);
            foreach (DataTable table in dataSet.Tables)
            {
                DGObjectDef objectDef = domain.DGObjectContainer.Find(x => x.Code == table.TableName);
                
            }
            return false;
        }

        private bool CheckRows(DataTable table,DGObjectDef objectDef)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"..\..\OutPut\CheckResult.txt";
            FileStream fs = new FileStream(path,FileMode.OpenOrCreate);
            fs.Close();
            StreamWriter streamWriter = new StreamWriter(path:path,append:true);
            int line = 1;
            foreach(DataRow row in table.Rows)
            {
                int column = 1;
                foreach (PropertyMeta meta in objectDef.PropertyContainer)
                {
                    if (!Regex.IsMatch(row[meta.PropertyName].ToString(), meta.RegularExp))
                    {
                        string message = "Data Format Error At sheet:" + objectDef.Code;
                        message += ",line:" + line++.ToString();
                        message += ",column:" + column++.ToString();
                        streamWriter.WriteLine(message);
                    }
                }
            }
            return false;
        }
    }
}
