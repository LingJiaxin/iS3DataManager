using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///二台阶开挖参数///</summary>
	[Table("Structure_EPEM")]
	public class EPEM:DGObject
 	{ 
		/// <summary>
		///掌子面桩号 
		///</summary>
		public string EP_CHAI {get;set;}
		/// <summary>
		///台阶步长 
		///</summary>
		public Nullable<double> EP_SS {get;set;}
		/// <summary>
		///开挖高度 
		///</summary>
		public string EP_EH {get;set;}
		/// <summary>
		///开挖宽度 
		///</summary>
		public string EP_EW {get;set;}
		/// <summary>
		///循环进尺 
		///</summary>
		public string EP_CYCF {get;set;}
	}
}