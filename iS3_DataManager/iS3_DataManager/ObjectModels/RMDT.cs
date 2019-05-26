using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_RMDT")]
	public class RMDT:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string RMDT_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string RMDT_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string RMDT_EQUP {get;set;}
		public string RMDT_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string RMDT_TESN {get;set;}
		public string RMDT_METH {get;set;}
		public string RMDT_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string RMDT_LITH {get;set;}
		public string RMDT_DESC {get;set;}
		public string RMDT_SHEN {get;set;}
		public string RMDT_COLL {get;set;}
		public string RMDT_NAME1 {get;set;}
		public string RMDT_NAME2 {get;set;}
		public string RMDT_REM {get;set;}
	}
}