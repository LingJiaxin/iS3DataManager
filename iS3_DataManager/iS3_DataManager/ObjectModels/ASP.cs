using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_ASP")]
	public class ASP:DGObject
 	{ 
		public string ASP_NO {get;set;}
		public string ASP_ID {get;set;}
		public string ASP_INTE {get;set;}
		public string ASP_SUPP {get;set;}
		public string ASP_SRL {get;set;}
		public string FILE_FSET {get;set;}
	}
}