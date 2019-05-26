using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_GCS")]
	public class GCS:DGObject
 	{ 
		public string GCS_NO {get;set;}
		public string GCS_ID {get;set;}
		public string GCS_CHAI {get;set;}
		public string GCS_INTE {get;set;}
		public string GCS_SUPP {get;set;}
		public string GCS_SURR {get;set;}
		public string GCS_RGCSU {get;set;}
		public string FILE_FSET {get;set;}
	}
}