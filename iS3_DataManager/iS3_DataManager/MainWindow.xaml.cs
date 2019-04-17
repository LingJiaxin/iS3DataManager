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

namespace iS3_DataManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //step1 : find the aim object def
            //string aimDGObjectType = "Borehole";
            StandardLoader loader = new StandardLoader();
             DataStandardDef standard = loader.getStandard();
            //IDataExporter exporter = new DataExporter_Excel();
            //exporter.Export(standard);
            //IDSExporter exporter = new Exporter_For_JSON();
            //DGObjectDef aimDGObjectDef = standard.getDGObjectDefByCode(aimDGObjectType);

            //step2:
            //IDataImporter importer = new DataImporter_Excel();
            //string path = @"C:\Users\litao\Desktop\TunnelStandard.xls";
            //System.Data.DataSet ds= importer.Import(path);

            ClassGenerator classGenerator = new ClassGenerator();
            classGenerator.GenerateClass(standard);


            //setp7 : save the data
            IDataBaseManager dataManager = new DataBaseManager_SQL();
            //dataManager.WriteData(new System.Data.DataSet());

            //step8 : exporter the data
        }

        private void MainTab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
