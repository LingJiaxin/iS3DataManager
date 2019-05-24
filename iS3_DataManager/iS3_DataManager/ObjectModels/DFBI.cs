using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_DFBI")]
	public class DFBI
 	{ 
		public string PEOP_ID {get;set;}
		public string DFBI_METH {get;set;}
		public string DFBI_MILE {get;set;}
		public Nullable<double> DFBI_TUFM {get;set;}
		public Nullable<double> DFBI_LENG {get;set;}
		public string DFBI_TIME {get;set;}
		public string GEPR_ID {get;set;}
		public string GPSI_ID {get;set;}
		public string DFBI_FORC {get;set;}
		public string DFBI_ADVC {get;set;}
		public string DFBI_ACME {get;set;}
		public string DFBI_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}