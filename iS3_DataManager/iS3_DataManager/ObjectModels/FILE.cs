using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_FILE")]
	public class FILE:DGObject
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