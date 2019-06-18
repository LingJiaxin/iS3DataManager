using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///竖井接头///</summary>
	[Table("Structure_SICO")]
	public class SICO:DGObject
 	{ 
		/// <summary>
		///竖井ID 
		///</summary>
		public string SILO_ID {get;set;}
		/// <summary>
		///接头隧道中心桩号 
		///</summary>
		public string SHCO_MILG {get;set;}
		/// <summary>
		///接头与衬砌空间夹角 
		///</summary>
		public Nullable<int> SHCO_DEG {get;set;}
	}
}