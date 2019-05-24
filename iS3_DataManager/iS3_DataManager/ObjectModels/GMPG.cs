using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_GMPG")]
	public class GMPG
 	{ 
		public string PROJ_ID {get;set;}
		public string GMPG_ID {get;set;}
		public string GMPG_DSRG {get;set;}
		public string GMPG_FMRS {get;set;}
		public string GMPG_TYPE {get;set;}
		public string GMPG_CHAR {get;set;}
		public string FILE_FSET {get;set;}
	}
}