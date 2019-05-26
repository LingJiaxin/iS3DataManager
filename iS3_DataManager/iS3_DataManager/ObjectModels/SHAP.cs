using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_SHAP")]
	public class SHAP:DGObject
 	{ 
		public string SHAP_ID {get;set;}
		public string SHAP_TYPE {get;set;}
		public Nullable<int> SHAP_NUMB {get;set;}
		public string SHAP_DNO {get;set;}
		public Nullable<double> SHAP_NATE {get;set;}
		public Nullable<double> SHAP_NATN {get;set;}
		public Nullable<double> SHAP_GL {get;set;}
		public string SHAP_GREF {get;set;}
		public string SHAP_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}