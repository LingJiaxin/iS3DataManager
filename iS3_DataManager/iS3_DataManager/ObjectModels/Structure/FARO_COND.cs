using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///风机房_施工图///</summary>
	[Table("Structure_FARO_COND")]
	public class FARO_COND:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string FARO_TYPE {get;set;}
		/// <summary>
		///风机房桩号 
		///</summary>
		public string FARO_STAN {get;set;}
		/// <summary>
		///风机房内净长 
		///</summary>
		public Nullable<int> FARO_LENG {get;set;}
		/// <summary>
		///风机房内净宽 
		///</summary>
		public Nullable<int> FARO_WIDH {get;set;}
	}
}