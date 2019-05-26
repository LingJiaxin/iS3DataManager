using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_FOLD")]
	public class FOLD:DGObject
 	{ 
		public string FOLD_ID {get;set;}
		public string FOLD_NAME {get;set;}
		public string FOLD_TYPE {get;set;}
		public string FOLD_CAUS {get;set;}
		public string FOLD_ATTD {get;set;}
		public string FOLD_REL1 {get;set;}
		public string FOLD_REL2 {get;set;}
		public string FOLD_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}