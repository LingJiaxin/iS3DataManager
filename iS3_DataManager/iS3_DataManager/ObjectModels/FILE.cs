using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_FILE")]
	public class FILE
 	{ 
		public string FILE_FSET {get;set;}
		public string FILE_NAME {get;set;}
		public string FILE_DESC {get;set;}
		public string FILE_TYPE {get;set;}
		public string FILE_PROG {get;set;}
		public string FILE_DOCT {get;set;}
		public string FILE_DATE {get;set;}
	}
}