using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_RTST")]
	public class RTST:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string RTST_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string RTST_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string RTST_EQUP {get;set;}
		public string RTST_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string RTST_TESN {get;set;}
		public string RTST_METH {get;set;}
		public string RTST_STAT {get;set;}
		public string STRA_ID {get;set;}
		public Nullable<double> RTST_MC {get;set;}
		public Nullable<double> RTST_SDIA {get;set;}
		public Nullable<double> RTST_HEIG {get;set;}
		public string RTST_COND {get;set;}
		public string RTST_DURN {get;set;}
		public Nullable<int> RTST_STRA {get;set;}
		public string RTST_TENS {get;set;}
		public string RTST_REM {get;set;}
	}
}