using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///衬砌钢筋笼///</summary>
	[Table("Structure_STCA")]
	public class STCA:DGObject
 	{ 
		/// <summary>
		///衬砌型号 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///保护层厚度 
		///</summary>
		public Nullable<int> COCV_THIC {get;set;}
		/// <summary>
		///环向钢筋型号 
		///</summary>
		public string HOST_TYPE {get;set;}
		/// <summary>
		///环向钢筋直径 
		///</summary>
		public Nullable<int> HOST_DIAM {get;set;}
		/// <summary>
		///环向钢筋间距 
		///</summary>
		public Nullable<int> HOST_DIST {get;set;}
		/// <summary>
		///环向内侧钢筋拱圈圆心角 
		///</summary>
		public Nullable<double> ITHS_ANGL {get;set;}
		/// <summary>
		///环向外侧钢筋拱圈圆心角 
		///</summary>
		public Nullable<double> OTHS_ANGL {get;set;}
		/// <summary>
		///环向内侧钢筋仰拱圆心角 
		///</summary>
		public Nullable<double> IIHS_ANGL {get;set;}
		/// <summary>
		///环向外侧钢筋仰拱圆心角 
		///</summary>
		public Nullable<double> OIHS_ANGL {get;set;}
		/// <summary>
		///环向外侧钢筋拱墙处长度 
		///</summary>
		public Nullable<int> OSHS_LENG {get;set;}
		/// <summary>
		///环向钢筋拱脚处长度 
		///</summary>
		public Nullable<int> SPHS_LENG {get;set;}
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
	}
}