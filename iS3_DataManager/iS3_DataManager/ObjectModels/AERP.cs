using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_AERP")]
	public class AERP:DGObject
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