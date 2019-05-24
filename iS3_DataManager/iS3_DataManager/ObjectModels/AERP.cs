using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_AERP")]
	public class AERP
 	{ 
		public string AERP_ID {get;set;}
		public string AERP_TYPE {get;set;}
		public Nullable<double> AERP_HEIG {get;set;}
		public Nullable<int> AERP_DIP {get;set;}
		public string AERP_DTIM {get;set;}
		public string AERP_STAFF {get;set;}
		public string AERP_CONT {get;set;}
		public string FILE_FSET {get;set;}
	}
}