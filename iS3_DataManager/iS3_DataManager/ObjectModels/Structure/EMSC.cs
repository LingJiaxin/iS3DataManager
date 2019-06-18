using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///紧急停车带非标准段///</summary>
	[Table("Structure_EMSC")]
	public class EMSC:DGObject
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
		///紧急停车带非标准段长度 
		///</summary>
		public Nullable<int> EMSC_LENG {get;set;}
		/// <summary>
		///缓冲带角度 
		///</summary>
		public Nullable<int> EMSC_ANGL {get;set;}
	}
}