using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///监测数据///</summary>
	[Table("Environment_MOND")]
	public class MOND:DGObject
 	{ 
		/// <summary>
		///监测数据ID 
		///</summary>
		public string MOND_ID {get;set;}
		/// <summary>
		///监测点ID 
		///</summary>
		public string MONP_ID {get;set;}
		/// <summary>
		///数据单位 
		///</summary>
		public string MOND_UNIT {get;set;}
		/// <summary>
		///监测读数 
		///</summary>
		public string MOND_READ {get;set;}
		/// <summary>
		///监测数值 
		///</summary>
		public string MOND_VALU {get;set;}
		/// <summary>
		///监测时间 
		///</summary>
		public string MOND_TIME {get;set;}
		/// <summary>
		///系统时间 
		///</summary>
		public string MOND_SYST {get;set;}
		/// <summary>
		///引用文件 
		///</summary>
		public string FILE_FSET {get;set;}
	}
}