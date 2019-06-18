using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///清水沟///</summary>
	[Table("Structure_WADI")]
	public class WADI:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///清水沟材料 
		///</summary>
		public string WADI_MATE {get;set;}
		/// <summary>
		///清水沟壁厚 
		///</summary>
		public Nullable<int> WADI_THIC {get;set;}
		/// <summary>
		///清水沟内净宽 
		///</summary>
		public Nullable<int> WADI_WIDH {get;set;}
		/// <summary>
		///清水沟盖板长度 
		///</summary>
		public Nullable<int> WADI_LENG {get;set;}
	}
}