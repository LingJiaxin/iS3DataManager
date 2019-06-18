using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///地表水源///</summary>
	[Table("Environment_SWSO")]
	public class SWSO:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///水源名称 
		///</summary>
		public string SWSO_NAME {get;set;}
		/// <summary>
		///地理位置 
		///</summary>
		public string SWSO_LOCA {get;set;}
		/// <summary>
		///所属水系 
		///</summary>
		public string SWSO_SYS {get;set;}
		/// <summary>
		///水源长度 
		///</summary>
		public Nullable<int> SWSO_LENG {get;set;}
		/// <summary>
		///汇流面积 
		///</summary>
		public Nullable<int> SWSO_CFAR {get;set;}
		/// <summary>
		///关联文件索引 
		///</summary>
		public string FILE_FSET {get;set;}
	}
}