using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_PROJ")]
	public class PROJ
 	{ 
		public string PROJ_ID {get;set;}
		public string PROJ_NAME {get;set;}
		public string PROJ_PURP {get;set;}
		public string PROJ_LOCA {get;set;}
		public string PROJ_TRND {get;set;}
		public string PROJ_CLNT {get;set;}
		public string PROJ_CONT {get;set;}
		public string PROJ_MNGR {get;set;}
		public string PROJ_COND {get;set;}
		public string PROJ_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}