using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_PEOP")]
	public class PEOP:DGObject
 	{ 
		public string PEOP_ID {get;set;}
		public string PEOP_TPNA {get;set;}
		public string PEOP_TPIC {get;set;}
		public string PEOP_TPPN {get;set;}
		public string PEOP_RENA {get;set;}
		public string PEOP_REIC {get;set;}
		public string PEOP_REPN {get;set;}
		public string PEOP_SISU {get;set;}
		public string PEOP_SSIC {get;set;}
		public string PEOP_SSPN {get;set;}
		public string PEOP_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}