using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_AGEO")]
	public class AGEO:DGObject
 	{ 
		public string LOCA_ID {get;set;}
		public string AGEO_ID {get;set;}
		public string AGEO_TYPE {get;set;}
		public string AGEO_DSRG {get;set;}
		public Nullable<double> AGEO_AREA {get;set;}
		public string AGEO_EGP {get;set;}
		public string AGEO_TLOD {get;set;}
		public string AGEO_LAWD {get;set;}
		public string AGEO_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}