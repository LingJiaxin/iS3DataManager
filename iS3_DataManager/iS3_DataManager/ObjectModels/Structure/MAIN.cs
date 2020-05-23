using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///检修道///</summary>
	[Table("Structure_MAIN")]
	public class MAIN:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///检修道材料 
		///</summary>
		public string MAIN_MATE {get;set;}
		/// <summary>
		///检修道壁厚 
		///</summary>
		public Nullable<int> MAIN_THIC {get;set;}
		/// <summary>
		///检修道内净宽 
		///</summary>
		public Nullable<int> MAIN_WIDH {get;set;}
	}
}