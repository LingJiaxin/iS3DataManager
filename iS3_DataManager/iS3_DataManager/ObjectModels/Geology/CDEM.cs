using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	///<summary>///地理空间数据云DEM///</summary>
	[Table("Geology_CDEM")]
	public class CDEM:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///线性单位 
		///</summary>
		public string CDEM_UNIT {get;set;}
		/// <summary>
		///上范围 
		///</summary>
		public string CDEM_NAME {get;set;}
		/// <summary>
		///下范围 
		///</summary>
		public Nullable<double> CDEM_UP {get;set;}
		/// <summary>
		///左范围 
		///</summary>
		public Nullable<double> CDEM_DOWN {get;set;}
		/// <summary>
		///右范围 
		///</summary>
		public Nullable<double> CDEM_LEFT {get;set;}
		/// <summary>
		///备注 
		///</summary>
		public Nullable<double> CDEM_RIGH {get;set;}
		/// <summary>
		///关联文件 
		///</summary>
		public string CDEM_REM {get;set;}
	}
}