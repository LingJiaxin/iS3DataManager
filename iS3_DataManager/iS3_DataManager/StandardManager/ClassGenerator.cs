using System.Data;
using Newtonsoft.Json;
using iS3_DataManager.Models;
using System;
using System.Collections.Generic;


namespace iS3_DataManager.StandardManager
{
    public class ClassGenerator
    {
        public void generateClass(DataSet ds)
        {try
            {
                List<List<string>> list = new List<List<string>>();
                foreach (DataTable dataTable in ds.Tables)
                {
                    DataRow dataRow= dataTable.Rows[2];
                    //for (int i = 0; i ; i++)
                    //{

                    //}
                }
                
            }
            catch(Exception e)
            {
                System.Windows.MessageBox.Show(e.ToString());
                
            }
        }
    }
}
