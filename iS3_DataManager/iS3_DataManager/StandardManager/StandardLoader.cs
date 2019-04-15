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
            this.path = AppDomain.CurrentDomain.BaseDirectory;

        }
        public DataStandardDef getStandard()
        {
            //!!!!poay attention that other exsiting files will affect the import process
            IDSImporter importer = new Importer_For_Json();
            return importer.Import("");
           


        }
    }
}

