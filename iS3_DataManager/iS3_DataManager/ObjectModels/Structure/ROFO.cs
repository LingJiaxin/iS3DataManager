using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///仰拱回填///</summary>
	[Table("Structure_ROFO")]
	public class ROFO:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///基层材料 
		///</summary>
		public string ROFO_MATE {get;set;}
		/// <summary>
		///是否设仰拱 
		///</summary>
		public Nullable<bool> ROFO_YN {get;set;}
	}
}