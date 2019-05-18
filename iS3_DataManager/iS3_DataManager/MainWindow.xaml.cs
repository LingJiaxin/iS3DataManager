﻿using System.Collections.Generic;
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
        private void Test()
        {
            DataSet2Entity transporter = new DataSet2Entity();
            transporter.Data2DataBase(dataSet ,Standard);
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
            ReloadWindow();
        }
        /// <summary>
        /// load Data
        /// </summary>
        public void Load()
        {
            //IDSImporter importer = new StandardImport_Exl();
            //if (importer.Import("Geology") != null) System.Windows.MessageBox.Show("Standard import succeeded");
            StandardLoader standardLoader = new StandardLoader();
            Standard = standardLoader.GetStandard();
            filter = standardLoader.CreateFilter();
            //ClassGenerator generator = new ClassGenerator();
            //generator.GenerateClass(Standard);
            
        }

        private void ImportData_Click(object sender, RoutedEventArgs e)
        {
            ShowData();
        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {
            Test();
            DataChecker checker = new DataChecker(dataSet, Standard);
            checker.Check();
            System.Windows.MessageBox.Show("Data  has been stored to DataBase!");
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
                if (treeNode != null)
                {
                    switch (treeNode.Level)
                    {
                        case 1:
                            MessageBox.Show("Please select Stage/Category/DGobject to generate template!");
                            return;
                        case 2:
                            GenerateStageTemplate(treeNode);
                            return;
                        case 3:
                            GenerateCategoryTemplate(treeNode);
                            return;
                        case 4:
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
                DomainDef domain = new DomainDef() { Code = "DataTemplate_Category", LangStr = treeNode.Context };
                foreach (var item in treeNode.ChildNodes)
                {
                    foreach (var obj in item.ChildNodes)
                    {
                        domain.DGObjectContainer.Add(Standard.GetDGObjectDefByName(obj.Context));
                    }
                }
                new Exporter_Excel().Export(domain);
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
                DomainDef domain = new DomainDef() { Code = "Data Template", LangStr = selectedNode.Context };
                foreach (TreeNode childNode in selectedNode.ChildNodes)
                {
                    domain.DGObjectContainer.Add(Standard.GetDGObjectDefByName(childNode.Context));
                }
                new Exporter_Excel().Export(domain);

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
                DomainDef domain = new DomainDef() { Code = "Default", LangStr = treeNode.Context };
                domain.DGObjectContainer.Add(Standard.GetDGObjectDefByName(treeNode.Context));
                new Exporter_Excel().Export(domain);
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
            if (selectedNode != null & selectedNode.Level == 4)
            {
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
        private void ShowData()
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
                    if(table.Rows.Count>0)
                    tableNames.Add(table.TableName);
                }
                foreach(DataTable table in dataSet.Tables)
                {
                    if (table.Rows.Count == 0) tableNames.Add(table.TableName);
                }
                if (tableNames.Count > 0)
                    DataHeaderLB.ItemsSource = tableNames;
            }

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
                DataDG.ItemsSource = dataTable.DefaultView;
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
        private void LoadStandard(string StandardName)
        {
            StandardName = StandardName ?? "Geology";
            IDSImporter importer = new StandardImport_Exl();
            if (importer.Import(StandardName) != null)
            {
                StandardLoader standardLoader = new StandardLoader();
                Standard = standardLoader.GetStandard(StandardName);
                System.Windows.MessageBox.Show(StandardName+" Standard imported succeessfully");
                filter = standardLoader.CreateFilter();
                ReloadWindow();
            }
        }
        private void ReloadWindow()
        {
            ViewData = new TreeViewData(filter, Standard);
            DataTemplateTreeview.DataContext = ViewData;
            if(PropertyLV.Items.Count>0)
            PropertyLV.Items.RemoveAt(0);
        }
    }
}
