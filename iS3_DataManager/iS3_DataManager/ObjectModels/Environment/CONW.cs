using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///承压水///</summary>
	[Table("Environment_CONW")]
	public class CONW:DGObject
 	{ 
		/// <summary>
		///承压水ID 
		///</summary>
		public string CONW_TOP {get;set;}
		/// <summary>
		///钻孔ID 
		///</summary>
		public string HDPH_ID {get;set;}
		/// <summary>
		///位置ID 
		///</summary>
		public string LOCA_ID {get;set;}
		/// <summary>
		///地层ID 
		///</summary>
		public string STRA_ID {get;set;}
		/// <summary>
		///承压水位 
		///</summary>
		public string CONW_TOPD {get;set;}
		/// <summary>
		///观察点深度 
		///</summary>
		public string CONW_STAN {get;set;}
		/// <summary>
		///含水层名 
		///</summary>
		public string CONW_WATT {get;set;}
		/// <summary>
		///水量数据表 
		///</summary>
		public string CONW_LAYE {get;set;}
		/// <summary>
		///观察时间‘ 
		///</summary>
		public string CONW_OBST {get;set;}
	}
}