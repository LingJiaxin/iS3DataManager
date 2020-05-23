using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///消防洞室///</summary>
	[Table("Structure_FICH")]
	public class FICH:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///消防洞室桩号 
		///</summary>
		public string FICH_MILE {get;set;}
		/// <summary>
		///消防洞室类型 
		///</summary>
		public string FICH_TYPE {get;set;}
		/// <summary>
		///消防洞内净宽 
		///</summary>
		public Nullable<int> FICH_WIDH {get;set;}
	}
}