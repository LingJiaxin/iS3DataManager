using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///地理位置///</summary>
	[Table("Structure_GELO")]
	public class GELO:DGObject
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
		///起点城市 
		///</summary>
		public string GELO_STAR {get;set;}
		/// <summary>
		///终点城市 
		///</summary>
		public string GELO_END {get;set;}
	}
}