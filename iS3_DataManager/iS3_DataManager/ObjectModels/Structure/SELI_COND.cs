using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///二次衬砌_施工图///</summary>
	[Table("Structure_SELI_COND")]
	public class SELI_COND:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///是否存在二衬 
		///</summary>
		public bool  SELI_YN {get;set;}
		/// <summary>
		///二次衬砌ID 
		///</summary>
		public string SELI_ID {get;set;}
		/// <summary>
		///是否存在仰拱 
		///</summary>
		public Nullable<bool> INVE_YN {get;set;}
		/// <summary>
		///二衬混凝土型号 
		///</summary>
		public string SELI_TYPE {get;set;}
		/// <summary>
		///拱顶二衬内半径 
		///</summary>
		public Nullable<int> TOP_RADI {get;set;}
		/// <summary>
		///拱顶二衬圆心角 
		///</summary>
		public Nullable<double> TOP_ANGL {get;set;}
		/// <summary>
		///拱侧二衬内半径 
		///</summary>
		public Nullable<int> SIDE_RADI {get;set;}
		/// <summary>
		///拱侧二衬圆心角 
		///</summary>
		public Nullable<double> SIDE_ANGL {get;set;}
		/// <summary>
		///拱脚二衬内半径 
		///</summary>
		public Nullable<int> ARSP_RADI {get;set;}
		/// <summary>
		///拱脚二衬圆心角 
		///</summary>
		public Nullable<double> ARSP_ANGL {get;set;}
		/// <summary>
		///仰拱二衬内半径 
		///</summary>
		public Nullable<int> INVE_RADI {get;set;}
		/// <summary>
		///仰拱二衬圆心角 
		///</summary>
		public Nullable<double> INVE_ANGL {get;set;}
		/// <summary>
		///拱顶二衬厚度 
		///</summary>
		public Nullable<int> TOP_THIC {get;set;}
		/// <summary>
		///侧墙二衬厚度 
		///</summary>
		public Nullable<int> SIDE_THIC {get;set;}
		/// <summary>
		///仰拱厚度 
		///</summary>
		public Nullable<int> INVE_THIC {get;set;}
		/// <summary>
		///拱脚宽度 
		///</summary>
		public Nullable<int> ARCF_WIDE {get;set;}
	}
}