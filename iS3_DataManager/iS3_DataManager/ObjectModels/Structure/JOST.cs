using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///工字钢架///</summary>
	[Table("Structure_JOST")]
	public class JOST:DGObject
 	{ 
		/// <summary>
		///衬砌类型 
		///</summary>
		public string LINE_TYPE {get;set;}
		/// <summary>
		///是否存在钢架 
		///</summary>
		public Nullable<bool> STAR_YN {get;set;}
		/// <summary>
		///槽钢规格 
		///</summary>
		public string CHAN_TYPE {get;set;}
		/// <summary>
		///槽钢数量 
		///</summary>
		public Nullable<int> CHAN_NUMB {get;set;}
		/// <summary>
		///接头钢板规格 
		///</summary>
		public string STPL_TYPE {get;set;}
		/// <summary>
		///接头钢板数量 
		///</summary>
		public Nullable<int> STPL_NUMB {get;set;}
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
		///连接钢板螺栓孔间距 
		///</summary>
		public Nullable<int> BOHO_DIST {get;set;}
		/// <summary>
		///纵向连接筋间距 
		///</summary>
		public Nullable<int> BOHO_VSTE {get;set;}
	}
}