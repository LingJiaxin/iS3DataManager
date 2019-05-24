using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_GETD")]
	public class GETD
 	{ 
		public string LOCA_ID {get;set;}
		public Nullable<double> GETD_DEPH {get;set;}
		public Nullable<int> GETD_TEMP {get;set;}
		public string GETD_METH {get;set;}
		public string STRA_ID {get;set;}
		public string GETD_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}