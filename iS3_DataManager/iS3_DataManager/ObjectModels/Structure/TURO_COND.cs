using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///路面层_施工图///</summary>
	[Table("Structure_TURO_COND")]
	public class TURO_COND:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///路面层ID 
		///</summary>
		public string TURO_ID {get;set;}
		/// <summary>
		///路面层材料 
		///</summary>
		public string TURO_MATI {get;set;}
		/// <summary>
		///路面层宽度 
		///</summary>
		public Nullable<int> ROLA_WIDE {get;set;}
		/// <summary>
		///路面层厚度 
		///</summary>
		public Nullable<int> ROLA_THIC {get;set;}
		/// <summary>
		///路面层坡度 
		///</summary>
		public Nullable<double> ROLA_GRAD {get;set;}
	}
}