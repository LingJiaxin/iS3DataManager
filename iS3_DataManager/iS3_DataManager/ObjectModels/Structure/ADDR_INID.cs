using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///超前钻孔排水_初设///</summary>
	[Table("Structure_ADDR_INID")]
	public class ADDR_INID:DGObject
 	{ 
		/// <summary>
		///超前钻孔排水ID 
		///</summary>
		public string ADDR_ID {get;set;}
		/// <summary>
		///钻孔外径 
		///</summary>
		public Nullable<int> ADDR_DIAM {get;set;}
		/// <summary>
		///超前掌子面距离 
		///</summary>
		public Nullable<int> ADDR_LENG {get;set;}
	}
}