using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///地表砂浆锚杆_初设///</summary>
	[Table("Structure_GRSC_INID")]
	public class GRSC_INID:DGObject
 	{ 
		/// <summary>
		///地表砂浆锚杆ID 
		///</summary>
		public string GRSC_ID {get;set;}
		/// <summary>
		///锚杆规格 
		///</summary>
		public string GRSC_TYPE {get;set;}
		/// <summary>
		///锚杆外径 
		///</summary>
		public Nullable<int> GRSC_DIAM {get;set;}
		/// <summary>
		///锚杆长度 
		///</summary>
		public Nullable<int> GRSC_LENG {get;set;}
	}
}