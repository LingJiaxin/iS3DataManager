using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_GRMI")]
	public class GRMI:DGObject
 	{ 
		public string GRMI_ID {get;set;}
		public Nullable<double> GRMI_GMPA {get;set;}
		public Nullable<int> GRMI_GMRP {get;set;}
		public string GRMI_SFI {get;set;}
		public string GRMI_DEG {get;set;}
		public Nullable<double> GRMI_BSA {get;set;}
		public string GRMI_SWV {get;set;}
		public string GRMI_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}