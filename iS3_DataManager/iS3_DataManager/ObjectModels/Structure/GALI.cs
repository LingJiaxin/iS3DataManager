using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///明洞工程///</summary>
	[Table("Structure_GALI")]
	public class GALI:DGObject
 	{ 
		/// <summary>
		///明洞ID 
		///</summary>
		public string GALL_ID {get;set;}
		/// <summary>
		///桩号 
		///</summary>
		public string GALL_MILE {get;set;}
		/// <summary>
		///明洞形式 
		///</summary>
		public string GALL_TYPE {get;set;}
		/// <summary>
		///明暗洞交界处桩号 
		///</summary>
		public string GALL_CONN {get;set;}
		/// <summary>
		///明洞防排水类型 
		///</summary>
		public string GALL_DRAI {get;set;}
		/// <summary>
		///是否有套拱 
		///</summary>
		public Nullable<bool> UMBR_YN {get;set;}
	}
}