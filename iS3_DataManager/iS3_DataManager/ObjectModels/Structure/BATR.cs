using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///有砟轨道///</summary>
	[Table("Structure_BATR")]
	public class BATR:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINI_TYPE {get;set;}
		/// <summary>
		///轨道宽度 
		///</summary>
		public Nullable<int> BATR_WIDH {get;set;}
		/// <summary>
		///轨枕间距 
		///</summary>
		public Nullable<int> BATR_SPAC {get;set;}
		/// <summary>
		///轨枕长度 
		///</summary>
		public Nullable<int> BATR_LENG {get;set;}
		/// <summary>
		///砟料成分 
		///</summary>
		public string BATR_MATE {get;set;}
	}
}