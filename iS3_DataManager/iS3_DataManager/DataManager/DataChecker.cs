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
        public DataSet dataSet { get; set; }
        public DataTable dataTable { get; set; }
        public DataStandardDef standardDef { get; set; }
        public DataChecker(DataTable table, DataStandardDef standard)
        {
            dataTable = table;
            standardDef = standard;
        }
        public DataChecker(DataSet set, DataStandardDef standard)
        {
            dataSet = set;
            standardDef = standard;

        }
        public bool Check()
        {
            try
            {
                if (dataSet != null)
                {
                    DomainDef domain = standardDef.DomainContainer.Find(x => x.Code == dataSet.DataSetName);
                    foreach (DataTable table in dataSet.Tables)
                    {
                        DGObjectDef objectDef = domain.DGObjectContainer.Find(x => x.Code == table.TableName);
                        CheckRows(table, objectDef);
                    }
                }
                else if (dataTable != null)
                {
                    DGObjectDef objectDef = standardDef.getDGObjectDefByCode(dataTable.TableName);
                    CheckRows(dataTable, objectDef);
                }
                return true;
            }
            catch(Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
                return false;
            }
            
        }

        private bool CheckRows(DataTable table, DGObjectDef objectDef)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "CheckResult.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            fs.Close();
            StreamWriter streamWriter = new StreamWriter(path: path, append: true);
            int line = 1;
            foreach (DataRow row in table.Rows)
            {
                int column = 1;
                foreach (PropertyMeta meta in objectDef.PropertyContainer)
                {
                    string time = "\t" + DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
                    if (meta.RegularExp != null)
                    {
                        if (row[meta.PropertyName] != null & !Regex.IsMatch(row[meta.PropertyName].ToString(), meta.RegularExp))
                        {
                            string message = "Data Format Error At sheet:" + objectDef.Code;
                            message += ",line:" + line++.ToString();
                            message += ",column:" + column++.ToString();
                            message += time;
                            streamWriter.WriteLine(message);
                        }
                    }
                    else
                    {
                        string message = "Lack of data check regulations at: " + objectDef.Code+"."+meta.PropertyName;
                        message += time;
                        streamWriter.WriteLine(message);
                    }
                }
            }
            streamWriter.Flush();
            streamWriter.Close();
            return false;
        }
    }
}
