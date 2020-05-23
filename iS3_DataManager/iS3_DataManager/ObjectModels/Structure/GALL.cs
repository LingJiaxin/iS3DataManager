using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///明洞工程///</summary>
	[Table("Structure_GALL")]
	public class GALL:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///明洞位置 
		///</summary>
		public string _GAPA_LOCA {get;set;}
		/// <summary>
		///明洞形式 
		///</summary>
		public string GAPA_TYPE {get;set;}
		/// <summary>
		///明暗洞交界处桩号 
		///</summary>
		public string GAPA_CONN {get;set;}
		/// <summary>
		///明洞衬砌类型 
		///</summary>
		public string GAPA_LINI {get;set;}
		/// <summary>
		///明洞防排水类型 
		///</summary>
		public string GAPA_DRAI {get;set;}
		/// <summary>
		///是否有套拱 
		///</summary>
		public Nullable<bool> GAPA_YN {get;set;}
	}
}