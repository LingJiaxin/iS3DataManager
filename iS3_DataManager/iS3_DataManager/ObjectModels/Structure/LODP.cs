using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///纵向排水管///</summary>
	[Table("Structure_LODP")]
	public class LODP:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINI_TYPE {get;set;}
		/// <summary>
		///纵向排水管规格 
		///</summary>
		public string LODP_TYPE {get;set;}
		/// <summary>
		///纵向排水管坡度 
		///</summary>
		public string LODP_SLOP {get;set;}
	}
}