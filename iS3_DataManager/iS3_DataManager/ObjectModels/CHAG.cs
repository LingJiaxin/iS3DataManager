using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_CHAG")]
	public class CHAG:DGObject
 	{ 
		public string CHAG_NUMB {get;set;}
		public string CHAG_NAME {get;set;}
		public string CHAG_CHAI {get;set;}
		public string CHAG_TYPE1 {get;set;}
		public string CHAG_PRIM {get;set;}
		public string CHAG_PRES {get;set;}
		public string CHAG_REAS {get;set;}
		public string CHAG_MANA {get;set;}
		public string CHAG_DATE1 {get;set;}
		public string CHAG_DATE2 {get;set;}
		public string FILE_FSET {get;set;}
	}
}