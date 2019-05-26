using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_TTTS")]
	public class TTTS:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string TTTS_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string TTTS_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string TTTS_EQUP {get;set;}
		public string TTTS_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string TTTS_TESN {get;set;}
		public string TTTS_METH {get;set;}
		public string TTTS_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string TTTS_DESC {get;set;}
		public string TTTS_PLTF {get;set;}
		public Nullable<double> TTTS_SDIA {get;set;}
		public Nullable<double> TTTS_LEN {get;set;}
		public Nullable<double> TTTS_IMC {get;set;}
		public Nullable<double> TTTS_FMC {get;set;}
		public Nullable<double> TTTS_BDEN {get;set;}
		public Nullable<double> TTTS_DDEN {get;set;}
		public Nullable<int> TTTS_CELL {get;set;}
		public Nullable<int> TTTS_DEVF {get;set;}
		public Nullable<double> TTTS_STRN {get;set;}
		public Nullable<double> TTTS_CU {get;set;}
		public string TTTS_MODE {get;set;}
		public string TTTS_REM {get;set;}
	}
}