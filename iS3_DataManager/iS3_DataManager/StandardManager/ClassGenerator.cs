﻿using System.Data;
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
                    
                    string newClass = "using System; \n namespace iS3_DataManager.ObjectModels\n { \n \tpublic class " + dGObject.Code + "\n \t{ \n";
                    foreach (PropertyMeta meta in dGObject.PropertyContainer)
                    {

                        if (meta.DataType != "string")
                        {
                            newClass += "\t\tpublic Nullable<" + meta.DataType + "> " + meta.PropertyName + " {get;set;}\n";
                        }
                        else
                        {
                            newClass+= "\t\tpublic " + meta.DataType + " " + meta.PropertyName + " {get;set;}\n";
                        }
                        
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
