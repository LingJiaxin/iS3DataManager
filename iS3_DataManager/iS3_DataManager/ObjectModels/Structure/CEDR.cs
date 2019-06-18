using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///中心排水沟///</summary>
	[Table("Structure_CEDR")]
	public class CEDR:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///中心排水沟材料 
		///</summary>
		public string CEDR_MATE {get;set;}
		/// <summary>
		///中心排水沟壁厚 
		///</summary>
		public Nullable<int> CEDR_THIC {get;set;}
		/// <summary>
		///中心排水沟内径 
		///</summary>
		public Nullable<int> CEDR_RADI {get;set;}
	}
}