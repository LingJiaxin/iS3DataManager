using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///污水沟///</summary>
	[Table("Structure_SEWD")]
	public class SEWD:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///污水沟材料 
		///</summary>
		public string SEWD_MATE {get;set;}
		/// <summary>
		///污水沟壁厚 
		///</summary>
		public Nullable<int> SEWD_THIC {get;set;}
		/// <summary>
		///污水沟内净宽 
		///</summary>
		public Nullable<int> SEWD_WIDH {get;set;}
		/// <summary>
		///污水沟内高度 
		///</summary>
		public Nullable<int> SEWD_HIGH {get;set;}
	}
}