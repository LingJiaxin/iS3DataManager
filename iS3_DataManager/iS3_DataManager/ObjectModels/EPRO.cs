using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_EPRO")]
	public class EPRO
 	{ 
		public string LOCA_ID {get;set;}
		public string EPRO_ID {get;set;}
		public string EPRO_TYPE {get;set;}
		public string EPRO_SERV {get;set;}
		public string EPRO_DSRG {get;set;}
		public string EPRO_RELA {get;set;}
		public string EPRO_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}