using System; 
 namespace iS3_DataManager.ObjectModels
 { 
 	public class LOCA
 	{ 
		public string LOCA_ID {get;set;}
		public string LOCA_TYPE {get;set;}
		public Nullable<double> LOCA_NATE {get;set;}
		public Nullable<double> LOCA_NATN {get;set;}
		public Nullable<double> LOCA_GL {get;set;}
		public string LOCA_GREF {get;set;}
		public string LOCA_LOCM {get;set;}
		public string LOCA_CLST {get;set;}
		public string LOCA_CNGE {get;set;}
		public string LOCA_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}