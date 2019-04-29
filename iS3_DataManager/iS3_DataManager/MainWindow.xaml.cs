using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
        public MainWindow()
        {
            InitializeComponent();
            ChoiceLB.SelectedIndex = -1;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            IDSImporter importer = new StandardImport_Exl();
            standard = importer.Import(null);

            //StandardLoader loader = new StandardLoader();
            //DataStandardDef standard1 = loader.getStandard(null);
            //List<string> domainNameList = new List<string>();
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

        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {

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
            OpenExcelFile.InitialDirectory = "D:\\";
            OpenExcelFile.Filter = "Excel文件|*.xls";
            OpenExcelFile.ShowDialog();
        }

        private void ExportDataTemplate_Click(object sender, RoutedEventArgs e)
        {
            List<DGObjectDef> objList = new List<DGObjectDef>();
            foreach (DGObjectDef item in ObjectNameLB.SelectedItems)
            {
                objList.Add(item);
            }
             ;            
            DomainDef selectedDomain = (DomainDef)DomainNameLB.SelectedItem ?? (DomainDef)DomainNameLB.Items[0];
            DomainDef domain = new DomainDef
            {
                Code = selectedDomain.Code,
                LangStr = selectedDomain.LangStr,
                Desciption = selectedDomain.Desciption,
                DGObjectContainer = objList
            };
            IDataExporter dataExporter = new DataExporter_Excel();
            dataExporter.Export(domain);
            
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
        }
    }
}
