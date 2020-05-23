using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///图片资料///</summary>
	[Table("Structure_TPZL")]
	public class TPZL:DGObject
 	{ 
		/// <summary>
		///标段号 
		///</summary>
		public string TPZL_SECTION {get;set;}
		/// <summary>
		///上传者 
		///</summary>
		public string TPZL_UPLOADER {get;set;}
		/// <summary>
		///图片时间 
		///</summary>
		public string TPZL_DATE {get;set;}
		/// <summary>
		///桩号区间 
		///</summary>
		public string TPZL_ZHQJ {get;set;}
		/// <summary>
		///图片名称 
		///</summary>
		public string TPZL_SPMC {get;set;}
		/// <summary>
		///图片描述 
		///</summary>
		public string TPZL_DISC {get;set;}
		/// <summary>
		///关联文件（现场日志表） 
		///</summary>
		public string FILE_FSET {get;set;}
	}
}