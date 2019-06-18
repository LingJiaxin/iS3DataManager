using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///钢筋网///</summary>
	[Table("Structure_STEE")]
	public class STEE:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///是否设置钢筋网 
		///</summary>
		public string STEE_YN {get;set;}
		/// <summary>
		///钢筋网布置位置 
		///</summary>
		public string STEE_SITU {get;set;}
		/// <summary>
		///环向钢筋型号 
		///</summary>
		public Nullable<int> HOOP_TYPE {get;set;}
		/// <summary>
		///环向钢筋布置间距 
		///</summary>
		public Nullable<int> HOOP_DIST {get;set;}
		/// <summary>
		///纵向钢筋型号 
		///</summary>
		public Nullable<int> LENG_TYPE {get;set;}
	}
}