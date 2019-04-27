using System;
using System.IO;
using iS3_DataManager.Interface;
using iS3_DataManager.Models;
using Newtonsoft.Json;
using System.Text;

namespace iS3_DataManager.StandardManager
{
    public class Importer_For_Json : IDSImporter
    {
        public DataStandardDef Import(string path)
        {
            path = path ?? (AppDomain.CurrentDomain.BaseDirectory + @"Standard\");
            return ReadJson(path);
            //return GetSample();
        }
        /// <summary>
        /// just for test
        /// </summary>
        /// <returns></returns>
        public DataStandardDef GetSample()
        {
            //定义隧道数据标准和地质域
            DataStandardDef dsDef = new DataStandardDef()
            {
                Code = "TunnelStandard",
                Description = "This a Tunnel DataStandard",
            };
            DomainDef ddDef = new DomainDef()
            {
                Code = "Geology",
                Desciption = "This a Geology Domain",
            };
            dsDef.DomainContainer.Add(ddDef);

            //定义地质域内的数据结构
            DGObjectDef dgDef = new DGObjectDef()
            {
                Code = "Borehole",
                Desctiption = "This a Borehole DGObject"
            };
            ddDef.DGObjectContainer.Add(dgDef);

            //定义钻孔中的属性内容
            dgDef.PropertyContainer.Add(new PropertyMeta("ID", "Int", null, "这是编号字段", "['zh':'编号','en':'ID']",IsKey: true,regularExpression:@"\d"));
            dgDef.PropertyContainer.Add(new PropertyMeta("BoreholeID", "string", null, "这是钻孔编号", "['zh':'钻孔编号','en':'BoreholeID']", true,regularExpression:@""));
            dgDef.PropertyContainer.Add(new PropertyMeta("BoreholeTime", "dateTime", null, "这是钻孔时间", "['zh':'钻孔时间','en':'BoreholeTime']", true));
            dgDef.PropertyContainer.Add(new PropertyMeta("BoreholeDepth", "double", "m", "这是钻孔深度", "['zh':'钻孔深度','en':'BoreholeDepth']", true));
            return dsDef;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DataStandardDef ReadJson(string path)
        {
            
            var fullPath = Directory.GetFiles(path, "*.json");

            if (!(fullPath[0] == null))
            {
                FileStream fs = new FileStream(fullPath[0], FileMode.Open, FileAccess.Read);
                int n = (int)fs.Length;
                byte[] b = new byte[n];
                int r = fs.Read(b, 0, n);
                string json = Encoding.Default.GetString(b, 0, n);
                DataStandardDef standard = JsonConvert.DeserializeObject<DataStandardDef>(json);
                return standard;
            }
            else
            {
                return null;
            }
        }
    }
}
