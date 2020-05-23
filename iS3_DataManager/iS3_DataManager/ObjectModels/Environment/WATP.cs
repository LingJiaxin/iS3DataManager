using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Environment.Model
 { 
 	///<summary>///水质信息///</summary>
	[Table("Environment_WATP")]
	public class WATP:DGObject
 	{ 
		/// <summary>
		///水质信息ID 
		///</summary>
		public string WATP_ID {get;set;}
		/// <summary>
		///地层ID 
		///</summary>
		public string STRA_ID {get;set;}
		/// <summary>
		///钻孔ID 
		///</summary>
		public string HDPH_ID {get;set;}
		/// <summary>
		///氯离子浓度 
		///</summary>
		public Nullable<double> WATP_Cl {get;set;}
		/// <summary>
		///SO4浓度 
		///</summary>
		public Nullable<double> WATP_SO4 {get;set;}
		/// <summary>
		///Mg浓度 
		///</summary>
		public Nullable<double> WATP_MG {get;set;}
		/// <summary>
		///NH浓度 
		///</summary>
		public Nullable<double> WATP_NH {get;set;}
		/// <summary>
		///pH浓度 
		///</summary>
		public Nullable<double> WATP_PH {get;set;}
		/// <summary>
		///CO2浓度 
		///</summary>
		public Nullable<double> WATP_CO2 {get;set;}
		/// <summary>
		///腐蚀性 
		///</summary>
		public string WATP_CORR {get;set;}
	}
}