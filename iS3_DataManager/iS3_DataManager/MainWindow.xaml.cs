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
        public MainWindow()
        {
            
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //step1 : find the aim object def
            //string aimDGObjectType = "Borehole";
            
            //load standard
            StandardLoader loader = new StandardLoader();            
            DataStandardDef standard = loader.getStandard();

            //export excel templete for data input 
            //IDataExporter exporter = new DataExporter_Excel();
            //exporter.Export(standard);

            //generate data model according standard（write cs file ,need to be added manually）
            //ClassGenerator classGenerator = new ClassGenerator();
            //classGenerator.GenerateClass(standard);

            //IDSExporter exporter = new Exporter_For_JSON();//export data standard
            //DGObjectDef aimDGObjectDef = standard.getDGObjectDefByCode(aimDGObjectType);

            //Import Data from excel
            IDataImporter importer = new DataImporter_Excel();
            string path = @"C:\Users\litao\Desktop\Geology.xls";
            DataSet ds= importer.Import(path,standard);

            DataChecker checker = new DataChecker(ds,standard);
            checker.Check();
            //store data to database
            IDataBaseManager dataManager = new DataBaseManager_EF();
            dataManager.Data2DB(ds, standard);

            //step8 : exporter the data
        }

        private void MainTab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
