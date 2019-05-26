using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_CSIS")]
	public class CSIS:DGObject
 	{ 
		public string CSIS_ID {get;set;}
		public string CSIS_FDNB {get;set;}
		public string CSIS_LRFF {get;set;}
		public string CSIS_MILE {get;set;}
		public string CSIS_RETM {get;set;}
		public string CSIS_SGCH {get;set;}
		public string CSIS_CWZH {get;set;}
		public string CSIS_ECZH {get;set;}
	}
}