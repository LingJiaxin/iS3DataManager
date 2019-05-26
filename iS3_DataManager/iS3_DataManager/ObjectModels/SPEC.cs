using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_SPEC")]
	public class SPEC:DGObject
 	{ 
		public string SAMP_ID {get;set;}
		public string HDPH_ID {get;set;}
		public string SPEC_ID {get;set;}
		public string SPEC_CONT {get;set;}
		public string SPEC_MATX {get;set;}
		public string SPEC_DESC {get;set;}
		public string SPEC_SIZE {get;set;}
		public string SPEC_DESD {get;set;}
		public string PEOP_ID {get;set;}
		public string SPEC_COND {get;set;}
		public string STRA_ID {get;set;}
		public string SPEC_PREP {get;set;}
		public string SPEC_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}