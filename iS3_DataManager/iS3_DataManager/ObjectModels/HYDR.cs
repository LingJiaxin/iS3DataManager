using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_HYDR")]
	public class HYDR:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public Nullable<int> HYDR_NMRV {get;set;}
		public Nullable<int> HYDR_NMRS {get;set;}
		public string HYDR_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}