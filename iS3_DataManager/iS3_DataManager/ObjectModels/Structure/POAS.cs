using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///洞口超前支护///</summary>
	[Table("Structure_POAS")]
	public class POAS:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///洞口形式 
		///</summary>
		public string POPA_TYPE {get;set;}
		/// <summary>
		///洞口位置 
		///</summary>
		public string POPA_LOCA {get;set;}
		/// <summary>
		///洞口超前支护类型 
		///</summary>
		public string POAS_TYPE {get;set;}
	}
}