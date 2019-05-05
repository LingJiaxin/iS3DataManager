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
            //!!!!poay attention that other exsiting files will affect the import process
            IDSImporter importer = new Importer_For_Json();
            return importer.Import(path);
        }
    }
}

