using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_TPSI")]
	public class TPSI:DGObject
 	{ 
		public string TPSI_SECTION {get;set;}
		public string TPSI_CHECKER {get;set;}
		public string TPSI_DATE {get;set;}
		public string TPSI_ZHQJ {get;set;}
		public string TPSI_JCWT {get;set;}
		public string TPSI_ZGZRR {get;set;}
		public string TPSI_ZGJG {get;set;}
		public string TPSI_ZGJD {get;set;}
		public string FILE_FSET {get;set;}
	}
}