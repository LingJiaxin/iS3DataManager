using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///土工布///</summary>
	[Table("Structure_GEOT")]
	public class GEOT:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINI_TYPE {get;set;}
		/// <summary>
		///土工布规格 
		///</summary>
		public string GEOT_STAN {get;set;}
		/// <summary>
		///土工布布设方式 
		///</summary>
		public string GEOT_METH {get;set;}
	}
}