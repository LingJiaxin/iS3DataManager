using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_IRSI")]
	public class IRSI:DGObject
 	{ 
		public string AERP_ID {get;set;}
		public string IRSI_ID {get;set;}
		public string IRSI_MEAN {get;set;}
		public string IRSI_PTYPE {get;set;}
		public string IRSI_GTYPE {get;set;}
		public string IRSI_SIGN {get;set;}
		public string IRSI_OIPM {get;set;}
		public string IRSI_DIPM {get;set;}
		public string IRSI_STAFF {get;set;}
		public string IRSI_CONT {get;set;}
		public string FILE_FSET {get;set;}
	}
}