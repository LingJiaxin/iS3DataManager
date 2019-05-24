using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_RSVR")]
	public class RSVR
 	{ 
		public string RSVR_ID {get;set;}
		public string RSVR_NAME {get;set;}
		public string RSVR_LOCA {get;set;}
		public Nullable<double> RSVR_DCA {get;set;}
		public Nullable<double> RSVR_CFAR {get;set;}
		public Nullable<double> RSVR_DRYF {get;set;}
		public Nullable<double> RSVR_RAIF {get;set;}
		public string FILE_FSET {get;set;}
	}
}