using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///潜水埋深///</summary>
	[Table("Environment_DOUG")]
	public class DOUG:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///X坐标 
		///</summary>
		public Nullable<double> LOCA_NATE {get;set;}
		/// <summary>
		///Y坐标 
		///</summary>
		public Nullable<double> LOCA_NATN {get;set;}
		/// <summary>
		///埋深 
		///</summary>
		public Nullable<double> DOUG_DEPT {get;set;}
		/// <summary>
		///备注 
		///</summary>
		public string DOUG_MEMO {get;set;}
		/// <summary>
		///关联文件索引 
		///</summary>
		public string FILE_FSET {get;set;}
	}
}