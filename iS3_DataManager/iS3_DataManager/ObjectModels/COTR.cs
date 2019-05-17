using System; 
 namespace iS3_DataManager.ObjectModels
 { 
 	public class COTR
 	{ 
		public string PROJ_ID {get;set;}
		public string GMPG_ID {get;set;}
		public Nullable<int> COTR_NSP {get;set;}
		public Nullable<double> COTR_ELEV {get;set;}
		public Nullable<double> COTR_XATR {get;set;}
		public Nullable<double> COTR_XEND {get;set;}
		public Nullable<double> COTR_YSTR {get;set;}
		public Nullable<double> COTR_YEND {get;set;}
		public string COTR_IM {get;set;}
		public Nullable<double> COTR_XDIS {get;set;}
		public Nullable<double> COTR_YDIS {get;set;}
		public string FILE_FSET {get;set;}
	}
}