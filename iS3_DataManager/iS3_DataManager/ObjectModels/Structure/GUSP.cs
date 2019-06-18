using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///导向钢管///</summary>
	[Table("Structure_GUSP")]
	public class GUSP:DGObject
 	{ 
		/// <summary>
		///衬砌型号 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///导向钢管中心距套拱内轮廓距离 
		///</summary>
		public Nullable<int> GUSP_SPAC {get;set;}
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
		/// <summary>
		///导向钢管单节长 
		///</summary>
		public Nullable<int> GUSP_LENG {get;set;}
	}
}