using System; 
 namespace iS3_DataManager.ObjectModels
 { 
 	public class GRMI
 	{ 
		public string GRMI_ID {get;set;}
		public Nullable<double> GRMI_GMPA {get;set;}
		public Nullable<int> GRMI_GMRP {get;set;}
		public string GRMI_SFI {get;set;}
		public string GRMI_DEG {get;set;}
		public Nullable<double> GRMI_BSA {get;set;}
		public string GRMI_SWV {get;set;}
		public string GRMI_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}