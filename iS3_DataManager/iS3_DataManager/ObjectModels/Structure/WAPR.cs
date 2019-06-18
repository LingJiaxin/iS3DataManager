using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///防水板///</summary>
	[Table("Structure_WAPR")]
	public class WAPR:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINI_TYPE {get;set;}
		/// <summary>
		///防水板规格 
		///</summary>
		public string WAPR_STAN {get;set;}
		/// <summary>
		///防水板厚度 
		///</summary>
		public Nullable<double> WAPR_THIC {get;set;}
		/// <summary>
		///防水板设置方式 
		///</summary>
		public string WAPR_METH {get;set;}
	}
}