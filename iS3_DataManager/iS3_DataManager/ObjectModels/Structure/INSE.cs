using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///内轮廓///</summary>
	[Table("Structure_INSE")]
	public class INSE:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///隧道ID 
		///</summary>
		public string TUNL_ID {get;set;}
		/// <summary>
		///断面类型 
		///</summary>
		public string INSE_TYPE {get;set;}
		/// <summary>
		///最大宽度 
		///</summary>
		public Nullable<int> INSE_HIGH {get;set;}
		/// <summary>
		///最大高度 
		///</summary>
		public Nullable<double> INSE_WIDT {get;set;}
	}
}