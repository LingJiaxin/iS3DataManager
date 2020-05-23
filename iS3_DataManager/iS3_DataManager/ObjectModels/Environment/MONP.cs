using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///监测点///</summary>
	[Table("Environment_MONP")]
	public class MONP:DGObject
 	{ 
		/// <summary>
		///监测点ID 
		///</summary>
		public string MONP_ID {get;set;}
		/// <summary>
		///监测组ID 
		///</summary>
		public string MONG_ID {get;set;}
		/// <summary>
		///监测点类型 
		///</summary>
		public string MONP_TYPE {get;set;}
		/// <summary>
		///X坐标（东） 
		///</summary>
		public string LOCA_NATE {get;set;}
		/// <summary>
		///Y坐标（北） 
		///</summary>
		public string LOCA_NATN {get;set;}
		/// <summary>
		///Z坐标 
		///</summary>
		public string LOCA_Z {get;set;}
		/// <summary>
		///传感器名称 
		///</summary>
		public string MONP_SENN {get;set;}
		/// <summary>
		///监测起始时间 
		///</summary>
		public string MONP_INTT {get;set;}
		/// <summary>
		///备注信息 
		///</summary>
		public string MONP_MARK {get;set;}
		/// <summary>
		///IniValue 
		///</summary>
		public string IniValue {get;set;}
		/// <summary>
		///PerInfoID 
		///</summary>
		public string PerInfoID {get;set;}
	}
}