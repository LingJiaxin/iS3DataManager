using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_RIVR")]
	public class RIVR:DGObject
 	{ 
		public string RIVR_ID {get;set;}
		public string RIVR_NAME {get;set;}
		public string RIVR_LOCA {get;set;}
		public Nullable<double> RIVR_DCA {get;set;}
		public string RIVR_SYS {get;set;}
		public Nullable<double> RIVR_CFAR {get;set;}
		public Nullable<double> RIVR_DRYF {get;set;}
		public Nullable<double> RIVR_RAIF {get;set;}
		public string FILE_FSET {get;set;}
	}
}