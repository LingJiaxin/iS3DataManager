using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///竖井///</summary>
	[Table("Structure_SHLI")]
	public class SHLI:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string SHLI_TYPE {get;set;}
		/// <summary>
		///混凝土型号 
		///</summary>
		public string SHCO_TYPE {get;set;}
		/// <summary>
		///竖井布设位置 
		///</summary>
		public string SHLI_LOCA {get;set;}
		/// <summary>
		///衬砌厚度 
		///</summary>
		public Nullable<int> SHLI_THIC {get;set;}
	}
}