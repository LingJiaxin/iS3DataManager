using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///导洞///</summary>
	[Table("Structure_PAPI")]
	public class PAPI:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string PAPI_TYPE {get;set;}
		/// <summary>
		///平行导洞桩号 
		///</summary>
		public string PAPI_STAN {get;set;}
		/// <summary>
		///衬砌厚度 
		///</summary>
		public Nullable<int> PAPI_THIC {get;set;}
	}
}