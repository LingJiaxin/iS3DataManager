using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///开挖洞渣///</summary>
	[Table("Environment_TUEG")]
	public class TUEG:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///洞渣主要成分 
		///</summary>
		public string TUEG_COMP {get;set;}
		/// <summary>
		///洞渣PH值 
		///</summary>
		public Nullable<double> TUEG_PH {get;set;}
		/// <summary>
		///洞渣利用率 
		///</summary>
		public Nullable<double> TUEG_RATE {get;set;}
		/// <summary>
		///备注 
		///</summary>
		public string PLRO_REM {get;set;}
		/// <summary>
		///关联文件索引 
		///</summary>
		public string FILE_FSET {get;set;}
	}
}