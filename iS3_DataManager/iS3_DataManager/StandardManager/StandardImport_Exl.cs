﻿using System;
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
        DataStandardDef standardDef { get; set; }
        public DataStandardDef Import(string path)
        {
            path = path ?? (AppDomain.CurrentDomain.BaseDirectory + @"Standard\");
            return ReadExl(ReadWorkbook(path));
        }

        public DataStandardDef ReadExl(IWorkbook workbook)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory + @"Standard\";
            //DataStandardDef standardDef = new StandardLoader().getStandard(path);
            
            ISheet sheet = workbook.GetSheetAt(0);
            for (int i = 1; i < sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                Row2Object( row);
            }
            IDSExporter exporter = new Exporter_For_JSON();
            exporter.Export(this.standardDef);
            workbook.Close();
            return this.standardDef;
        }

        IWorkbook ReadWorkbook(string path)
        {
            try
            {
                var fullPath = Directory.GetFiles(path, "*.xlsx");
                if (fullPath.Equals(null))
                    fullPath = Directory.GetFiles(path, "*.xls");
                path = fullPath.Length == 0 ? (AppDomain.CurrentDomain.BaseDirectory + @"Standard\RockTunnel.xlsx") : fullPath[0];
                this.standardDef = new DataStandardDef { Code = Path.GetFileNameWithoutExtension(path) };
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                if (path.IndexOf(".xlsx") > 0) // for excel version over 2007
                    return new XSSFWorkbook(fs);
                else if (path.IndexOf(".xls") > 0) //for excel version 97-03
                    return new HSSFWorkbook(fs);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
                return null;
            }
            return null;
        }
        public void Row2Object(IRow row)
        {
            
            try
            {
                string domainName = row.GetCell(0).ToString();
                string domainDes = row.GetCell(1)?.ToString();
                string domainlangStr = row.GetCell(2)?.ToString();
                string objectName = row.GetCell(3)?.ToString();
                string objDescrip = row.GetCell(4)?.ToString();
                string objLangStr = row.GetCell(5)?.ToString();
                string propertyName = row.GetCell(6).ToString();
                bool IsKey = row.GetCell(7)?.ToString() == null ? false : row.GetCell(7).ToString() == "TRUE";
                string dataType = row.GetCell(8)?.ToString();
                bool Nullable = row.GetCell(9)?.ToString() == null ? true : row.GetCell(9).ToString() != "FALSE";
                string unit = row.GetCell(10)?.ToString();
                string regularExp = row.GetCell(11)?.ToString();
                string proDes = row.GetCell(12)?.ToString();
                string proLanStr = row.GetCell(13)?.ToString();

                
                DomainDef domain = null;
                DGObjectDef objectDef = null;
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

                if (this.standardDef.DomainContainer.Exists(x => x.Code == domainName))
                {
                    domain = this.standardDef.DomainContainer.Find(x => x.Code == domainName);

                    if (domain.DGObjectContainer.Exists(x => x.Code == objectName))
                    {
                        objectDef = domain.DGObjectContainer.Find(x => x.Code == objectName);
                        if (!objectDef.PropertyContainer.Exists(x => x.PropertyName == property.PropertyName))
                            objectDef.PropertyContainer.Add(property);
                    }
                    else
                    {
                        objectDef = new DGObjectDef
                        {
                            Code = objectName,
                            Desctiption = objDescrip,
                            LangStr = objLangStr
                        };
                        objectDef.PropertyContainer.Add(property);
                        domain.DGObjectContainer.Add(objectDef);
                    }
                }
                else
                {
                    domain = new DomainDef
                    {
                        Code = domainName,
                        Desciption = domainDes,
                        LangStr = domainlangStr
                    };
                    objectDef = new DGObjectDef
                    {
                        Code = objectName,
                        Desctiption = objDescrip,
                        LangStr = objLangStr
                    };
                    objectDef.PropertyContainer.Add(property);
                    domain.DGObjectContainer.Add(objectDef);
                    this.standardDef.DomainContainer.Add(domain);
                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }
    }
}
