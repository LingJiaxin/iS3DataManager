using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///路基///</summary>
	[Table("Structure_PABA")]
	public class PABA:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINI_TYPE {get;set;}
		/// <summary>
		///基层类型 
		///</summary>
		public string PABA_MATI {get;set;}
		/// <summary>
		///基层厚度 
		///</summary>
		public Nullable<int> PABA_THIC {get;set;}
	}
}