using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using iS3_DataManager.Models;
using System.IO;
using System.Windows;


namespace iS3_DataManager.DataManager
{
    public class DataCleaner
    {
        public DataSet dataSet { get; set; }
        public DataTable dataTable { get; set; }
        public DataStandardDef standardDef { get; set; }

        public DataCleaner(DataTable table, DataStandardDef standard)
        {
            dataTable = table;
            standardDef = standard;
        }
        public DataCleaner(DataSet set, DataStandardDef standard)
        {
            dataSet = set;
            standardDef = standard;
        }
        public bool Clean()
        {
            try
            {
                if (dataSet != null)
                {
                    DomainDef domain = standardDef.DomainContainer.Find(x => x.Code == dataSet.DataSetName);
                    foreach (DataTable table in dataSet.Tables)
                    {
                        DGObjectDef objectDef = domain.DGObjectContainer.Find(x => x.LangStr == table.TableName);
                        CleanTable(table, objectDef);
                    }
                }
                else if (dataTable != null)
                {
                    DGObjectDef objectDef = standardDef.GetDGObjectDefByName(dataTable.TableName);
                    CleanTable(dataTable, objectDef);
                }
                return true;
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
                return false;
            }

        }

        private DataTable CleanTable(DataTable table, DGObjectDef objectDef)
        {
            DataTable tmpTable = DeduplicateTable(table, objectDef);
            tmpTable = RemoveEmpty(tmpTable, objectDef);
            return tmpTable;
        }
        private DataTable DeduplicateTable(DataTable table,DGObjectDef objectDef)
        {
            string[] distinctcols = new string[(table.Columns.Count)];
            foreach (DataColumn dataColumn in table.Columns)
            {
                distinctcols[dataColumn.Ordinal] = dataColumn.ColumnName;
            }
            DataTable DeduplicatedTable = new DataTable(table.TableName);
            DataView mydataview = new DataView(table);
            DeduplicatedTable = mydataview.ToTable(true, distinctcols);//去重复
            return DeduplicatedTable;
        }
        private DataTable RemoveEmpty(DataTable table,DGObjectDef objectDef)
        {
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (PropertyMeta meta in objectDef.PropertyContainer)
                    {
                        if ((meta.Nullable == false | meta.IsKey == true) & row[meta.LangStr] == null)
                        {
                            row.Delete();//Delete rows which lack of key values;
                        }
                    }
                }
                return table;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
