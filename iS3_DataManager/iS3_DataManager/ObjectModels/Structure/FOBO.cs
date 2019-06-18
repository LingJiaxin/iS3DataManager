using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///锁脚锚杆///</summary>
	[Table("Structure_FOBO")]
	public class FOBO:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///是否有锁脚锚杆 
		///</summary>
		public string FOBO_YN {get;set;}
		/// <summary>
		///锁脚锚杆类型 
		///</summary>
		public string FOBO_TYPE {get;set;}
		/// <summary>
		///单侧个数 
		///</summary>
		public string FOBO_NUMB {get;set;}
		/// <summary>
		///缩脚锚杆长度 
		///</summary>
		public Nullable<int> FOBO_LENG {get;set;}
		/// <summary>
		///锁脚锚杆位置 
		///</summary>
		public Nullable<int> FOBO_SITU {get;set;}
		/// <summary>
		///锁脚锚杆外插角 
		///</summary>
		public Nullable<int> FOBO_ANGL {get;set;}
	}
}