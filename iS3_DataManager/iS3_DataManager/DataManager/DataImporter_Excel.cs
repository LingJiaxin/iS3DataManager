using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3_DataManager.Models;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using iS3_DataManager.Interface;
using System.Data;
using Microsoft.Win32;

namespace iS3_DataManager.DataManager
{
    public class DataImporter_Excel :IDataImporter
    {
        

        public List<DomainDef> Import()
        {
            List<DomainDef> domainContainer = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == true)
            {
                foreach (string path in ofd.FileNames)
                {
                    domainContainer.Add(Import(path));
                }
            }

            return domainContainer;
        }

        public DomainDef Import(string path)
        {
            IWorkbook wb = readWorkbook(path);
            try
            {
                string domainName = Path.GetFileNameWithoutExtension(path);            
                                DataSet ds = new DataSet(domainName);
                List<string> sheetNames = getSheetNames(wb);
                foreach (string sheetName in getSheetNames(wb))
                {                    
                    DataTable dt = readSheet(wb.GetSheet(sheetName));
                    dt.TableName = sheetName;                    
                    ds.Tables.Add(dt);
                }
                return null;
            }

            catch (Exception)
            {
                return null;
            }

        }


        IWorkbook readWorkbook(string path)
        {
            IWorkbook workbook = null;
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                if (path.IndexOf(".xlsx") > 0) // for excel version over 2007
                    return workbook = new XSSFWorkbook(fs);
                else if (path.IndexOf(".xls") > 0) //for excel version 97-03
                    return workbook = new HSSFWorkbook(fs);
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        List<string> getSheetNames(IWorkbook wb)
        {
            
            try
            {
                if (wb == null)
                {
                    return null;
                    
                }
                else
                {
                    List<string> sheetNames = new List<string>();
                    for (int i = 0; i < wb.NumberOfSheets; i++)
                    {
                        sheetNames.Add(wb.GetSheetName(i).ToString());
                    }
                    return sheetNames;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        DataTable readSheet(ISheet sheet)
        {

            if (sheet == null)
            {
                return null;
            }
            else
            {
                DataTable dt = new DataTable();
                for (int i = 0; i < 20; i++)
                {
                    dt.Columns.Add(i.ToString());
                }

                foreach (IRow row in sheet)
                {
                    dt.Rows.Add(readRow(row, dt));
                }
                return dt;
            }
        }

        DataRow readRow(IRow row, DataTable dt)
        {
            DataRow dr = dt.NewRow();
            try
            {
                for (int i = 0; i < row.LastCellNum-1; i++)
                {
                    dr[i.ToString()] = row.Cells[i].ToString();
                }
                return dr;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}