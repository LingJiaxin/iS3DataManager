using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///锁口圈///</summary>
	[Table("Structure_SIWE")]
	public class SIWE:DGObject
 	{ 
		/// <summary>
		///竖井ID 
		///</summary>
		public string SILO_ID {get;set;}
		/// <summary>
		///锁口内径 
		///</summary>
		public Nullable<int> SHWE_DRAI {get;set;}
		/// <summary>
		///锁口圈高度 
		///</summary>
		public Nullable<int> SHWE_HIGH {get;set;}
		/// <summary>
		///放脚宽度 
		///</summary>
		public Nullable<int> SHWE_WIDE {get;set;}
		/// <summary>
		///放脚比率 
		///</summary>
		public string SHWE_SLOP {get;set;}
	}
}