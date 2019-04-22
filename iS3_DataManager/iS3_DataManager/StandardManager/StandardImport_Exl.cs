using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3_DataManager.Interface;
using iS3_DataManager.Models;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

namespace iS3_DataManager.StandardManager
{
    public class StandardImport_Exl : IDSImporter
    {

        public DataStandardDef Import(string path)
        {
            path = AppDomain.CurrentDomain.BaseDirectory + @"Standard\iS3Standard.xls";
            return null;
        }

        public DataStandardDef ReadExl(ref IWorkbook workbook)
        {
            DataStandardDef standardDef = new DataStandardDef();
            ISheet sheet = workbook.GetSheetAt(0);
            for (int i = 1; i < sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                Row2Object(ref standardDef, row);
            }
            workbook.Close();
            return null;
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
        public void Row2Object(ref DataStandardDef standardDef, IRow row)
        {
            try
            {
                string domainName = row.GetCell(0).ToString();
                string domainDes = row.GetCell(1).ToString();
                string domainlangStr = row.GetCell(2).ToString();
                string objectName = row.GetCell(3).ToString();
                string objDescrip = row.GetCell(4).ToString();
                string objLangStr = row.GetCell(5).ToString();
                string propertyName = row.GetCell(6).ToString();
                bool IsKey = row.GetCell(7).ToString() == "TRUE";
                string dataType = row.GetCell(8).ToString();
                bool Nullable = row.GetCell(9).ToString() == "TRUE";
                string unit = row.GetCell(10).ToString();
                string regularExp = row.GetCell(11).ToString();
                string proDes = row.GetCell(12).ToString();
                string proLanStr = row.GetCell(13).ToString();

                if (standardDef.DomainContainer.Exists(x => x.Code == domainName))
                {
                    DomainDef domain = standardDef.DomainContainer.Find(x => x.Code == domainName);
                    if (domain.DGObjectContainer.Exists(x => x.Code == objectName))
                    {
                        DGObjectDef objectDef = domain.DGObjectContainer.Find(x => x.Code == objectName);
                        PropertyMeta property = new PropertyMeta
                        {
                            PropertyName = propertyName,
                            IsKey = IsKey,
                            Nullable = Nullable,
                            DataType = dataType,
                            Unit = unit,
                            Description = proDes,
                            RegularExp = regularExp
                        };
                    }
                }
                else
                {
                    DomainDef domain = new DomainDef
                    {
                        Code = domainName,
                        Desciption = domainDes,
                        LangStr = domainlangStr
                    };
                    DGObjectDef objectDef = new DGObjectDef
                    {
                        Code=objectName,
                        Desctiption=objDescrip,
                        LangStr=objLangStr
                    };
                    PropertyMeta property = new PropertyMeta
                    {
                        PropertyName = propertyName,
                        IsKey = IsKey,
                        Nullable = Nullable,
                        DataType = dataType,
                        Unit = unit,
                        Description = proDes,
                        RegularExp = regularExp
                    };
                    objectDef.PropertyContainer.Add(property);
                    domain.DGObjectContainer.Add(objectDef);
                    standardDef.DomainContainer.Add(domain);
                }

            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }
    }
}
