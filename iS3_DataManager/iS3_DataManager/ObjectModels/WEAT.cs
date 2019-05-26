using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_WEAT")]
	public class WEAT:DGObject
 	{ 
		public string WEAT_ID {get;set;}
		public string SHAP_ID {get;set;}
		public string WEAT_DSRG {get;set;}
		public string WEAT_TYPE {get;set;}
		public Nullable<double> WEAT_MAP {get;set;}
		public Nullable<double> WEAT_MAT {get;set;}
		public string WEAT_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}