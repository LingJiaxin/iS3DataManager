using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///套拱钢架///</summary>
	[Table("Structure_UMSA")]
	public class UMSA:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///是否存在钢架 
		///</summary>
		public bool  UMSA_YN {get;set;}
		/// <summary>
		///工字钢架间距 
		///</summary>
		public Nullable<int> UMSA_DIST {get;set;}
		/// <summary>
		///工字钢架型号 
		///</summary>
		public string UMSA_TYPE {get;set;}
		/// <summary>
		///工字钢架单元数量 
		///</summary>
		public Nullable<int> UMSA_ELEM {get;set;}
		/// <summary>
		///拱部工字钢架半径 
		///</summary>
		public Nullable<int> UMSA_RADI {get;set;}
		/// <summary>
		///拱部钢架单元圆心角 
		///</summary>
		public Nullable<double> UMSA_ANGL {get;set;}
		/// <summary>
		///拱墙工字钢架长度 
		///</summary>
		public Nullable<int> UMSA_LENG {get;set;}
	}
}