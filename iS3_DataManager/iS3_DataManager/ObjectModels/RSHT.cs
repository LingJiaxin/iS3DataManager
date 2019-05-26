using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_RSHT")]
	public class RSHT:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string RSHT_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string RSHT_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string RSHT_EQUP {get;set;}
		public string RSHT_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string RSHT_TESN {get;set;}
		public string RSHT_METH {get;set;}
		public string RSHT_STAT {get;set;}
		public string STRA_ID {get;set;}
		public Nullable<double> RSHT_MC {get;set;}
		public Nullable<double> RSHT_SDIA {get;set;}
		public Nullable<double> RSHT_HEIG {get;set;}
		public Nullable<double> RSHT_LEN {get;set;}
		public Nullable<double> RSHT_AXIL {get;set;}
		public Nullable<double> RSHT_AXIS {get;set;}
		public Nullable<double> RSHT_SHES {get;set;}
		public Nullable<double> RSHT_SHED {get;set;}
		public Nullable<double> RSHT_AXID {get;set;}
		public Nullable<int> TTES_COH {get;set;}
		public Nullable<double> TTES_AOF {get;set;}
		public string RSHT_REM {get;set;}
	}
}