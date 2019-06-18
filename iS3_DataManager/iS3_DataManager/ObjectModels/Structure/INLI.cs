using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///斜井///</summary>
	[Table("Structure_INLI")]
	public class INLI:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///混凝土型号 
		///</summary>
		public string SHCO_TYPE {get;set;}
		/// <summary>
		///斜井布设位置 
		///</summary>
		public string LINE_LOCA {get;set;}
		/// <summary>
		///起始桩号 
		///</summary>
		public string LINE_STAR {get;set;}
		/// <summary>
		///终止桩号 
		///</summary>
		public string LINE_END {get;set;}
		/// <summary>
		///拱顶二衬厚度 
		///</summary>
		public Nullable<int> INLI_THIT {get;set;}
		/// <summary>
		///侧墙二衬厚度 
		///</summary>
		public Nullable<int> INLI_THIC {get;set;}
		/// <summary>
		///仰拱厚度 
		///</summary>
		public Nullable<int> INLI_THIB {get;set;}
	}
}