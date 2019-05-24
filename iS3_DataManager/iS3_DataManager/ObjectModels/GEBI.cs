using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_GEBI")]
	public class GEBI
 	{ 
		public string GEBI_ID {get;set;}
		public string GEBI_MILE {get;set;}
		public string GEBI_SMIL {get;set;}
		public string GEBI_EMIL {get;set;}
		public Nullable<double> GEBI_LENG {get;set;}
		public string GEBI_PCS {get;set;}
		public Nullable<double> GEBI_MPS {get;set;}
		public Nullable<double> GEBI_PROD {get;set;}
		public string GEBI_METH {get;set;}
		public string GEBI_DTIM {get;set;}
		public string GEBI_DEVI {get;set;}
		public string GEBI_CONT {get;set;}
		public string PEOP_ID {get;set;}
		public string GEBI_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}