using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_EXPA")]
	public class EXPA:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string EXPA_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string EXPA_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string EXPA_EQUP {get;set;}
		public string EXPA_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string EXPA_TESN {get;set;}
		public string EXPA_METH {get;set;}
		public string EXPA_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string EXPA_LITH {get;set;}
		public string EXPA_DESC {get;set;}
		public string EXPA_SAMD {get;set;}
		public Nullable<int> EXPA_SAMN {get;set;}
		public Nullable<double> EXPA_SIZE {get;set;}
		public Nullable<double> EXPA_HEIG {get;set;}
		public Nullable<double> EXPA_LOAD {get;set;}
		public Nullable<double> EXPA_ADEF {get;set;}
		public Nullable<double> EXPA_RDEF {get;set;}
		public Nullable<double> EXPA_ADLC {get;set;}
		public Nullable<double> EXPA_AFER {get;set;}
		public Nullable<double> EXPA_RFER {get;set;}
		public Nullable<double> EXPA_LCER {get;set;}
		public string EXPA_REM {get;set;}
	}
}