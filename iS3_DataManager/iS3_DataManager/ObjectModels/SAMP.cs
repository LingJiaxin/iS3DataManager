using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_SAMP")]
	public class SAMP:DGObject
 	{ 
		public string LOCA_ID {get;set;}
		public string SAMP_ID {get;set;}
		public Nullable<double> SAMP_TOP {get;set;}
		public string SAMP_TYPE {get;set;}
		public Nullable<double> SAMP_BASE {get;set;}
		public string SAMP_DTIM {get;set;}
		public Nullable<int> SAMP_UBLO {get;set;}
		public string SAMP_PREP {get;set;}
		public Nullable<double> SAMP_WDEP {get;set;}
		public Nullable<int> SAMP_RECV {get;set;}
		public string SAMP_METH {get;set;}
		public string PEOP_ID {get;set;}
		public string SAMP_PURS {get;set;}
		public string SAMP_REM {get;set;}
		public Nullable<double> SAMP_BAR {get;set;}
		public Nullable<int> SAMP_TEMP {get;set;}
		public Nullable<double> SAMP_FLOW {get;set;}
		public string SAMP_ETIM {get;set;}
		public string SAMP_DURN {get;set;}
		public string FILE_FSET {get;set;}
	}
}