using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace iS3_DataManager.ViewManager
{
    /// <summary>
    /// change dataGrid style by check result
    /// </summary>
    public class ChangeStyle
    {
        DataGrid DataDG;
        DataTable dataTable;
        Models.DataStandardDef standard;
        public ChangeStyle(DataTable dataTable,ref DataGrid dataGrid, Models.DataStandardDef standardDef)
        {
            DataDG = dataGrid;
            this.dataTable = dataTable;
            standard = standardDef;
        }
        public DataGrid RefreshStyle()
        {
            Models.DGObjectDef dGObject = standard.GetDGObjectDefByName(dataTable.TableName);
            int rowNum = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                if (rowNum == 0) {rowNum=1; continue;}
                int columnNum = 0;
                foreach (Models.PropertyMeta meta in dGObject.PropertyContainer)
                {
                    if (meta.RegularExp != null)
                    {
                        var data = row[meta.LangStr].ToString();
                        bool reult1 = (data != "" & data != null);
                        bool result=Regex.IsMatch(row[meta.LangStr].ToString(), meta.RegularExp);
                        if (reult1 & !result)
                        {
                            Check(rowNum, columnNum);
                        }
                        if ((meta.IsKey == true | meta.Nullable == false) & row[meta.LangStr] == null) Check(rowNum, columnNum);
                    }
                    else if ((meta.IsKey == true | meta.Nullable == false) & row[meta.LangStr] == null) Check(rowNum, columnNum);
                    columnNum++;
                }
                rowNum++;
            }
            return DataDG;
        }

        private void Check(int i, int j)
        {
            if (i < this.DataDG.Items.Count)
            {
                DataRowView drv = DataDG.Items[i] as DataRowView;
                DataGridRow row = GetRow(DataDG,i);
                DataGridCellsPresenter presenter = GetVisualChild<DataGridCellsPresenter>(row);
                DataGridCell cell = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(j);
                cell.Background = new SolidColorBrush(Colors.Red);
            }
        }
        public static T GetVisualChild<T>(Visual parent) where T : Visual
        {
            T childContent = default(T);
            int numVisuals = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < numVisuals; i++)
            {
                Visual v = (Visual)VisualTreeHelper.GetChild(parent, i);
                childContent = v as T;
                if (childContent == null)
                {
                    childContent = GetVisualChild<T>(v);
                }
                if (childContent != null)
                {
                    break;
                }
            }
            return childContent;
        }
        public static DataGridRow GetRow(DataGrid datagrid, int columnIndex)
        {
            DataGridRow row = (DataGridRow)datagrid.ItemContainerGenerator.ContainerFromIndex(columnIndex);
            if (row == null)
            {
                datagrid.UpdateLayout();
                datagrid.ScrollIntoView(datagrid.Items[columnIndex]);
                row = (DataGridRow)datagrid.ItemContainerGenerator.ContainerFromIndex(columnIndex);
            }
            return row;
        }
    }
}
