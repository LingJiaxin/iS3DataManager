using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///锚杆///</summary>
	[Table("Structure_BOLT")]
	public class BOLT:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///锚杆类型 
		///</summary>
		public string BOLT_TYPE {get;set;}
		/// <summary>
		///锚杆布置形式 
		///</summary>
		public string BOLT_FORM {get;set;}
		/// <summary>
		///锚杆布置位置 
		///</summary>
		public string BOLT_SITU {get;set;}
		/// <summary>
		///锚杆长度 
		///</summary>
		public Nullable<int> BOLT_LENG {get;set;}
		/// <summary>
		///环向间距 
		///</summary>
		public Nullable<int> HOOP_DIST {get;set;}
		/// <summary>
		///纵向间距 
		///</summary>
		public Nullable<int> LENG_DIST {get;set;}
	}
}