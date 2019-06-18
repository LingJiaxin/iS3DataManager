using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///轨道///</summary>
	[Table("Structure_TRAK")]
	public class TRAK:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///轨道类型 
		///</summary>
		public string TRAC_TYPE {get;set;}
	}
}