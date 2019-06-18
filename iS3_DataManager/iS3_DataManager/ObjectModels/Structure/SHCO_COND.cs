using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///初喷混凝土_施工图///</summary>
	[Table("Structure_SHCO_COND")]
	public class SHCO_COND:DGObject
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
		public Nullable<int> SHCO_THIC {get;set;}
		/// <summary>
		///喷射混凝土位置 
		///</summary>
		public string SHCO_SITU {get;set;}
		/// <summary>
		///拱脚宽度 
		///</summary>
		public Nullable<int> SHCO_ARFO {get;set;}
		/// <summary>
		///预留变形量 
		///</summary>
		public Nullable<int> DEFO_THIC {get;set;}
	}
}