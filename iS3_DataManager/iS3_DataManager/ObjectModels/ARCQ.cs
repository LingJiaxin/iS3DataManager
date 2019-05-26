using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_ARCQ")]
	public class ARCQ:DGObject
 	{ 
		public string ARCQ_NO {get;set;}
		public string ARCQ_ID {get;set;}
		public string ARCQ_CHAI {get;set;}
		public string ARCQ_INTE {get;set;}
		public string ARCQ_GESC {get;set;}
		public string ARCQ_WATE {get;set;}
		public string ARCQ_SURR {get;set;}
		public string ARCQ_RESU {get;set;}
		public string FILE_FSET {get;set;}
	}
}