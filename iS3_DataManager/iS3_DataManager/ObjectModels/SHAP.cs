using System; 
 namespace iS3_DataManager.ObjectModels
 { 
 	public class SHAP
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