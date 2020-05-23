using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	///<summary>///水文地质单元///</summary>
	[Table("Geology_HYUN")]
	public class HYUN:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///水文地质单元ID 
		///</summary>
		public string HYUN_ID {get;set;}
		/// <summary>
		///地层代号 
		///</summary>
		public string HYUN_STCO {get;set;}
		/// <summary>
		///地层厚度 
		///</summary>
		public string HYUN_STDE {get;set;}
		/// <summary>
		///地层岩性 
		///</summary>
		public string HYUN_STLI {get;set;}
		/// <summary>
		///地下水类型 
		///</summary>
		public string HYUN_GRTY {get;set;}
		/// <summary>
		///泉暗河流量 
		///</summary>
		public string HYUN_FLOW {get;set;}
		/// <summary>
		///地下径流模数 
		///</summary>
		public string HYUN_UNRM {get;set;}
		/// <summary>
		///富水性 
		///</summary>
		public string HYUN_WAAB {get;set;}
		/// <summary>
		///关联文件 
		///</summary>
		public string FILE_FSET {get;set;}
	}
}