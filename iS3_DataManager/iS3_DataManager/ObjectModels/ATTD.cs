using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_ATTD")]
	public class ATTD:DGObject
 	{ 
		public string LOCA_ID {get;set;}
		public string ATTD_ID {get;set;}
		public Nullable<double> ATTD_DIR {get;set;}
		public Nullable<double> ATTD_DIP {get;set;}
		public string ATTD_STRA {get;set;}
		public string ATTD_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}