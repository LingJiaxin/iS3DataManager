using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///地表注浆_施工图///</summary>
	[Table("Structure_GROG_COND")]
	public class GROG_COND:DGObject
 	{ 
		/// <summary>
		///地表注浆ID 
		///</summary>
		public string GROG_ID {get;set;}
		/// <summary>
		///注浆孔布置形式 
		///</summary>
		public string GROG_TYPE {get;set;}
		/// <summary>
		///注浆孔孔径 
		///</summary>
		public Nullable<int> GROG_DIAM {get;set;}
		/// <summary>
		///注浆孔间距 
		///</summary>
		public Nullable<int> GROG_DIST {get;set;}
	}
}