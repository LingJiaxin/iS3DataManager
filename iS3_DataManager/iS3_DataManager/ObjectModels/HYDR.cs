using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_HYDR")]
	public class HYDR
 	{ 
		public string PROJ_ID {get;set;}
		public Nullable<int> HYDR_NMRV {get;set;}
		public Nullable<int> HYDR_NMRS {get;set;}
		public string HYDR_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}