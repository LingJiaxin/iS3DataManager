using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///地球物探///</summary>
	[Table("Structure_GPRF")]
	public class GPRF:DGObject
 	{ 
		/// <summary>
		///物探ID 
		///</summary>
		public string GPRF_ID {get;set;}
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///桩号区间 
		///</summary>
		public string GPRF_INTE {get;set;}
		/// <summary>
		///岩性 
		///</summary>
		public string GPRF_LITH {get;set;}
		/// <summary>
		///地球物探字段1 
		///</summary>
		public string GPRF_MD {get;set;}
		/// <summary>
		///地球物探字段2 
		///</summary>
		public string GPRF_ZPS {get;set;}
		/// <summary>
		///地球物探字段3 
		///</summary>
		public string GPRF_HPS {get;set;}
		/// <summary>
		///地球物探字段4 
		///</summary>
		public string GPRF_PSB {get;set;}
		/// <summary>
		///地球物探字段5 
		///</summary>
		public string GPRF_EM {get;set;}
		/// <summary>
		///实测岩性 
		///</summary>
		public string GPRF_FORE {get;set;}
		/// <summary>
		///风化程度 
		///</summary>
		public string GPRF_WEA {get;set;}
		/// <summary>
		///地下水 
		///</summary>
		public string GPRF_WATE {get;set;}
		/// <summary>
		///稳定性 
		///</summary>
		public string GPRF_STAB {get;set;}
		/// <summary>
		///断层 
		///</summary>
		public string GPRF_FAUL {get;set;}
		/// <summary>
		///围岩等级1 
		///</summary>
		public string GPRF_PSRL {get;set;}
		/// <summary>
		///围岩等级2 
		///</summary>
		public string GPRF_STRE {get;set;}
		/// <summary>
		///关联文件 
		///</summary>
		public string FILE_FSET {get;set;}
	}
}