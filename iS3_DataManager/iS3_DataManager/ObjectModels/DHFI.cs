using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_DHFI")]
	public class DHFI:DGObject
 	{ 
		public string DFBI_MILE {get;set;}
		public Nullable<double> DFBI_TUFM {get;set;}
		public string DHRA_ID {get;set;}
		public string STRA_STAT {get;set;}
		public string DHRA_FMV {get;set;}
		public Nullable<double> DHRA_LAYT {get;set;}
		public string DHRA_WATL {get;set;}
		public Nullable<double> DHRA_WATO {get;set;}
		public string SAMP_ID {get;set;}
		public string DHRA_BDEG {get;set;}
		public string DHFI_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}