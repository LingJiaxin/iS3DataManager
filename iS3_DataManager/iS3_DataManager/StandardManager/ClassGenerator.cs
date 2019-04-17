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
        public void GenerateClass(DataStandardDef standardDef)
        {
            try
            {
                foreach (DomainDef domain in standardDef.DomainContainer)
                {
                    GenerateClass(domain);
                }
            }
            catch(Exception e)
            {
                System.Windows.MessageBox.Show(e.ToString());
            }
        }
        public void GenerateClass(DomainDef domain)
        {try
            {
                
                foreach (DGObjectDef dGObject in domain.DGObjectContainer)
                {
                    List<string> property = new List<string>();
                    List<string> type = new List<string>();
                   
                    foreach (PropertyMeta meta in dGObject.PropertyContainer)
                    {
                        property.Add(meta.PropertyName.Substring(0,1).ToUpper()+meta.PropertyName.Substring(1).ToLower());
                        type.Add(meta.DataType.Substring(0, 1).ToUpper()+ meta.DataType.Substring(1).ToLower());
                    }
                    string newClass = "using System; \n namespace iS3_DataManager.ObjectModels\n { \n \tpublic class "+dGObject.Code+"\n \t{ \n";
                    for(int i = 0; i < property.Count; i++)
                    {
                        
                        newClass += "\t\tpublic Nullable<" + type[i] + "> " + property[i] + " {get;set;}\n";
                    }
                    newClass += "\t}\n}";
                    string path = AppDomain.CurrentDomain.BaseDirectory + @"..\..\ObjectModels\"+dGObject.Code + ".cs";
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
