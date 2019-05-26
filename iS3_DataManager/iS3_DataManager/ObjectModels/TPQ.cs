using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_TPQ")]
	public class TPQ:DGObject
 	{ 
		public string TPQ_NO {get;set;}
		public string TPQ_ID {get;set;}
		public string TPQ_CHAI {get;set;}
		public string TPQ_INTE {get;set;}
		public string TPQ_GESC {get;set;}
		public string TPQ_WATE {get;set;}
		public string TPQ_SURR {get;set;}
		public string TPQ_RESU {get;set;}
		public string FILE_FSET {get;set;}
	}
}