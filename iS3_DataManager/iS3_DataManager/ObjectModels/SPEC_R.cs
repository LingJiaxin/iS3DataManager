using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_SPEC_R")]
	public class SPEC_R:DGObject
 	{ 
		public string LOCA_ID {get;set;}
		public string SPEC_ID {get;set;}
		public string SPEC_TYPE {get;set;}
		public string SPEC_DSRG {get;set;}
		public Nullable<double> SPEC_AREA {get;set;}
		public string SPEC_EGP {get;set;}
		public string SPEC_RELA {get;set;}
		public string SPEC_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}