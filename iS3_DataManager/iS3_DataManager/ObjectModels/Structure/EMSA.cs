using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///紧急停车带标准段///</summary>
	[Table("Structure_EMSA")]
	public class EMSA:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///紧急停车带编号 
		///</summary>
		public string EMSA_NUMB {get;set;}
		/// <summary>
		///紧急停车带中心桩号 
		///</summary>
		public string EMSA_MILE {get;set;}
		/// <summary>
		///紧急停车带衬砌类型 
		///</summary>
		public string EMSA_TYPE {get;set;}
		/// <summary>
		///紧急停车带标准段长度 
		///</summary>
		public Nullable<int> EMSA_LENG {get;set;}
	}
}