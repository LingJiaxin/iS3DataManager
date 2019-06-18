using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///电缆沟_施工图///</summary>
	[Table("Structure_CATR_COND")]
	public class CATR_COND:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///电缆沟材料 
		///</summary>
		public string CATR_MATE {get;set;}
		/// <summary>
		///电缆沟壁厚 
		///</summary>
		public Nullable<int> CATR_THIC {get;set;}
		/// <summary>
		///电缆沟内净宽 
		///</summary>
		public Nullable<int> CATR_WIDH {get;set;}
		/// <summary>
		///电缆沟盖板长度 
		///</summary>
		public Nullable<int> CATR_LENG {get;set;}
	}
}