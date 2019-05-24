using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_FRAC")]
	public class FRAC
 	{ 
		public string FRAC_SET {get;set;}
		public Nullable<int> FRAC_IMAX {get;set;}
		public Nullable<int> FRAC_IAVE {get;set;}
		public Nullable<int> FRAC_IMIN {get;set;}
		public Nullable<int> FRAC_INDX {get;set;}
		public string FRAC_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}