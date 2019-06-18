using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///洞门挡墙///</summary>
	[Table("Structure_PORW")]
	public class PORW:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///洞口位置 
		///</summary>
		public string PORW_LOCA {get;set;}
		/// <summary>
		///洞口形式 
		///</summary>
		public string PORW_TYPE {get;set;}
		/// <summary>
		///  挡墙形式 
		///</summary>
		public string PORW_TYPW {get;set;}
		/// <summary>
		///挡墙长 
		///</summary>
		public Nullable<int> PORW_LENG {get;set;}
		/// <summary>
		///挡墙宽 
		///</summary>
		public Nullable<int> PORW_WIDE {get;set;}
		/// <summary>
		///挡墙高 
		///</summary>
		public Nullable<int> PORW_HIGH {get;set;}
		/// <summary>
		///挡墙材料 
		///</summary>
		public string PORW_MATE {get;set;}
	}
}