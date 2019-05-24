using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_HDPF")]
	public class HDPF
 	{ 
		public string LOCA_ID {get;set;}
		public string STRA_ID {get;set;}
		public Nullable<double> HDPF_TOP {get;set;}
		public Nullable<double> HDPF_BASE {get;set;}
	}
}