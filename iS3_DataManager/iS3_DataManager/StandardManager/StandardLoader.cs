using System;
using iS3_DataManager.Models;
using System.IO;
using iS3_DataManager.Interface;
using iS3_DataManager.DataManager;
using iS3_DataManager.StandardManager;

namespace iS3_DataManager.StandardManager
{
    public class StandardLoader
    {
        string path { get; set; }
        public StandardLoader()
        {
            DirectoryInfo localPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            path = localPath.Parent.Parent.FullName + "\\Standard\\";
        }
        public DataStandardDef GetStandard()
        {
            IDSImporter importer = new Importer_For_Json();
            return importer.Import(path);
        }

        public DataStandardDef GetStandard(string path)
        {            
            IDSImporter importer = new Importer_For_Json();
            return importer.Import(path);
        }
        public StandardFilter CreateFilter()
        {
            var fullPath = Directory.GetFiles(path, "filter.json");

            if ((fullPath[0] != null))
            {
                FileStream fs = new FileStream(fullPath[0], FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fs, System.Text.Encoding.UTF8);
                string json = streamReader.ReadToEnd();
                fs.Close();
                streamReader.Close();
                StandardFilter filter = Newtonsoft.Json.JsonConvert.DeserializeObject<StandardFilter>(json);
                return filter ;
            }
            else
            {
                return null;
            }
        }
    }
}

