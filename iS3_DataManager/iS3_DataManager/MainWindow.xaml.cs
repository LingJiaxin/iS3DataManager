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
            
            //导入、加载数据标准
            StandardLoader loader = new StandardLoader();            
            DataStandardDef standard = loader.getStandard();

            //根据数据标准导出Excel模板
            IDataExporter exporter = new DataExporter_Excel();
            exporter.Export(standard);

            //根据数据标准生成数据类（写cs文件，需后续手动导入到解决方案）
            ClassGenerator classGenerator = new ClassGenerator();
            classGenerator.GenerateClass(standard);

            //IDSExporter exporter = new Exporter_For_JSON();//导出数据标准
            //DGObjectDef aimDGObjectDef = standard.getDGObjectDefByCode(aimDGObjectType);

            //从Excel导入数据
            IDataImporter importer = new DataImporter_Excel();
            string path = @"C:\Users\litao\Desktop\TunnelStandard.xls";
            DataSet ds= importer.Import(path);

             
            //存储数据
            IDataBaseManager dataManager = new DataBaseManager_EF();
            dataManager.Data2DB(ds, standard);

            //step8 : exporter the data
        }

        private void MainTab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
