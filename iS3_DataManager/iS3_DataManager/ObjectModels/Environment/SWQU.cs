using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///地表水质///</summary>
	[Table("Environment_SWQU")]
	public class SWQU:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///测量时间 
		///</summary>
		public string SWQU_METI {get;set;}
		/// <summary>
		///X坐标 
		///</summary>
		public string LOCA_NATE {get;set;}
		/// <summary>
		///Y坐标 
		///</summary>
		public string LOCA_NATN {get;set;}
		/// <summary>
		///污染物名称 
		///</summary>
		public string SWQU_POLL {get;set;}
		/// <summary>
		///污染物含量 
		///</summary>
		public string SWQU_CONT {get;set;}
		/// <summary>
		///关联文件索引 
		///</summary>
		public string FILE_FSET {get;set;}
	}
}