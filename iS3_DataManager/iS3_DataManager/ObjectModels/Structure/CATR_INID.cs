using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///电缆沟_初设///</summary>
	[Table("Structure_CATR_INID")]
	public class CATR_INID:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///电缆沟类型 
		///</summary>
		public string CATR_MATE {get;set;}
		/// <summary>
		///台阶节数 
		///</summary>
		public Nullable<int> CATR_STEP {get;set;}
		/// <summary>
		///台阶高度 
		///</summary>
		public Nullable<int> CATR_SHIG {get;set;}
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