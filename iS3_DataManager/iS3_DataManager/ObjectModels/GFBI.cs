using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_GFBI")]
	public class GFBI
 	{ 
		public string PEOP_ID {get;set;}
		public string GFBI_MILE {get;set;}
		public Nullable<double> GFBI_TUFM {get;set;}
		public string GFBI_METH {get;set;}
		public string GFBI_NAME {get;set;}
		public Nullable<double> GFBI_LENG {get;set;}
		public string GFBI_TIME {get;set;}
		public string GEPR_ID {get;set;}
		public string GFBI_ID {get;set;}
		public string GFBI_FORC {get;set;}
		public string GFBI_ADVC {get;set;}
		public string GFBI_ACME {get;set;}
		public string GFBI_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}