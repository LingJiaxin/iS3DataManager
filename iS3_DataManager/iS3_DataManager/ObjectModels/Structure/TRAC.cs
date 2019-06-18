using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///横通道标准段///</summary>
	[Table("Structure_TRAC")]
	public class TRAC:DGObject
 	{ 
		/// <summary>
		///横通道编号 
		///</summary>
		public string TRCC_NUMB {get;set;}
		/// <summary>
		///混凝土型号 
		///</summary>
		public string TRCC_TYPE {get;set;}
		/// <summary>
		///横通道内轮廓高度 
		///</summary>
		public Nullable<int> TRCC_HIGH {get;set;}
		/// <summary>
		///横通道内轮廓宽度 
		///</summary>
		public Nullable<int> TRCC_WIDT {get;set;}
		/// <summary>
		///横通道标准段长度 
		///</summary>
		public Nullable<int> TRCC_LENG {get;set;}
	}
}