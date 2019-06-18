using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///封堵墙_施工图///</summary>
	[Table("Structure_EMWA_COND")]
	public class EMWA_COND:DGObject
 	{ 
		/// <summary>
		///紧急停车带ID 
		///</summary>
		public string EMTU_ID {get;set;}
		/// <summary>
		///封堵墙宽度 
		///</summary>
		public Nullable<double> EMWA_WIDH {get;set;}
		/// <summary>
		///初衬厚度 
		///</summary>
		public Nullable<double> EMWA_THIF {get;set;}
		/// <summary>
		///二衬厚度 
		///</summary>
		public Nullable<double> EMWA_THIS {get;set;}
	}
}