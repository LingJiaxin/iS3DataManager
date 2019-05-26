using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_SSP")]
	public class SSP:DGObject
 	{ 
		public string SSP_NO {get;set;}
		public string SSP_ID {get;set;}
		public string SSP_CHAI {get;set;}
		public string SSP_INTE {get;set;}
		public string SSP_SUPP {get;set;}
		public string SSP_SURR {get;set;}
		public string SSP_RSSPU {get;set;}
		public string FILE_FSET {get;set;}
	}
}