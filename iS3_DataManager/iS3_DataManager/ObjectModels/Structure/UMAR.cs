using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///套拱///</summary>
	[Table("Structure_UMAR")]
	public class UMAR:DGObject
 	{ 
		/// <summary>
		///是否采用套拱 
		///</summary>
		public bool  UMAR_YN {get;set;}
		/// <summary>
		///套拱混凝土型号 
		///</summary>
		public string UMAR_CON {get;set;}
		/// <summary>
		///套拱拱顶内半径 
		///</summary>
		public Nullable<int> UMAR_RADI {get;set;}
		/// <summary>
		///套拱拱顶圆心角 
		///</summary>
		public Nullable<int> UMAR_ANGL {get;set;}
		/// <summary>
		///套拱侧墙高度 
		///</summary>
		public Nullable<int> UMAR_HEIT {get;set;}
		/// <summary>
		///套拱厚度 
		///</summary>
		public Nullable<int> UMAR_THIC {get;set;}
		/// <summary>
		///套拱纵长 
		///</summary>
		public Nullable<int> UMAR_LENG {get;set;}
		/// <summary>
		///导向钢管中心距套拱内轮廓距离 
		///</summary>
		public Nullable<int> UMAR_SPAC {get;set;}
		/// <summary>
		///断面内导向钢管数量 
		///</summary>
		public Nullable<int> GUSP_NUM {get;set;}
		/// <summary>
		///导向钢管间距 
		///</summary>
		public Nullable<int> GUSP_DIST {get;set;}
		/// <summary>
		///导向钢管外径 
		///</summary>
		public Nullable<int> GUSP_DIAM {get;set;}
		/// <summary>
		///导向钢管壁厚 
		///</summary>
		public Nullable<int> GUSP_THIC {get;set;}
	}
}