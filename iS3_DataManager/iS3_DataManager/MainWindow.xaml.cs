using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using iS3_DataManager.Models;
using iS3_DataManager.Interface;
using iS3_DataManager.DataManager;
using iS3_DataManager.StandardManager;
using System.Data;

namespace iS3_DataManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataStandardDef standard { get; set; }
        DataSet dataSet { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ChoiceLB.SelectedIndex = -1;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //IDSImporter importer = new StandardImport_Exl();
            //if (importer.Import(null) != null) System.Windows.MessageBox.Show("Standard import succeeded");
            StandardLoader standardLoader = new StandardLoader();
            standard = standardLoader.GetStandard();

            if (standard != null)
            {
                DomainNameLB.ItemsSource = standard.DomainContainer;
                if (standard.DomainContainer.Count <= 1)
                {
                    ObjectNameLB.ItemsSource = standard.DomainContainer[0].DGObjectContainer;
                }
            }


        }

        private void ImportData_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog OpenExcelFile = new Microsoft.Win32.OpenFileDialog();
            OpenExcelFile.Multiselect = true;
            OpenExcelFile.Filter = "Excel文件|*.xls;*.xlsx";
            if (OpenExcelFile.ShowDialog() == true)
            {
                IDataImporter dataImporter = new DataImporter_Excel();

                foreach (string path in OpenExcelFile.FileNames)
                {
                    dataSet = dataImporter.Import(path, standard);
                }
                new DataChecker(dataSet, standard).Check();

                List<string> tableNames = new List<string>();
                foreach (DataTable table in dataSet.Tables)
                {
                    tableNames.Add(table.TableName + "数据");
                }
                DataLB.ItemsSource = tableNames;
            }

        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {
            DataChecker checker = new DataChecker(dataSet, standard);
            checker.Check();
            System.Windows.MessageBox.Show("Data check result has been stored at app data folder");
            //DataBaseManager_SQL manager_SQL = new DataBaseManager_SQL();
            //manager_SQL.Data2DB(dataSet,standard);
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ChoiceLB.SelectedIndex == 0)
            {
                DataTemplateGrid.Visibility = Visibility.Visible;
                DataEntryGrid.Visibility = Visibility.Collapsed;
            }
            if (ChoiceLB.SelectedIndex == 1)
            {
                DataTemplateGrid.Visibility = Visibility.Collapsed;
                DataEntryGrid.Visibility = Visibility.Visible;
            }
        }

        private void Open_click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog OpenExcelFile = new Microsoft.Win32.OpenFileDialog();
            OpenExcelFile.Multiselect = true;
            OpenExcelFile.Filter = "Excel文件|*.xls;*.xlsx";
            OpenExcelFile.ShowDialog();
            string[] filenames = OpenExcelFile.FileNames;
            IDataImporter dataImporter = new DataImporter_Excel();


            foreach (string path in filenames)
            {
                dataSet = dataImporter.Import(path, standard);
            }
            List<string> tableNames = new List<string>();
            foreach (DataTable table in dataSet.Tables)
            {
                tableNames.Add(table.TableName + "数据");
            }
            DataLB.ItemsSource = tableNames;

        }

        private void ExportDataTemplate_Click(object sender, RoutedEventArgs e)
        {
            List<DGObjectDef> objList = new List<DGObjectDef>();
            foreach (DGObjectDef item in ObjectNameLB.SelectedItems)
            {
                objList.Add(item);
            }

            DomainDef selectedDomain = (DomainDef)DomainNameLB.SelectedItem ?? (DomainDef)DomainNameLB.Items[0];
            DomainDef domain = new DomainDef
            {
                Code = selectedDomain.Code,
                LangStr = selectedDomain.LangStr,
                Desciption = selectedDomain.Desciption,
                DGObjectContainer = objList
            };
            //export exl templete for data input
            IDSExporter dsExporter = new TempleteExporter_Excel();
            dsExporter.Export(domain);
        }

        /// <summary>
        /// while user select one domain,program will show the object it contains.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DomainName_Click(object sender, RoutedEventArgs e)
        {
            if (DomainNameLB.SelectedItem != null)
            {
                ObjectNameLB.ItemsSource = ((DomainDef)DomainNameLB.SelectedItem).DGObjectContainer;
            }
        }

        private void ObjectNameLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DGObjectDef dGObject = (DGObjectDef)ObjectNameLB.SelectedItems[ObjectNameLB.SelectedItems.Count - 1];
            DescriptionLB.ItemsSource = dGObject.PropertyContainer;
            PropertyLV.ItemsSource = dGObject.PropertyContainer;
        }

        private void DataLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedTable = DataLB.SelectedItem.ToString().Replace("数据", string.Empty);
            int index = 0;
            foreach (DataTable dataTable in dataSet.Tables)
            {
                if (dataTable.TableName == selectedTable) break;
                else index++;
            }
            DataTable table = dataSet.Tables[index];
            DataDG.ItemsSource = table.DefaultView;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            IDSImporter importer = new StandardImport_Exl();
            if (importer.Import(null) != null) System.Windows.MessageBox.Show("Standard import succeeded");
        }

        private void DataDG_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            DataTable tmpDT = ((DataView)DataDG.ItemsSource).Table;
            int index = 0;
            foreach (DataTable table in dataSet.Tables)
            {
                if (table.TableName == tmpDT.TableName) break;
                else
                {
                    index++;
                }                
            }
            dataSet.Tables.RemoveAt(index);
            dataSet.Tables.Add(tmpDT);
        }
    }
}
