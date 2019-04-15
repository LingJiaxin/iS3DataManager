using iS3_DataManager.Models;
using System.Collections.Generic;

namespace iS3_DataManager.Interface
{
   public interface IDataImporter
    {
        List<DomainDef> Import();
        DomainDef Import(string path);
    }
}
