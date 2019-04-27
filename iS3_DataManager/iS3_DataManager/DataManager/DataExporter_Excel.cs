﻿using System;
using iS3_DataManager.Models;
using iS3_DataManager.Interface;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

namespace iS3_DataManager.DataManager
{
    /// <summary>
    /// generate exl templete for data input
    /// </summary>
    public class DataExporter_Excel :IDataExporter
    {

        string path=Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string fileName;

        DataStandardDef standard;
        DomainDef domain;


        /// <summary>
        /// export standard to excel for data input
        /// </summary>
        /// <param name="standard"></param>
        /// <param name="path">the path where excel will generate at</param>
        /// <returns></returns>
        public bool Export(DataStandardDef standard, string path = null)
        {
            this.standard = standard;
            if (path != null)
            {
                this.path = path;
            }
            try
            {
                foreach (DomainDef domain in standard.DomainContainer)
                {
                    this.domain = domain;
                    Export();
                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public bool Export(DomainDef domain, string path = null)
        {
            this.domain = domain;
            if (path != null)
            {
                this.path = path;
            }

            return Export();
        }

        private bool Export()
        {
            try
            {
                IWorkbook workbook = new HSSFWorkbook();
                fileName = path + "\\" + domain.Code + ".xls";
                write2Exl(domain, workbook);
                saveExl(workbook);
            }
            catch (Exception e
            )
            {
                System.Windows.MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        bool write2Exl(DomainDef domain, IWorkbook workbook)
        {
            foreach (DGObjectDef objectDef in domain.DGObjectContainer)
            {
                string sheetName = objectDef.LangStr ?? objectDef.Code;
                ISheet sheet = workbook.CreateSheet(sheetName);
                writeDescription(sheet, objectDef);
                wrtieTitle(sheet, objectDef);
            }
            return true;
        }

        void writeDescription(ISheet sheet, DGObjectDef objectDef)
        {
            IRow row0 = sheet.CreateRow(0);
            row0.CreateCell(0).SetCellValue(objectDef.Code + "表");
            row0.CreateCell(1).SetCellValue(objectDef.LangStr);
            row0.CreateCell(3).SetCellValue("请勿修改sheet名");

            for (int i = 0; i < 20; i++)
            {
                sheet.SetColumnWidth(i, 20 * 150);
            }
        }

        void wrtieTitle(ISheet sheet, DGObjectDef item)
        {
            IRow row1 = sheet.CreateRow(1);
            IRow row2 = sheet.CreateRow(2);
            int i = 0;
            foreach (PropertyMeta property in item.PropertyContainer)
            {
                row1.CreateCell(i).SetCellValue(property.LangStr);
                row2.CreateCell(i++).SetCellValue(property.DataType);
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
