using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///公路等级///</summary>
	[Table("Structure_HIGR")]
	public class HIGR:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///工程名称 
		///</summary>
		public string PROJ_NAME {get;set;}
		/// <summary>
		///公路等级 
		///</summary>
		public string HIGR_HIGR {get;set;}
		/// <summary>
		///车道 
		///</summary>
		public Nullable<int> HIGR_CHAN {get;set;}
		/// <summary>
		///设计时速 
		///</summary>
		public Nullable<int> HIGR_DESP {get;set;}
	}
}