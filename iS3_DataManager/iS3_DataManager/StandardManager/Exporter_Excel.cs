﻿using System;
using iS3_DataManager.Models;
using iS3_DataManager.Interface;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

namespace iS3_DataManager.DataManager
{

    public class Exporter_Excel :IDataExporter
    {

        string path=Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string fileName;

        DataStandardDef standard;
        DomainDef domain;



        public bool Export(DataStandardDef standard, string path = null)
        {
            this.standard = standard;
            if (path == null)
            {
            }
            else
            {
                this.path = path;
            }
            return Export();
        }

        public bool Export(DomainDef domain, string path = null)
        {
            this.domain = domain ;
            if (path == null)
            {
            }
            else
            {
                this.path = path;
            }
            return Export();
        }

        /// <summary>
        /// export standard to excel for data input
        /// </summary>
        /// <param name="path">the path where excel will generate at</param>
        /// <param name="standard"></param>
        /// <returns></returns>
        bool Export()
        {
            //default file format 'xls'
            IWorkbook workbook = new HSSFWorkbook();
            try
            {
                if (standard == null)
                {
                    fileName = path + "\\default.xls";
                    write2Exl(this.domain, workbook);
                }
                else
                {
                    fileName = path + "\\" + standard.Code + ".xls";
                    foreach (DomainDef domain in standard.DomainContainer)
                    {
                        write2Exl(domain, workbook);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            saveExl(workbook);
            return true;

        }


        bool write2Exl(DomainDef domain, IWorkbook workbook)
        {
            foreach (DGObjectDef item in domain.DGObjectContainer)
            {
                ISheet sheet = workbook.CreateSheet(item.Code);
                writeDescription(sheet, item);
                wrtieTitle(sheet, item);
            }
            return true;
        }

        void writeDescription(ISheet sheet, DGObjectDef item)
        {
            IRow row0 = sheet.CreateRow(0);
            row0.CreateCell(0).SetCellValue(item.Code + "表");
            row0.CreateCell(1).SetCellValue(item.Desctiption);
            row0.CreateCell(3).SetCellValue("请勿修改sheet名");

            for (int i = 0; i < 20; i++)
            {
                sheet.SetColumnWidth(i, 20 * 175);
            }
        }

        void wrtieTitle(ISheet sheet, DGObjectDef item)
        {
            IRow row1 = sheet.CreateRow(1);
            int i = 0;
            foreach (PropertyMeta property in item.PropertyContainer)
            {

                row1.CreateCell(i++).SetCellValue(property.LangStr + property.DataType);
            }

        }

        void saveExl(IWorkbook workbook)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            workbook.Write(fs);
            fs.Close();
        }
    }
}
