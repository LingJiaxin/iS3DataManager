using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///钢筋笼///</summary>
	[Table("Structure_SECA")]
	public class SECA:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINI_TYPE {get;set;}
		/// <summary>
		///钢筋笼ID 
		///</summary>
		public string SECA_ID {get;set;}
		/// <summary>
		///是否存在二衬 
		///</summary>
		public bool  SECA_YN {get;set;}
		/// <summary>
		///保护层厚度 
		///</summary>
		public Nullable<int> COCV_THIC {get;set;}
		/// <summary>
		///内侧环向钢筋型号 
		///</summary>
		public string IHST_TYPE {get;set;}
		/// <summary>
		///外侧环向钢筋型号 
		///</summary>
		public string OHST_TYPE {get;set;}
		/// <summary>
		///内侧环向钢筋直径 
		///</summary>
		public Nullable<int> IHST_DIAM {get;set;}
		/// <summary>
		///外侧环向钢筋直径 
		///</summary>
		public Nullable<int> OHST_DIAM {get;set;}
		/// <summary>
		///环向钢筋间距 
		///</summary>
		public Nullable<int> HOST_DIST {get;set;}
		/// <summary>
		///环向钢筋拱顶圆心角 
		///</summary>
		public Nullable<double> TPHS_ANGL {get;set;}
		/// <summary>
		///环向钢筋拱侧圆心角 
		///</summary>
		public Nullable<double> SPHS_ANGL {get;set;}
		/// <summary>
		///环向钢筋拱脚圆心角 
		///</summary>
		public Nullable<double> FPHS_ANGL {get;set;}
		/// <summary>
		///环向钢筋仰拱圆心角 
		///</summary>
		public Nullable<double> IVHS_ANGL {get;set;}
		/// <summary>
		///纵向钢筋型号 
		///</summary>
		public string VEST_TYPE {get;set;}
		/// <summary>
		///纵向钢筋直径 
		///</summary>
		public Nullable<int> VEST_DIAM {get;set;}
		/// <summary>
		///纵向钢筋间距 
		///</summary>
		public Nullable<int> VEST_DIST {get;set;}
		/// <summary>
		///拉结筋型号 
		///</summary>
		public string SLIP_TYPE {get;set;}
		/// <summary>
		///拉结筋直径 
		///</summary>
		public Nullable<int> SLIP_DIAM {get;set;}
		/// <summary>
		///拉结筋间距 
		///</summary>
		public Nullable<int> SLIP_DIST {get;set;}
	}
}