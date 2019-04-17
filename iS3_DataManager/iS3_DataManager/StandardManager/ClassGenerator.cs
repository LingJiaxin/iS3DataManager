using System.Data;
using Newtonsoft.Json;
using iS3_DataManager.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace iS3_DataManager.StandardManager
{
    public class ClassGenerator
    {
        public void generateClass( DomainDef domain)
        {try
            {
                List<List<string>> list = new List<List<string>>();
                foreach (DGObjectDef dGObject in domain.DGObjectContainer)
                {
                    List<string> property = new List<string>();
                    List<string> type = new List<string>();

                    foreach (PropertyMeta meta in dGObject.PropertyContainer)
                    {
                        property.Add(meta.PropertyName);
                        type.Add(meta.DataType);
                    }
                    string newClass = @"using System; \n namespace iS3_DataManager.Models\n {\n public class "+dGObject.Code+"\n {";
                    for(int i = 0; i < property.Count; i++)
                    {
                        newClass += "public " + type[i] + " " + property[i] + " {get;set;}\n";
                    }
                    newClass += "}\n}";
                    string path = AppDomain.CurrentDomain.BaseDirectory + dGObject.Code + ".cs";
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(newClass);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
                
            }
            catch(Exception e)
            {
                System.Windows.MessageBox.Show(e.ToString());
                
            }
        }
        
    }
}
