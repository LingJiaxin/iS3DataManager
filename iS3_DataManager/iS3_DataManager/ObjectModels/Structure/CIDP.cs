using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///环向排水管///</summary>
	[Table("Structure_CIDP")]
	public class CIDP:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINI_TYPE {get;set;}
		/// <summary>
		///环向排水管规格 
		///</summary>
		public string CIDP_TYPE {get;set;}
		/// <summary>
		///环向排水管间距 
		///</summary>
		public Nullable<int> CIDP_DIST {get;set;}
	}
}