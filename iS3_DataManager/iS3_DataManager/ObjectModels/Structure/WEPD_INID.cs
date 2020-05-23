using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///井点降水_初设///</summary>
	[Table("Structure_WEPD_INID")]
	public class WEPD_INID:DGObject
 	{ 
		/// <summary>
		///井点降水ID 
		///</summary>
		public string WEPD_ID {get;set;}
		/// <summary>
		///降水深度 
		///</summary>
		public Nullable<int> WEPD_DEEP {get;set;}
	}
}