using System;
using iS3_DataManager.Models;
using iS3_DataManager.Interface;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

namespace iS3_DataManager.DataManager
{

    public class TemplateGenerator_Excel :IDataExporter
    {

        string path=Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string fileName;

        StandardDef standard;
        DomainDef domain;



        public bool Export(StandardDef standard, string path = null)
        {
            this.standard = standard;
            if (path == null)
            {
            }
            else
            {
                this.path = path;
            }
            bool succeed = Export();
            if (succeed) System.Windows.MessageBox.Show("The Exl templete generated successfully at Destop!");
            else System.Windows.MessageBox.Show("Someting getting wrong during generating,Please try again!");
            return succeed;
        }

        public bool Export(DomainDef domain, string path = null)
        {
            this.domain = domain ;
            if (path != null)
            {
                this.path = path;
            }
            bool succeed = Export();
            if (succeed) System.Windows.MessageBox.Show("The Exl templete generated successfully at Destop!");
            else System.Windows.MessageBox.Show("Someting getting wrong during generating,Please try again!");
            return succeed;
        }

        /// <summary>
        /// export standard to excel for data input
        /// </summary>
        /// <param name="path">the path where excel will generate to</param>
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
                    fileName = path + "\\"+(domain.Code??domain.LangStr)+".xls";
                    write2Exl(this.domain, workbook);
                }
                else
                {
                    fileName = path + "\\" + (standard.Code??standard.LangStr) + ".xls";
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
                ISheet sheet = workbook.CreateSheet(item.LangStr??item.Code);
                writeDescription(sheet, item);
                wrtieTitle(sheet, item);
            }
            return true;
        }

        void writeDescription(ISheet sheet, DGObjectDef item)
        {
            IRow row0 = sheet.CreateRow(0);
            row0.CreateCell(0).SetCellValue(item.LangStr + "表");
            row0.CreateCell(1).SetCellValue(item.Code);
            row0.CreateCell(2).SetCellValue("请勿修改sheet名");
            row0.CreateCell(4).SetCellValue(item.Desctiption);

            for (int i = 0; i < 20; i++)
            {
                sheet.SetColumnWidth(i, 20 * 175);
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
