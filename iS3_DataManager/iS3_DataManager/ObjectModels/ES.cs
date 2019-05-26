using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_ES")]
	public class ES:DGObject
 	{ 
		public string ES_NO {get;set;}
		public string ES_ID {get;set;}
		public string ES_CHAI {get;set;}
		public string ES_INTE {get;set;}
		public string ES_EXCA {get;set;}
		public string ES_SURR {get;set;}
		public string ES_RESU {get;set;}
		public string FILE_FSET {get;set;}
	}
}