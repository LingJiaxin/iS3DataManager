using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///二次衬砌_初设///</summary>
	[Table("Structure_SELI_INID")]
	public class SELI_INID:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///是否设置仰拱 
		///</summary>
		public Nullable<bool> INVE_YN {get;set;}
		/// <summary>
		///二衬混凝土型号 
		///</summary>
		public string SELI_TYPE {get;set;}
		/// <summary>
		///拱顶二衬内半径 
		///</summary>
		public Nullable<double> SELI_RADT {get;set;}
		/// <summary>
		///拱顶二衬圆心角 
		///</summary>
		public Nullable<double> SELI_ANGT {get;set;}
		/// <summary>
		///拱脚二衬内半径 
		///</summary>
		public Nullable<double> SELI_RADB {get;set;}
		/// <summary>
		///拱脚二衬圆心角 
		///</summary>
		public Nullable<double> SELI_ANGB {get;set;}
		/// <summary>
		///仰拱二衬内半径 
		///</summary>
		public Nullable<int> SELI_RADI {get;set;}
		/// <summary>
		///仰拱二衬圆心角 
		///</summary>
		public Nullable<double> SELI_ANGI {get;set;}
		/// <summary>
		///拱顶二衬厚度 
		///</summary>
		public Nullable<double> SELI_THIT {get;set;}
		/// <summary>
		///侧墙二衬厚度 
		///</summary>
		public Nullable<double> SELI_THIC {get;set;}
		/// <summary>
		///仰拱厚度 
		///</summary>
		public Nullable<double> SELI_THIB {get;set;}
	}
}