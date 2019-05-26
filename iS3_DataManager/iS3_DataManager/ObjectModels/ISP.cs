using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_ISP")]
	public class ISP:DGObject
 	{ 
		public string ISP_NO {get;set;}
		public string ISP_ID {get;set;}
		public string ISP_CHAI {get;set;}
		public string ISP_INTE {get;set;}
		public string ISP_SUPP {get;set;}
		public string ISP_SURR {get;set;}
		public string ISP_RESU {get;set;}
		public string FILE_FSET {get;set;}
	}
}