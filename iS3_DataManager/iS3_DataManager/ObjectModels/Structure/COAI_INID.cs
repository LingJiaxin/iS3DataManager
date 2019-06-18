using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///联络风道_初设///</summary>
	[Table("Structure_COAI_INID")]
	public class COAI_INID:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///联络风道编号 
		///</summary>
		public string COAI_NUMB {get;set;}
		/// <summary>
		///联络风道中心桩号 
		///</summary>
		public string COAI_MILE {get;set;}
	}
}