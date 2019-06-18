using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///监理单位///</summary>
	[Table("Structure_MOUN")]
	public class MOUN:DGObject
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
		///监理单位 
		///</summary>
		public string MOUN_COPM {get;set;}
		/// <summary>
		///主要负责人 
		///</summary>
		public string MOUN_CHAI {get;set;}
	}
}