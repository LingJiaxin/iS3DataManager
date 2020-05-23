using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///弃渣场地///</summary>
	[Table("Environment_WASS")]
	public class WASS:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///弃渣场地位置 
		///</summary>
		public string WASS_LOCA {get;set;}
		/// <summary>
		///弃渣场管辖桩号范围 
		///</summary>
		public string WASS_MILG {get;set;}
		/// <summary>
		///备注 
		///</summary>
		public string PLRO_REM {get;set;}
		/// <summary>
		///关联文件索引 
		///</summary>
		public string FILE_FSET {get;set;}
	}
}