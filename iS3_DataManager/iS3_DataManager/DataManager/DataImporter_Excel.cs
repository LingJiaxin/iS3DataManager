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
    public class DataImporter_Excel : IDataImporter
    {


        public List<DataSet> Import(StandardDef standard)
        {
            List<DataSet> domainContainer = null;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true
            };
            if (ofd.ShowDialog() == true)
            {
                foreach (string path in ofd.FileNames)
                {
                    domainContainer.Add(Import(path, standard));
                }
            }

            return domainContainer;
        }
        
        public DataSet Import(string path, StandardDef standard)
        {

            //try
            //{
                string domainName = Path.GetFileNameWithoutExtension(path);
                DomainDef domain = standard.DomainContainer.Find(x => x.Code == domainName| x.LangStr == domainName);
                DataSet ds = new DataSet(domainName);

                IWorkbook wb = ReadWorkbook(path);

                List<string> sheetNames = GetSheetNames(wb);
                //sheetNames equal to objectName
                foreach (string sheetName in sheetNames)
                {
                    DGObjectDef objectDef = standard.GetDGObjectDefByName(sheetName);
                    DataTable dt = ReadSheet(wb.GetSheet(sheetName), objectDef);
                    if(dt!=null)ds.Tables.Add(dt);
                }
                
                return ds;
            //}

            //catch (Exception)
            //{
            //    return null;
            //}

        }


        IWorkbook ReadWorkbook(string path)
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

        List<string> GetSheetNames(IWorkbook wb)
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
                        sheetNames.Add(wb.GetSheetName(i));
                    }
                    return sheetNames;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// sheet to object datatable
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        DataTable ReadSheet(ISheet sheet, DGObjectDef objectDef)
        {

            if (sheet == null)
            {
                return null;
            }
            else
            {                
                DataTable dt = new DataTable(objectDef.LangStr);
                foreach (PropertyMeta meta in objectDef.PropertyContainer)
                {
                    dt.Columns.Add(meta.LangStr);
                }

                foreach (IRow row in sheet)
                {
                    DataRow dr = dt.NewRow();
                    int i = 0;
                    foreach (PropertyMeta meta in objectDef.PropertyContainer)
                    {
                        if (row.GetCell(i) != null)
                        {
                            dr[meta.LangStr] = row.GetCell(i++);
                        }
                        else
                        {
                            i++;
                            dr[meta.LangStr] = null;
                        }
                    }
                    dt.Rows.Add(dr);
                }
                for (int i = 0; i < 3; i++)
                {
                    dt.Rows.RemoveAt(0);    //remove the decription line(first 3 linesS)
                }
                return dt;
            }
        }
    }
}