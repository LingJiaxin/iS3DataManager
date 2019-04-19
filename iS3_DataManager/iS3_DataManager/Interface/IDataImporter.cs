using iS3_DataManager.Models;
using System.Collections.Generic;

namespace iS3_DataManager.Interface
{
   public interface IDataImporter
    {
        List<System.Data.DataSet> Import(DataStandardDef standard);
        System.Data.DataSet Import(string path,DataStandardDef standard);
    }
}
