using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_GQ")]
	public class GQ:DGObject
 	{ 
		public string GQ_NO {get;set;}
		public string GQ_ID {get;set;}
		public string GQ_CHAI {get;set;}
		public string GQ_INTE {get;set;}
		public string GQ_GESC {get;set;}
		public string GQ_WATE {get;set;}
		public string GQ_SURR {get;set;}
		public string GQ_RESU {get;set;}
		public string FILE_FSET {get;set;}
	}
}