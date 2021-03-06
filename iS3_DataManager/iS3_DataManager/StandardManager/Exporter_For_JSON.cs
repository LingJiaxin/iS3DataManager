﻿using iS3_DataManager.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3_DataManager.Models;
using Newtonsoft.Json;
using System.IO;

namespace iS3_DataManager.StandardManager
{
    public class Exporter_For_JSON :IDSExporter
    {

        public bool Export(DataStandardDef dataStandard,string path=null)
        {
            try
            {
                string json = JsonConvert.SerializeObject(dataStandard);
                if (path==null)
                {
                    path = AppDomain.CurrentDomain.BaseDirectory + "Standard\\" + dataStandard.Code + ".json";
                }
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(json);
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

    }
}
