using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///仰拱回填///</summary>
	[Table("Structure_INBA")]
	public class INBA:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINI_TYPE {get;set;}
		/// <summary>
		///回填材料 
		///</summary>
		public string INBA_MATI {get;set;}
		/// <summary>
		///回填最大厚度 
		///</summary>
		public Nullable<int> INBA_THIC {get;set;}
	}
}