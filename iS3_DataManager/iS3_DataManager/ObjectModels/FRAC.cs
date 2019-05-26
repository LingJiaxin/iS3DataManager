using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_FRAC")]
	public class FRAC:DGObject
 	{ 
		public string FRAC_SET {get;set;}
		public Nullable<int> FRAC_IMAX {get;set;}
		public Nullable<int> FRAC_IAVE {get;set;}
		public Nullable<int> FRAC_IMIN {get;set;}
		public Nullable<int> FRAC_INDX {get;set;}
		public string FRAC_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}