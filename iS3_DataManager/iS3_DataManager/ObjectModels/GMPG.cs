using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_GMPG")]
	public class GMPG:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string GMPG_ID {get;set;}
		public string GMPG_DSRG {get;set;}
		public string GMPG_FMRS {get;set;}
		public string GMPG_TYPE {get;set;}
		public string GMPG_CHAR {get;set;}
		public string FILE_FSET {get;set;}
	}
}