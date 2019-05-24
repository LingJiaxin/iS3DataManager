using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_HYWA")]
	public class HYWA
 	{ 
		public string HYDW_ID {get;set;}
		public string HYWA_CODE {get;set;}
		public string STRA_ID {get;set;}
		public Nullable<double> HYWA_TOP {get;set;}
		public Nullable<double> HYWA_BASE {get;set;}
		public Nullable<double> HYWA_DEPT {get;set;}
	}
}