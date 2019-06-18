using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///植被根系///</summary>
	[Table("Environment_PLRO")]
	public class PLRO:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///植被名称 
		///</summary>
		public string PLRO_NAME {get;set;}
		/// <summary>
		///根长 
		///</summary>
		public Nullable<double> PLRO_LEOR {get;set;}
		/// <summary>
		///根系类型 
		///</summary>
		public string PLRO_TYPE {get;set;}
		/// <summary>
		///根系作用 
		///</summary>
		public string PLRO_USE {get;set;}
		/// <summary>
		///X坐标 
		///</summary>
		public Nullable<double> LOCA_NATE {get;set;}
		/// <summary>
		///Y坐标 
		///</summary>
		public Nullable<double> LOCA_NATN {get;set;}
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