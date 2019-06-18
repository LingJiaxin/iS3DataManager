using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///初喷混凝土///</summary>
	[Table("Structure_SHCO")]
	public class SHCO:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///喷射混凝土型号 
		///</summary>
		public string SHCO_TYPE {get;set;}
		/// <summary>
		///喷射混凝土厚度 
		///</summary>
		public int  SHCO_THIC {get;set;}
		/// <summary>
		///喷射混凝土位置 
		///</summary>
		public string SHCO_SITU {get;set;}
		/// <summary>
		///是否设置仰拱 
		///</summary>
		public Nullable<bool> SHCO_YN {get;set;}
	}
}