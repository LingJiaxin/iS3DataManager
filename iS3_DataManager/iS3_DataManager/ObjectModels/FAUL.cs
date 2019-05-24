using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_FAUL")]
	public class FAUL
 	{ 
		public string FAUL_ID {get;set;}
		public string FAUL_NAME {get;set;}
		public string FAUL_CAUS {get;set;}
		public string FAUL_ATTD {get;set;}
		public Nullable<bool> FAUL_ACTI {get;set;}
		public Nullable<double> FAUL_BRED {get;set;}
		public string FAUL_TYPE {get;set;}
		public string FAUL_FFZC {get;set;}
		public Nullable<double> FAUL_LGTH {get;set;}
		public string FAUL_RELA {get;set;}
		public string FAUL_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}