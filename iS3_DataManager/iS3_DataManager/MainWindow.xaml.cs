using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using iS3_DataManager.Models;
using iS3_DataManager.Interface;
using iS3_DataManager.DataManager;
using iS3_DataManager.StandardManager;
using iS3_DataManager.ViewManager;
using System.Data;
using System.Linq;
using System;

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
        TreeViewData ViewData { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ChoiceLB.SelectedIndex = -1;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var Loads = this.Dispatcher.BeginInvoke(new Action(() =>
            {
                Load();
            }));
            //IDSImporter importer = new StandardImport_Exl();
            //if (importer.Import(null) != null) System.Windows.MessageBox.Show("Standard import succeeded");

            // StandardFilter filter = new StandardFilter();
            //new Exporter_For_JSON().Export(filter);
            Loads.Completed += new EventHandler(Loads_Completed);

        }
        void Loads_Completed(object sender, EventArgs e)
        {
            ViewData = new TreeViewData(filter,Standard);
            DataTemplateTreeview.DataContext = ViewData;            
        }
        /// <summary>
        /// load Data
        /// </summary>
        public void Load()
        {
            StandardLoader standardLoader = new StandardLoader();
            Standard = standardLoader.GetStandard();
            filter = standardLoader.CreateFilter();
           
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
            
        }

        

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            IDSImporter importer = new StandardImport_Exl();
            if (importer.Import(null) != null) System.Windows.MessageBox.Show("Standard import succeeded");
        }

       
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
            TreeNode selectedNode = (TreeNode)DataTemplateTreeview.SelectedItem;
            if (selectedNode != null)
            {
                switch (selectedNode.Level)
                {
                    case 1:
                        return;
                    case 2:
                        return;
                    case 3:
                        return;
                    case 4:
                       DGObjectDef dGObjectDef= Standard.GetDGObjectDefByName(selectedNode.Context);
                        PropertyLV.ItemsSource = null;
                        PropertyLV.ItemsSource = dGObjectDef.PropertyContainer;
                        return;
                    default:
                        return;
                }
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
