using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///格栅钢架接头///</summary>
	[Table("Structure_GSFC")]
	public class GSFC:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///是否存在格栅钢架 
		///</summary>
		public Nullable<bool> GRST_YN {get;set;}
		/// <summary>
		///槽钢规格 
		///</summary>
		public string CHAN_TYPE {get;set;}
		/// <summary>
		///槽钢数量 
		///</summary>
		public Nullable<int> CHAN_NUMB {get;set;}
		/// <summary>
		///角钢规格 
		///</summary>
		public string ANST_TYPE {get;set;}
		/// <summary>
		///角钢数量 
		///</summary>
		public Nullable<int> ANST_NUMB {get;set;}
		/// <summary>
		///螺栓螺母规格 
		///</summary>
		public string BOLT_TYPE {get;set;}
		/// <summary>
		///螺栓螺母数量 
		///</summary>
		public Nullable<int> BOLT_NUMB {get;set;}
		/// <summary>
		///螺栓孔直径 
		///</summary>
		public Nullable<int> BOHO_RADI {get;set;}
		/// <summary>
		///角钢螺栓孔间距 
		///</summary>
		public Nullable<int> BOHO_DIST {get;set;}
		/// <summary>
		///每个角钢螺栓孔数量 
		///</summary>
		public Nullable<int> BOHO_NUMB {get;set;}
	}
}