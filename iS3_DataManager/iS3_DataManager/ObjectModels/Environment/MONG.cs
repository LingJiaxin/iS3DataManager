using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///监测组///</summary>
	[Table("Environment_MONG")]
	public class MONG:DGObject
 	{ 
		/// <summary>
		/// 
		///</summary>
		public string MONG_ID {get;set;}
		/// <summary>
		///监测组ID 
		///</summary>
		public string Name {get;set;}
		/// <summary>
		///监测组名 
		///</summary>
		public string Description {get;set;}
		/// <summary>
		///监测组类型 
		///</summary>
		public string MonGroupType {get;set;}
		/// <summary>
		///检测项目ID 
		///</summary>
		public string MonPointIDs {get;set;}
		/// <summary>
		/// 
		///</summary>
		public string MonProjectID {get;set;}
		/// <summary>
		///参考规格 
		///</summary>
		public string RefSpecifications {get;set;}
		/// <summary>
		/// 
		///</summary>
		public string PerInfoIDs {get;set;}
		/// <summary>
		/// 
		///</summary>
		public string Remark {get;set;}
		/// <summary>
		///备注 
		///</summary>
		public string MONG_MARK {get;set;}
	}
}