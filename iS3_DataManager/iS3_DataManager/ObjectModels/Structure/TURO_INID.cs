using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///路面层_初设///</summary>
	[Table("Structure_TURO_INID")]
	public class TURO_INID:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///主要面层材料 
		///</summary>
		public string TURO_MATE {get;set;}
		/// <summary>
		///面层厚度 
		///</summary>
		public Nullable<double> TURO_THIC {get;set;}
		/// <summary>
		///路面结构形式 
		///</summary>
		public string TURO_TYPE {get;set;}
	}
}