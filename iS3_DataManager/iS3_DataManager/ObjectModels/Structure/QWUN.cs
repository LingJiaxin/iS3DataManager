using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///业主单位///</summary>
	[Table("Structure_QWUN")]
	public class QWUN:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///工程名称 
		///</summary>
		public string PROJ_NAME {get;set;}
		/// <summary>
		///业主单位 
		///</summary>
		public string QWUN_COPM {get;set;}
		/// <summary>
		///主要负责人 
		///</summary>
		public string QWUN_CHAI {get;set;}
	}
}