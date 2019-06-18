using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///沿桩衬砌类型///</summary>
	[Table("Structure_MILI")]
	public class MILI:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///起始里程桩号 
		///</summary>
		public string MILI_STAR {get;set;}
		/// <summary>
		///终止里程桩号 
		///</summary>
		public string MILI_END {get;set;}
		/// <summary>
		///衬砌类型 
		///</summary>
		public string MILI_LNTY {get;set;}
	}
}