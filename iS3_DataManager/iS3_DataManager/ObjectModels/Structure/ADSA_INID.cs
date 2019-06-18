using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///超前小导管_初设///</summary>
	[Table("Structure_ADSA_INID")]
	public class ADSA_INID:DGObject
 	{ 
		/// <summary>
		///超前小导管ID 
		///</summary>
		public string PISS_ID {get;set;}
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINI_TYPE {get;set;}
		/// <summary>
		///导管规格 
		///</summary>
		public string ADSA_TYPE {get;set;}
		/// <summary>
		///导管外径 
		///</summary>
		public Nullable<int> ADSA_DIAM {get;set;}
		/// <summary>
		///导管长度 
		///</summary>
		public Nullable<int> ADSA_LENG {get;set;}
		/// <summary>
		///注浆孔孔径 
		///</summary>
		public Nullable<int> SLIP_DIAM {get;set;}
		/// <summary>
		///注浆孔间距 
		///</summary>
		public Nullable<int> SLIP_DIST {get;set;}
		/// <summary>
		///预留止浆段长度 
		///</summary>
		public Nullable<int> SLTA_LENG {get;set;}
		/// <summary>
		///导管环向设置间距 
		///</summary>
		public Nullable<int> HOOP_DIST {get;set;}
		/// <summary>
		///导管纵向排距 
		///</summary>
		public Nullable<int> HOOP_VIST {get;set;}
		/// <summary>
		///断面内导管数量 
		///</summary>
		public Nullable<int> HOOP_NUM {get;set;}
		/// <summary>
		///导管外插角 
		///</summary>
		public Nullable<double> PISS_ANGL {get;set;}
		/// <summary>
		///纵向水平搭接距离 
		///</summary>
		public Nullable<int> OVLA_DIST {get;set;}
		/// <summary>
		///加劲箍型号 
		///</summary>
		public string STRI_TYPE {get;set;}
		/// <summary>
		///加劲箍直径 
		///</summary>
		public Nullable<int> STRI_DIAM {get;set;}
	}
}