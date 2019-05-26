using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_ORGA")]
	public class ORGA:DGObject
 	{ 
		public string ORGA_ID {get;set;}
		public string ORGA_NAME {get;set;}
		public string ORGA_CODE {get;set;}
		public string ORGA_TYPE {get;set;}
		public string ORGA_DESC {get;set;}
		public string ORGA_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}