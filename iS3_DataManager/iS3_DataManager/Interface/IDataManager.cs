using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3_DataManager.Models;
namespace iS3_DataManager.Interface
{
    public interface IDataBaseManager
    {
        void WriteData(System.Data.DataSet dataSet,DataStandardDef standardDef);
       // void ReadData();
    }
}
