using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_ACHE")]
	public class ACHE:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string PROG_NAME {get;set;}
		public string PROG_LORR {get;set;}
		public string PROG_DATE {get;set;}
		public string PROG_END {get;set;}
		public string PROG_SGJD {get;set;}
		public string PROG_CQJD {get;set;}
		public string PROG_CCJD {get;set;}
		public string PROG_ECJD {get;set;}
		public string FILE_FSET {get;set;}
		public string PROG_YGJD {get;set;}
	}
}