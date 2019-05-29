using iS3_DataManager.Interface;
using System;
using System.Text;
using iS3_DataManager.Models;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;

namespace iS3_DataManager.StandardManager
{
    public class Exporter_For_JSON : IDSExporter
    {

        public bool Export(DataStandardDef dataStandard, string path = null)
        {
            try
            {
                string json = JsonConvert.SerializeObject(dataStandard);
                if (path == null)
                {
                    DirectoryInfo localPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                    path = localPath.Parent.Parent.FullName + "\\Standard\\" + dataStandard.Code + ".json";
                }
                
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

                FileInfo fInfo = new FileInfo(path);
                fInfo.Attributes = FileAttributes.Normal;

                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write(json);
                
                // Set the IsReadOnly property.
                fInfo.Attributes = fInfo.Attributes | FileAttributes.ReadOnly| FileAttributes.Hidden;

                sw.Flush();
                sw.Close();
                fs.Close();
                
                return true;
               
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Export(StandardFilter filter)
        {
            
            string json = JsonConvert.SerializeObject(filter);
            return true;
        }

        public bool Export(DomainDef domain, string path = null)
        {
            throw new NotImplementedException();
        }

    }
}
