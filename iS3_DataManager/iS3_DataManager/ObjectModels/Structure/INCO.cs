using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///斜井接头///</summary>
	[Table("Structure_INCO")]
	public class INCO:DGObject
 	{ 
		/// <summary>
		///斜井ID 
		///</summary>
		public string INLI__ID {get;set;}
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINI_TYPE {get;set;}
		/// <summary>
		///接头隧道中心桩号 
		///</summary>
		public string LINI_MILG {get;set;}
		/// <summary>
		///接头与衬砌空间夹角 
		///</summary>
		public double  LINI_DEG {get;set;}
	}
}