using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_SPZL")]
	public class SPZL:DGObject
 	{ 
		public string SPZL_SECTION {get;set;}
		public string SPZL_UPLOADER {get;set;}
		public string SPZL_DATE {get;set;}
		public string SPZL_ZHQJ {get;set;}
		public string SPZL_SPMC {get;set;}
		public string SPZL_DISC {get;set;}
		public string FILE_FSET {get;set;}
	}
}