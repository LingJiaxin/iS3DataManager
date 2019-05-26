using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_HDPF")]
	public class HDPF:DGObject
 	{ 
		public string LOCA_ID {get;set;}
		public string STRA_ID {get;set;}
		public Nullable<double> HDPF_TOP {get;set;}
		public Nullable<double> HDPF_BASE {get;set;}
	}
}