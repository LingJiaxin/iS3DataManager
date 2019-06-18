using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///平面线型///</summary>
	[Table("Structure_PLAL")]
	public class PLAL:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///起始里程桩号 
		///</summary>
		public string PLAL_STAR {get;set;}
		/// <summary>
		///终止里程桩号 
		///</summary>
		public string PLAL_END {get;set;}
		/// <summary>
		///平曲线类型 
		///</summary>
		public string PLAL_TYPE {get;set;}
		/// <summary>
		///圆曲线半径 
		///</summary>
		public Nullable<int> PLAL_RADI {get;set;}
		/// <summary>
		///缓和曲线变化率 
		///</summary>
		public Nullable<double> PLAL_RATE {get;set;}
		/// <summary>
		///路线布置类型 
		///</summary>
		public string PLAL_LTYP {get;set;}
	}
}