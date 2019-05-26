using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_ILCQ")]
	public class ILCQ:DGObject
 	{ 
		public string ILCQ_NO {get;set;}
		public string ILCQ_ID {get;set;}
		public string ILCQ_CHAI {get;set;}
		public string ILCQ_INTE {get;set;}
		public string ILCQ_GESC {get;set;}
		public string ILCQ_WATE {get;set;}
		public string ILCQ_SURR {get;set;}
		public string ILCQ_RESU {get;set;}
		public string FILE_FSET {get;set;}
	}
}