using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///纵面线型///</summary>
	[Table("Structure_VERL")]
	public class VERL:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///起始里程桩号 
		///</summary>
		public string VERL_STAR {get;set;}
		/// <summary>
		///终止里程桩号 
		///</summary>
		public string VERL_END {get;set;}
		/// <summary>
		///纵曲线类型 
		///</summary>
		public string VERL_TYPE {get;set;}
		/// <summary>
		///纵坡 
		///</summary>
		public Nullable<double> VERL_RATE {get;set;}
		/// <summary>
		///竖曲线半径 
		///</summary>
		public Nullable<int> VERL_RADI {get;set;}
		/// <summary>
		///隧道海拔 
		///</summary>
		public Nullable<int> VERL_HIGH {get;set;}
	}
}