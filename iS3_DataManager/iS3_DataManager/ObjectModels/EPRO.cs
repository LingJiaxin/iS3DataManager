using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_EPRO")]
	public class EPRO:DGObject
 	{ 
		public string LOCA_ID {get;set;}
		public string EPRO_ID {get;set;}
		public string EPRO_TYPE {get;set;}
		public string EPRO_SERV {get;set;}
		public string EPRO_DSRG {get;set;}
		public string EPRO_RELA {get;set;}
		public string EPRO_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}