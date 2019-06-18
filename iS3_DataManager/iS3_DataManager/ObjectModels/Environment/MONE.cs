using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///监测仪器///</summary>
	[Table("Environment_MONE")]
	public class MONE:DGObject
 	{ 
		/// <summary>
		///监测仪器ID 
		///</summary>
		public string MONE_ID {get;set;}
		/// <summary>
		///仪器名称 
		///</summary>
		public string MONE_NAME {get;set;}
		/// <summary>
		///单位名称 
		///</summary>
		public string MONE_UNIN {get;set;}
		/// <summary>
		///备注信息 
		///</summary>
		public string MONE_MARK {get;set;}
	}
}