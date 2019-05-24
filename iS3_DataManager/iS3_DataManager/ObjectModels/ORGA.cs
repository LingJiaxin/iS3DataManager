using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_ORGA")]
	public class ORGA
 	{ 
		public string ORGA_ID {get;set;}
		public string ORGA_NAME {get;set;}
		public string ORGA_CODE {get;set;}
		public string ORGA_TYPE {get;set;}
		public string ORGA_DESC {get;set;}
		public string ORGA_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}