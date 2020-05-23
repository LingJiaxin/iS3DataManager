using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///深井降水_初设///</summary>
	[Table("Structure_DEWD_INID")]
	public class DEWD_INID:DGObject
 	{ 
		/// <summary>
		///深井降水ID 
		///</summary>
		public string DEWD_ID {get;set;}
		/// <summary>
		///降水深度 
		///</summary>
		public Nullable<int> DEWD_DEEP {get;set;}
		/// <summary>
		///井底深度 
		///</summary>
		public Nullable<int> DEWD_BOTL {get;set;}
	}
}