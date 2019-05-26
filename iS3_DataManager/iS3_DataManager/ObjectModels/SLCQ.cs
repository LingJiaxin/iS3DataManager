using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_SLCQ")]
	public class SLCQ:DGObject
 	{ 
		public string SLCQ_NO {get;set;}
		public string SLCQ_ID {get;set;}
		public string SLCQ_CHAI {get;set;}
		public string SLCQ_INTE {get;set;}
		public string SLCQ_GESC {get;set;}
		public string SLCQ_WATE {get;set;}
		public string SLCQ_SURR {get;set;}
		public string SLCQ_RESU {get;set;}
		public string FILE_FSET {get;set;}
	}
}