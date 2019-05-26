using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_RUCS")]
	public class RUCS:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string RUCS_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string RUCS_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string RUCS_EQUP {get;set;}
		public string RUCS_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string RUCS_TESN {get;set;}
		public string RUCS_METH {get;set;}
		public string RUCS_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string RUCS_LITH {get;set;}
		public string RUCS_DESC {get;set;}
		public string RUCS_SAMD {get;set;}
		public Nullable<int> RUCS_SAMN {get;set;}
		public Nullable<double> RUCS_MC {get;set;}
		public Nullable<double> RUCS_SDIA {get;set;}
		public Nullable<double> RUCS_LEN {get;set;}
		public Nullable<double> RUCS_SCSA {get;set;}
		public string RUCS_LOAD {get;set;}
		public Nullable<double> RUCS_MADL {get;set;}
		public string RUCS_MODE {get;set;}
		public Nullable<double> RUCS_AXIL {get;set;}
		public Nullable<double> RUCS_DIRS {get;set;}
		public Nullable<double> RUCS_VERS {get;set;}
		public Nullable<double> RUCS_LATS {get;set;}
		public string RUCS_SUCS {get;set;}
		public string RUCS_DUCS {get;set;}
		public Nullable<double> RUCS_SOFC {get;set;}
		public string RUCS_YMOD {get;set;}
		public Nullable<double> RUCS_POIS {get;set;}
		public string RUCS_ESTR {get;set;}
		public string RUCS_ETYP {get;set;}
		public string RUCS_REM {get;set;}
	}
}