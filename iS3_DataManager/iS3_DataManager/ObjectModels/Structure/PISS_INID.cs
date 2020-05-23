using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///管棚支护_初设///</summary>
	[Table("Structure_PISS_INID")]
	public class PISS_INID:DGObject
 	{ 
		/// <summary>
		///钢管型号 
		///</summary>
		public string PISS_TYPE {get;set;}
		/// <summary>
		///钢管分段长 
		///</summary>
		public Nullable<int> PISS_LENG {get;set;}
		/// <summary>
		///钢管外径 
		///</summary>
		public Nullable<int> PISS_DILA {get;set;}
		/// <summary>
		///钢管壁厚 
		///</summary>
		public Nullable<int> PISS_THIC {get;set;}
		/// <summary>
		///钢管环向间距 
		///</summary>
		public Nullable<int> PISS_DIST {get;set;}
		/// <summary>
		///断面内钢管数量 
		///</summary>
		public Nullable<int> PISS_NUM {get;set;}
		/// <summary>
		///钢管外插角 
		///</summary>
		public Nullable<double> PISS_ANGL {get;set;}
		/// <summary>
		///预留止浆段长度 
		///</summary>
		public Nullable<int> RESE_LENG {get;set;}
		/// <summary>
		///加筋箍型号 
		///</summary>
		public string STRI_TYPE {get;set;}
		/// <summary>
		///加筋箍直径 
		///</summary>
		public Nullable<int> STRI_DIAM {get;set;}
		/// <summary>
		///锥头长度 
		///</summary>
		public Nullable<int> COHE_LENG {get;set;}
		/// <summary>
		///出浆孔直径 
		///</summary>
		public Nullable<int> SLIP_DIAM {get;set;}
		/// <summary>
		///出浆孔布设形式 
		///</summary>
		public string SLIP_TYPE {get;set;}
		/// <summary>
		///出浆孔间距 
		///</summary>
		public Nullable<int> SLIP_DIST {get;set;}
		/// <summary>
		///止浆塞型号 
		///</summary>
		public string STGR_TYPE {get;set;}
		/// <summary>
		///钢筋笼主筋型号 
		///</summary>
		public string STEL_TYPE {get;set;}
		/// <summary>
		///钢筋笼主筋直径 
		///</summary>
		public Nullable<int> STEL_DIAM {get;set;}
		/// <summary>
		///固定环型号 
		///</summary>
		public string FIX_HOTY {get;set;}
		/// <summary>
		///固定环外径 
		///</summary>
		public Nullable<int> FIX_DIAM {get;set;}
		/// <summary>
		///固定环壁厚 
		///</summary>
		public Nullable<int> FIX_THIC {get;set;}
	}
}