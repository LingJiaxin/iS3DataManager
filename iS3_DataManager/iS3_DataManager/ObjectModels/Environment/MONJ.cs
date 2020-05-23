using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///监测项目///</summary>
	[Table("Environment_MONJ")]
	public class MONJ:DGObject
 	{ 
		/// <summary>
		///监测项目ID 
		///</summary>
		public string MONJ_ID {get;set;}
		/// <summary>
		///项目名称 
		///</summary>
		public string MONJ_NAME {get;set;}
		/// <summary>
		///项目类型 
		///</summary>
		public string MONJ_TYPE {get;set;}
		/// <summary>
		///平面图 
		///</summary>
		public string MONJ_PLNF {get;set;}
		/// <summary>
		///备注 
		///</summary>
		public string MONJ_MARK {get;set;}
		/// <summary>
		///UnitID 
		///</summary>
		public string UnitID {get;set;}
		/// <summary>
		///PerInfoID 
		///</summary>
		public string PerInfoID {get;set;}
		/// <summary>
		///MonInstInfoIDs 
		///</summary>
		public string MonInstInfoIDs {get;set;}
		/// <summary>
		///PlanFile 
		///</summary>
		public string PlanFile {get;set;}
	}
}