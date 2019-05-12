using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using iS3_DataManager.Models;
using iS3_DataManager.Interface;
using iS3_DataManager.DataManager;
using iS3_DataManager.StandardManager;
using System.Data;
using System.Linq;

namespace iS3_DataManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataStandardDef Standard { get; set; }
        private DataStandardDef NewDataStandard { get; set; }
        DataSet dataSet { get; set; }
        StandardFilter filter { get; set; }
        DataStandardDef filteredStandard { get; set; }
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

            // StandardFilter filter = new StandardFilter();
            //new Exporter_For_JSON().Export(filter);
            StandardLoader standardLoader = new StandardLoader();
            Standard = standardLoader.GetStandard();

            filter= standardLoader.CreateFilter();
            ShowTreeView(filter);          

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
                    dataSet = dataImporter.Import(path, Standard);
                }
                new DataChecker(dataSet, Standard).Check();

                List<string> tableNames = new List<string>();
                foreach (DataTable table in dataSet.Tables)
                {
                    tableNames.Add(table.TableName + "数据");
                }
                //DataLB.ItemsSource = tableNames;
            }
        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {
            DataChecker checker = new DataChecker(dataSet, Standard);
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

        /// <summary>
        /// import Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                dataSet = dataImporter.Import(path, Standard);
            }
            List<string> tableNames = new List<string>();
            foreach (DataTable table in dataSet.Tables)
            {
                tableNames.Add(table.TableName + "数据");
            }
            //DataLB.ItemsSource = tableNames;

        }

        private void ExportDataTemplate_Click(object sender, RoutedEventArgs e)
        {
            //List<DGObjectDef> objList = new List<DGObjectDef>();
            //foreach (DGObjectDef item in ObjectNameLB.SelectedItems)
            //{
            //    objList.Add(item);
            //}

            //DomainDef selectedDomain = (DomainDef)DomainNameLB.SelectedItem ?? (DomainDef)DomainNameLB.Items[0];
            //DomainDef domain = new DomainDef
            //{
            //    Code = selectedDomain.Code,
            //    LangStr = selectedDomain.LangStr,
            //    Desciption = selectedDomain.Desciption,
            //    DGObjectContainer = objList
            //};
            ////export exl templete for data input
            //IDSExporter dsExporter = new TempleteExporter_Excel();
            //dsExporter.Export(domain);
        }

        /// <summary>
        /// while user select one domain,program will show the object it contains.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void DomainName_Click(object sender, RoutedEventArgs e)
        //{
        //    if (DomainNameLB.SelectedItem != null)
        //    {
        //        ObjectNameLB.ItemsSource = ((DomainDef)DomainNameLB.SelectedItem).DGObjectContainer;
        //    }
        //}

        //private void ObjectNameLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (ObjectNameLB.SelectedItems.Count > 0)
        //    {
        //        DGObjectDef dGObject = (DGObjectDef)ObjectNameLB.SelectedItems[ObjectNameLB.SelectedItems.Count - 1];
        //        PropertyLV.ItemsSource = dGObject.PropertyContainer;
        //    }

        //}

        //private void DataLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string selectedTable = DataLB.SelectedItem.ToString().Replace("数据", string.Empty);
        //    int index = 0;
        //    foreach (DataTable dataTable in dataSet.Tables)
        //    {
        //        if (dataTable.TableName == selectedTable) break;
        //        else index++;
        //    }
        //    DataTable table = dataSet.Tables[index];
        //    DataDG.ItemsSource = table.DefaultView;
        //}

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            IDSImporter importer = new StandardImport_Exl();
            if (importer.Import(null) != null) System.Windows.MessageBox.Show("Standard import succeeded");
        }

        //private void DataDG_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        //{
        //    DataTable tmpDT = ((DataView)DataDG.ItemsSource).Table;
        //    int index = 0;
        //    foreach (DataTable table in dataSet.Tables)
        //    {
        //        if (table.TableName == tmpDT.TableName) break;
        //        else
        //        {
        //            index++;
        //        }                
        //    }
        //    dataSet.Tables.RemoveAt(index);
        //    dataSet.Tables.Add(tmpDT);
        //}

        public void ShowTreeView(StandardFilter filter)
        {

            foreach (var tunnel in filter.Tunnels)
            {
                TreeViewItem tunnelTreeView = new TreeViewItem();
                tunnelTreeView.Header = tunnel.LangStr;
                tunnelTreeView.ExpandSubtree();
                foreach (Stage stage in tunnel.Stages)
                {
                    TreeViewItem stageTreeView = new TreeViewItem();
                    stageTreeView.Header = stage.LangStr;
                    stageTreeView.ExpandSubtree();
                    foreach (Category category in stage.Categories)
                    {
                        TreeViewItem categoryTreeView = new TreeViewItem();
                        categoryTreeView.Header = category.LangStr;
                        categoryTreeView.ExpandSubtree();                        
                        stageTreeView.Items.Add(categoryTreeView);
                    }
                    tunnelTreeView.Items.Add(stageTreeView);
                }
                DataTemplateTreeview.Items.Add(tunnelTreeView);
            }

        }

        private void DataTemplateTreeview_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (DataTemplateTreeview.SelectedItem != null)
            {
                TreeViewItem selectedTreeView = (TreeViewItem)DataTemplateTreeview.SelectedItem;
                if (selectedTreeView.Items.Count < 1)
                {
                    string categoryName = selectedTreeView.Header.ToString();
                    TreeViewItem stageTreeView =(TreeViewItem)selectedTreeView.Parent;
                    string stageName = stageTreeView.Header.ToString();
                    TreeViewItem tunnelTreeView = (TreeViewItem)stageTreeView.Parent;
                    string tunnelType = tunnelTreeView.Header.ToString();
                    //filter standard by select condition
                    filteredStandard= filter.Filter(Standard, tunnelType, stageName,categoryName);//Post loading technique

                    TreeViewItem objTreeView = new TreeViewItem();
                    foreach(DGObjectDef dGObject in filteredStandard.DomainContainer[0].DGObjectContainer)
                    {
                        objTreeView.Items.Add(dGObject.LangStr);
                    }
                    
                    
                }
                else
                {
                    if (IsStageTreeView(selectedTreeView))
                    {
                        string stageName = selectedTreeView.Header.ToString();
                        TreeViewItem tunnelTreeView = (TreeViewItem)selectedTreeView.Parent;
                        string tunnelType = tunnelTreeView.Header.ToString();
                        filteredStandard = filter.Filter(Standard, tunnelType, stageName);
                    }
                }
                List<DGObjectDef> dGObjects = new List<DGObjectDef>();
                foreach(DomainDef domain in filteredStandard.DomainContainer)
                {
                    foreach (DGObjectDef item in domain.DGObjectContainer)
                    {
                        dGObjects.Add(item);
                    }
                }
                //PropertyLV.ItemsSource = dGObjects;
            }
            
        }
        bool IsStageTreeView(TreeViewItem treeView)
        {
            string stage1 = "勘察阶段";
            string stage2 = "施工阶段";
            string name = treeView.Header.ToString();
            return name==stage1|name==stage2;
        }
    }
}
