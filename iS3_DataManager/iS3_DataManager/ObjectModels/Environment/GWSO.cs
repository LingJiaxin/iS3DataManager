using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///地下水质///</summary>
	[Table("Environment_GWSO")]
	public class GWSO:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///测量时间 
		///</summary>
		public string GWSO_METI {get;set;}
		/// <summary>
		///X坐标 
		///</summary>
		public Nullable<double> LOCA_NATE {get;set;}
		/// <summary>
		///Y坐标 
		///</summary>
		public Nullable<double> LOCA_NATN {get;set;}
		/// <summary>
		///Z坐标 
		///</summary>
		public Nullable<double> LOCA_Z {get;set;}
		/// <summary>
		///污染物名称 
		///</summary>
		public string GWSO_POLL {get;set;}
		/// <summary>
		///污染物含量 
		///</summary>
		public Nullable<double> GWSO_CONT {get;set;}
		/// <summary>
		///关联文件索引 
		///</summary>
		public string FILE_FSET {get;set;}
	}
}