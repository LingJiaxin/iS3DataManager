using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///明洞衬砌///</summary>
	[Table("Structure_POLI")]
	public class POLI:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///是否存在仰拱 
		///</summary>
		public Nullable<bool> POLI_YN {get;set;}
		/// <summary>
		///衬砌型号 
		///</summary>
		public string POLI_TYPE {get;set;}
		/// <summary>
		///混凝土型号 
		///</summary>
		public string POLI_TYPC {get;set;}
		/// <summary>
		///拱顶衬砌内半径 
		///</summary>
		public Nullable<double> POLI_RADT {get;set;}
		/// <summary>
		///拱顶衬砌圆心角 
		///</summary>
		public Nullable<double> POLI_ANGT {get;set;}
		/// <summary>
		///拱脚衬砌内半径 
		///</summary>
		public Nullable<int> POLI_RADB {get;set;}
		/// <summary>
		///拱脚衬砌圆心角 
		///</summary>
		public Nullable<double> POLI_ANGB {get;set;}
		/// <summary>
		///仰拱衬砌内半径 
		///</summary>
		public Nullable<int> POLI_RADC {get;set;}
		/// <summary>
		///仰拱衬砌圆心角 
		///</summary>
		public Nullable<double> POLI_ANGC {get;set;}
		/// <summary>
		///拱顶衬砌厚度 
		///</summary>
		public Nullable<int> POLI_THIT {get;set;}
		/// <summary>
		///拱脚宽度 
		///</summary>
		public Nullable<int> POLI_WIDB {get;set;}
		/// <summary>
		///侧墙高度 
		///</summary>
		public Nullable<int> POLI_HEIG {get;set;}
		/// <summary>
		///仰拱厚度 
		///</summary>
		public Nullable<int> POLI_THIC {get;set;}
	}
}