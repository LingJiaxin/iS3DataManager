using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_ATTD")]
	public class ATTD
 	{ 
		public string LOCA_ID {get;set;}
		public string ATTD_ID {get;set;}
		public Nullable<double> ATTD_DIR {get;set;}
		public Nullable<double> ATTD_DIP {get;set;}
		public string ATTD_STRA {get;set;}
		public string ATTD_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}