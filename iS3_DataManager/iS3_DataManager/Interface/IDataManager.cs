using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3_DataManager.Interface
{
    public interface IDataBaseManager
    {
        void WriteData(System.Data.DataSet dataSet);
       // void ReadData();
    }
}
