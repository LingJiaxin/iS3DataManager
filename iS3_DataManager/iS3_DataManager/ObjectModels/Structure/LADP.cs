using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///横向排水管///</summary>
	[Table("Structure_LADP")]
	public class LADP:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///横向排水管规格 
		///</summary>
		public string HPIP_TYPE {get;set;}
		/// <summary>
		///横向排水管间距 
		///</summary>
		public Nullable<int> HPIP_DIST {get;set;}
		/// <summary>
		///横向排水管长度 
		///</summary>
		public Nullable<int> HPIP_LENG {get;set;}
		/// <summary>
		///三通管数量 
		///</summary>
		public Nullable<int> BRAN_NUMB {get;set;}
		/// <summary>
		///是否有检修口 
		///</summary>
		public Nullable<bool> INSE_YN {get;set;}
		/// <summary>
		///检修口规格 
		///</summary>
		public string INSE_TYPE {get;set;}
		/// <summary>
		///是否有渗水引水管 
		///</summary>
		public Nullable<bool> AQUE_YN {get;set;}
	}
}