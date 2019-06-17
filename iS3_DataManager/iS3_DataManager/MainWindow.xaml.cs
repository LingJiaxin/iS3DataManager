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
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.IO;

namespace iS3_DataManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StandardDef Standard { get; set; }
        private StandardDef NewDataStandard { get; set; }
        DataSet dataSet { get; set; }
        StandardFilter filter { get; set; }
        Tunnel tunnel { get; set; }
        TreeViewData ViewData { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ChoiceLB.SelectedIndex = -1;
            Loaded += MainWindow_Loaded;
        }
        private void Test()
        {
            //DataSet2Entity transporter = new DataSet2Entity();
            //transporter.Data2DataBase(dataSet, Standard);
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var Loads = this.Dispatcher.BeginInvoke(new Action(() =>
            {
                Load();
            }));
            SetFullScreen();
            Loads.Completed += new EventHandler(Loads_Completed);

        }

        void Loads_Completed(object sender, EventArgs e)
        {
            ReloadWindow();
        }

        /// <summary>
        /// load Data
        /// </summary>
        public void Load()
        {
            IDSImporter importer = new StandardImport_Exl();
            if (importer.Import("Geology") != null) System.Windows.MessageBox.Show("Standard import succeeded");
            StandardLoader standardLoader = new StandardLoader();
            Standard = standardLoader.GetStandard();
            filter = standardLoader.CreateFilter();
            TunnelTypeCB.ItemsSource = filter.Tunnels;
            TunnelTypeCB.SelectedIndex = 0;
            ShowEmptyData();
            //ClassGenerator generator = new ClassGenerator();
            //generator.GenerateClass(Standard);

        }
        void SetFullScreen()
        {
            Rect rc = SystemParameters.WorkArea;//get the workArea
            this.Left = 0;//set window position
            this.Top = 0;
            this.Width = rc.Width / 2;
            this.Height = rc.Height;
        }
        private void ImportData_Click(object sender, RoutedEventArgs e)
        {
            ShowData();
        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {
            //Test();


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
            ShowData();
        }

        private void ExportDataTemplate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TreeNode treeNode = DataTemplateTreeview.SelectedItem as TreeNode;
                if (treeNode != null & Standard.Code == "Geology")
                {
                    switch (treeNode.Level)
                    {
                        case 1:
                            System.Windows.MessageBox.Show("Can not generate template for a stage conmtains duplicate forms");
                            return;
                        case 2:
                            GenerateCategoryTemplate(treeNode);
                            return;
                        case 3:
                            GenerateSingleTemplate(treeNode);
                            return;
                    }
                }
                if (treeNode != null & Standard.Code != "Geology")
                {
                    switch (treeNode.Level)
                    {
                        case 1:
                            GenerateTempleteForOther(treeNode);
                            return;
                        case 2:
                            GenerateSingleTemplate(treeNode);
                            return;

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        void GenerateStageTemplate(TreeNode treeNode)
        {
            try
            {
                DomainDef domain = new DomainDef() { Code = "Geology", LangStr = treeNode.Context };
                foreach (var item in treeNode.ChildNodes)
                {
                    foreach (var obj in item.ChildNodes)
                    {
                        DGObjectDef dG = Standard.GetDGObjectDefByName(obj.Context);
                        domain.DGObjectContainer.Add(dG);
                    }
                }
                new TemplateGenerator_Excel().Export(domain);
            }
            catch (Exception)
            {
                throw;
            }
        }
        void GenerateTempleteForOther(TreeNode treeNode)
        {
            try
            {
                DomainDef domain = new DomainDef() { Code = Standard.DomainContainer.Find(x => x.LangStr == treeNode.Context).Code, LangStr = treeNode.Context };
                foreach (var item in treeNode.ChildNodes)
                {
                    DGObjectDef dG = Standard.GetDGObjectDefByName(item.Context);
                    domain.DGObjectContainer.Add(dG);

                }
                new TemplateGenerator_Excel().Export(domain);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// generate template for one category
        /// </summary>
        /// <param name="selectedNode"></param>
        void GenerateCategoryTemplate(TreeNode selectedNode)
        {
            try
            {
                DomainDef domain = new DomainDef() { Code = Standard.Code, LangStr = selectedNode.Context };
                foreach (TreeNode childNode in selectedNode.ChildNodes)
                {
                    DGObjectDef dG = Standard.GetDGObjectDefByName(childNode.Context);
                    domain.DGObjectContainer.Add(dG);
                }
                new TemplateGenerator_Excel().Export(domain);

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        /// <summary>
        /// generate template for only one DGobject
        /// </summary>
        void GenerateSingleTemplate(TreeNode treeNode)
        {
            try
            {
                DomainDef domain = new DomainDef() { Code = treeNode.Context, LangStr = treeNode.Context };
                DGObjectDef dG = Standard.GetDGObjectDefByName(treeNode.Context);
                domain.DGObjectContainer.Add(dG);
                new TemplateGenerator_Excel().Export(domain);
            }
            catch (Exception)
            {
                throw;
            }
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
                if (selectedNode.Level == 3 & Standard.Code == "Geology")
                    ShowProperty(selectedNode.Context);
                if (selectedNode.Level == 2 & (Standard.Code != "Geology"))
                    ShowProperty(selectedNode.Context);
            }

        }

        void ShowProperty(string objName)
        {
            GridView gv = PropertyLV.View as GridView;
            if (gv != null)
            {
                foreach (GridViewColumn gvc in gv.Columns)
                {
                    gvc.Width = gvc.ActualWidth;
                    gvc.Width = Double.NaN;
                }
            }
            DGObjectDef dGObjectDef = Standard.GetDGObjectDefByName(objName);
            PropertyLV.ItemsSource = null;
            PropertyLV.ItemsSource = dGObjectDef.PropertyContainer;
        }
        private void ShowEmptyData()
        {
            try
            {
                DirectoryInfo localPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                string path = localPath.Parent.Parent.FullName + "\\Data\\" + Standard.Code + "_Empty.xls";


                IDataImporter dataImporter = new DataImporter_Excel();

                dataSet = dataImporter.Import(path, Standard);

                List<string> tableNames = new List<string>();
                foreach (DataTable table in dataSet.Tables)
                {
                    tableNames.Add(table.TableName);
                }
                if (tableNames.Count > 0)
                    DataHeaderLB.ItemsSource = tableNames;
            }
            catch (Exception) { }
        }
        private void ShowData()
        {
            try
            {
                Microsoft.Win32.OpenFileDialog OpenExcelFile = new Microsoft.Win32.OpenFileDialog();
                OpenExcelFile.Multiselect = true;
                OpenExcelFile.Filter = "Excel文件|*.xls;*.xlsx";
                if (OpenExcelFile.ShowDialog() == true)
                {
                    string[] filenames = OpenExcelFile.FileNames;
                    IDataImporter dataImporter = new DataImporter_Excel();
                    foreach (string path in filenames)
                    {
                        dataSet = dataImporter.Import(path, Standard);
                    }
                    List<string> tableNames = new List<string>();
                    foreach (DataTable table in dataSet.Tables)
                    {
                        if (table.Rows.Count > 0)
                            tableNames.Add(table.TableName);
                    }
                    foreach (DataTable table in dataSet.Tables)
                    {
                        if (table.Rows.Count == 0) tableNames.Add(table.TableName);
                    }
                    if (tableNames.Count > 0)
                        DataHeaderLB.ItemsSource = tableNames;
                }
            }
            catch (Exception) { }

        }

        /// <summary>
        /// show table names of Data import result
        /// </summary>
        private void DataHeaderLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataHeaderLB.SelectedItem != null)
            {
                string tableName = DataHeaderLB.SelectedItem as string;
                DataTable dataTable = dataSet.Tables[dataSet.Tables.IndexOf(tableName)];
                DataView dv = new DataView(dataTable);
                DataDG.ItemsSource = dv;
                //DataDG.EnableRowVirtualization = false;
                ChangeStyle style = new ChangeStyle(dataTable, ref DataDG, Standard);
                style.RefreshStyle();
                DataDG.ScrollIntoView(DataDG.Items[0]);
                DataDG.UpdateLayout();

            }

        }

        /// <summary>
        /// save user changes in gridview
        /// </summary>
        private void DataDG_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                DataTable tmpDT = ((DataView)DataDG.ItemsSource).Table;
                dataSet.Tables.RemoveAt(dataSet.Tables.IndexOf(tmpDT.TableName));
                dataSet.Tables.Add(tmpDT);
                //string tableName = DataHeaderLB.SelectedItem as string;
                //DataTable dataTable = dataSet.Tables[dataSet.Tables.IndexOf(tableName)];
                //DataDG.ItemsSource = dataTable.DefaultView;
                //ChangeStyle style = new ChangeStyle(dataTable, ref DataDG, Standard);
                //style.RefreshStyle();
                //DataDG.UpdateLayout();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        /// <summary>
        /// initial Sturcture Standard
        /// </summary>
        private void ConfigStruct_Click(object sender, RoutedEventArgs e)
        {
            LoadStandard("Structure");
        }

        /// <summary>
        /// initial Geology Standard
        /// </summary>
        private void ConfigGeology_Click(object sender, RoutedEventArgs e)
        {
            LoadStandard("Geology");
        }
        private void ConfigConstructin_Click(object sender, RoutedEventArgs e)
        {
            LoadStandard("Construction");
        }

        private void LoadStandard(string StandardName)
        {
            StandardName = StandardName ?? "Geology";
            IDSImporter importer = new StandardImport_Exl();
            if (importer.Import(StandardName) != null)
            {
                StandardLoader standardLoader = new StandardLoader();
                Standard = standardLoader.GetStandard(StandardName);
                System.Windows.MessageBox.Show(StandardName + " Standard imported succeessfully");
                filter = standardLoader.CreateFilter();
                ReloadWindow();
            }
        }
        private void ReloadWindow()
        {
            ViewData = new TreeViewData(tunnel, Standard);
            DataTemplateTreeview.DataContext = ViewData;
            if (PropertyLV.Items.Count == 1)
                PropertyLV.Items.RemoveAt(0);
        }

        private void TunnelTypeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tunnel = TunnelTypeCB.SelectedItem as Tunnel;
            ReloadWindow();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            DataImporter_Word dataImporter = new DataImporter_Word();
            dataImporter.OpenDoc();
        }

        private void SaveChangeBT_Click(object sender, RoutedEventArgs e)
        {
            Data2Localfile transfer = new Data2Localfile(dataSet);
            transfer.Data2Local();
            DataSet newDataset = transfer.LoadLocalData(Standard.Code);
            System.Windows.MessageBox.Show("Data  has been stored to DataBase!");
        }

        private void CheckDataBT_Click(object sender, RoutedEventArgs e)
        {
            DataCleaner dataCleaner = new DataCleaner(dataSet, Standard);
            MessageBox.Show("Program is cleaning the Data, please wait a few seconds...");
            //  Console.ReadLine();
            dataCleaner.Clean();
            dataSet = dataCleaner.dataSet;
            DataDG.DataContext = dataSet;
            DataDG.UpdateLayout();
            System.Windows.MessageBox.Show(@"Data has been cleaned");
        }

        private void Monitor_Click(object sender, RoutedEventArgs e)
        {
            LoadStandard("Monitoring");
        }

        private void Environment_Click(object sender, RoutedEventArgs e)
        {
            LoadStandard("Environment");
        }        

        private void MenuItem_SaveClick(object sender, RoutedEventArgs e)
        {
            ClassGenerator generator = new ClassGenerator();
            generator.GenerateClass(Standard);
        }
    }
}
