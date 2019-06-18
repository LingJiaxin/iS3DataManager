using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///重要建筑物///</summary>
	[Table("Environment_IMAR")]
	public class IMAR:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///建筑物名称 
		///</summary>
		public string IMAR_NAME {get;set;}
		/// <summary>
		///建筑物用途 
		///</summary>
		public string IMAR_USE {get;set;}
		/// <summary>
		///距离最近的河流 
		///</summary>
		public string IMAR_NRRV {get;set;}
		/// <summary>
		///X坐标 
		///</summary>
		public Nullable<double> LOCA_NATE {get;set;}
		/// <summary>
		///Y坐标 
		///</summary>
		public Nullable<double> LOCA_NATN {get;set;}
		/// <summary>
		///地下水位 
		///</summary>
		public Nullable<double> LOCA_WATA {get;set;}
		/// <summary>
		///地下水埋深 
		///</summary>
		public Nullable<double> LOCA_DEOG {get;set;}
		/// <summary>
		///备注 
		///</summary>
		public string IMAR_REM {get;set;}
		/// <summary>
		///关联文件索引 
		///</summary>
		public string FILE_FSET {get;set;}
	}
}