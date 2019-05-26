using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_PLTG")]
	public class PLTG:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string LOCA_ID {get;set;}
		public string HDPH_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string _DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string PLTG_EQUP {get;set;}
		public string PLTG_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string PLTG_TESN {get;set;}
		public Nullable<double> PLTG_DPTH {get;set;}
		public Nullable<int> PLTG_PDIA {get;set;}
		public Nullable<double> PLTG_SEAT {get;set;}
		public string PLTG_LST {get;set;}
		public Nullable<int> PLTG_CYC {get;set;}
		public Nullable<double> PLTG_EV2 {get;set;}
		public string PLTG_REM {get;set;}
		public string PLTG_ENV {get;set;}
		public string PLTG_METH {get;set;}
		public string PLTG_STAT {get;set;}
		public string STRA_ID {get;set;}
		public Nullable<double> PLTG_SMOD {get;set;}
		public Nullable<double> PLTG_EMOD {get;set;}
		public Nullable<double> PLTG_GRRC {get;set;}
	}
}