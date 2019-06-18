using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///建筑限界///</summary>
	[Table("Structure_BULI")]
	public class BULI:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///隧道ID 
		///</summary>
		public string TUNL_ID {get;set;}
		/// <summary>
		///行车道宽度 
		///</summary>
		public Nullable<double> BULI_WIDT {get;set;}
		/// <summary>
		///限高 
		///</summary>
		public Nullable<int> BULI_HIGH {get;set;}
		/// <summary>
		///检修道/人行道宽度 
		///</summary>
		public Nullable<double> BULI_WIDH {get;set;}
		/// <summary>
		///侧向宽度 
		///</summary>
		public Nullable<double> BULI_SIDH {get;set;}
	}
}