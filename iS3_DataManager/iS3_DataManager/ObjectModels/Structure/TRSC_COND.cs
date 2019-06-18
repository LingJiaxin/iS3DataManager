using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///横通道非标准段_施工图///</summary>
	[Table("Structure_TRSC_COND")]
	public class TRSC_COND:DGObject
 	{ 
		/// <summary>
		///横通道编号 
		///</summary>
		public string TRSC_NUMB {get;set;}
		/// <summary>
		///混凝土型号 
		///</summary>
		public string TRSC_TYPE {get;set;}
		/// <summary>
		///横通道内轮廓高度 
		///</summary>
		public Nullable<int> TRSC_HIGH {get;set;}
		/// <summary>
		///横通道内轮廓宽度 
		///</summary>
		public Nullable<int> TRSC_WIDT {get;set;}
		/// <summary>
		///横通道非标准段长度 
		///</summary>
		public Nullable<int> TRSC_LENG {get;set;}
	}
}