using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///路面钢筋///</summary>
	[Table("Structure_FIST")]
	public class FIST:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINI_TYPE {get;set;}
		/// <summary>
		///是否是混凝土路面 
		///</summary>
		public Nullable<bool> SHCO_YN {get;set;}
		/// <summary>
		///边缘补强钢筋型号 
		///</summary>
		public string FIST_TYPE {get;set;}
		/// <summary>
		///边缘补强钢筋间距 
		///</summary>
		public Nullable<int> FIST_DIST {get;set;}
		/// <summary>
		///边缘补强钢筋长度 
		///</summary>
		public Nullable<int> FIST_LENG {get;set;}
		/// <summary>
		///面层钢筋型号 
		///</summary>
		public string FAST_TYPE {get;set;}
		/// <summary>
		///面层钢筋长度 
		///</summary>
		public Nullable<int> FAST_LENG {get;set;}
	}
}