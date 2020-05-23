using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///格栅钢架///</summary>
	[Table("Structure_GRSF")]
	public class GRSF:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///是否存在格栅钢架 
		///</summary>
		public Nullable<bool> GRSF_YN {get;set;}
		/// <summary>
		///格栅钢架类型 
		///</summary>
		public string GRSF_TYPE {get;set;}
		/// <summary>
		///格栅钢架间距 
		///</summary>
		public Nullable<int> GRSF_DIST {get;set;}
		/// <summary>
		///主筋规格 
		///</summary>
		public string MIRE_TYPE {get;set;}
		/// <summary>
		///加强筋规格 
		///</summary>
		public Nullable<int> STRI_TYPE {get;set;}
		/// <summary>
		///格栅钢架单元数量 
		///</summary>
		public Nullable<int> GRSF_ELEM {get;set;}
		/// <summary>
		///格栅钢架拱部单元半径 
		///</summary>
		public Nullable<int> TOP_RADI {get;set;}
		/// <summary>
		///格栅钢架拱部单元圆心角 
		///</summary>
		public Nullable<double> TOP_ANGL {get;set;}
		/// <summary>
		///格栅钢架边墙单元半径 
		///</summary>
		public Nullable<int> WALL_RADI {get;set;}
		/// <summary>
		///格栅钢架边墙单元圆心角 
		///</summary>
		public Nullable<double> WALL_ANGL {get;set;}
		/// <summary>
		///仰拱处是否存在格栅钢架单元 
		///</summary>
		public Nullable<bool> INAR_YN {get;set;}
		/// <summary>
		///定位筋位置 
		///</summary>
		public string PLST_SITU {get;set;}
		/// <summary>
		///定位筋规格 
		///</summary>
		public string PLST_TYPE {get;set;}
		/// <summary>
		///连接套管规格 
		///</summary>
		public string STPI_TYPE {get;set;}
		/// <summary>
		///连接套管环向间距 
		///</summary>
		public Nullable<int> STPI_HODI {get;set;}
		/// <summary>
		///纵向连接筋规格 
		///</summary>
		public string CONE_TYPE {get;set;}
		/// <summary>
		///纵向连接筋环向间距 
		///</summary>
		public Nullable<int> CONE_HODI {get;set;}
		/// <summary>
		///垫块混凝土型号 
		///</summary>
		public string BECO_TYPE {get;set;}
	}
}