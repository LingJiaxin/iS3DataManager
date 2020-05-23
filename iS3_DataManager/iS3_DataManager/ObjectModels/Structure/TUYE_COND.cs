using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///风塔_施工图///</summary>
	[Table("Structure_TUYE_COND")]
	public class TUYE_COND:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///联络风道编号 
		///</summary>
		public string COAI_NUMB {get;set;}
		/// <summary>
		///风塔截面类型 
		///</summary>
		public string TUYE_TYPE {get;set;}
	}
}