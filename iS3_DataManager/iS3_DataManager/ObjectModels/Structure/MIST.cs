using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Structure.Model
 { 
 	///<summary>///里程桩号///</summary>
	[Table("Structure_MIST")]
	public class MIST:DGObject
 	{ 
		/// <summary>
		///工程ID 
		///</summary>
		public string PROJ_ID {get;set;}
		/// <summary>
		///里程桩号编号 
		///</summary>
		public string MIST_NUMB {get;set;}
		/// <summary>
		///X坐标 
		///</summary>
		public Nullable<double> MIST_X {get;set;}
		/// <summary>
		///Y坐标 
		///</summary>
		public Nullable<double> MIST_Y {get;set;}
		/// <summary>
		///Z坐标 
		///</summary>
		public Nullable<double> MIST_Z {get;set;}
	}
}