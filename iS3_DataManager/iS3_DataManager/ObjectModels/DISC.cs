using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_DISC")]
	public class DISC
 	{ 
		public string FRAC_SET {get;set;}
		public string DISC_NUMB {get;set;}
		public string DISC_TYPE {get;set;}
		public Nullable<int> DISC_DIP {get;set;}
		public Nullable<int> DISC_DIR {get;set;}
		public string DISC_RS {get;set;}
		public string DISC_RL {get;set;}
		public Nullable<double> DISC_WAVE {get;set;}
		public Nullable<double> DISC_AMP {get;set;}
		public Nullable<bool> DISC_KARST {get;set;}
		public Nullable<int> DISC_JRC {get;set;}
		public string DISC_APP {get;set;}
		public Nullable<int> DISC_APT {get;set;}
		public Nullable<bool> DISC_APOB {get;set;}
		public string DISC_INFM {get;set;}
		public string DISC_DUCT {get;set;}
		public Nullable<int> DISC_STR {get;set;}
		public string DISC_WETH {get;set;}
		public string DISC_SEEP {get;set;}
		public Nullable<int> DISC_FLOW {get;set;}
		public string DISC_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}