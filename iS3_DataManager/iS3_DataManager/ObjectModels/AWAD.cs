using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_AWAD")]
	public class AWAD
 	{ 
		public string PROJ_ID {get;set;}
		public string AWAD_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string AWAD_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string AWAD_EQUP {get;set;}
		public string AWAD_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string AWAD_TESN {get;set;}
		public string AWAD_METH {get;set;}
		public string AWAD_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string AWAD_LITH {get;set;}
		public string AWAD_DESC {get;set;}
		public string AWAD_SAMD {get;set;}
		public Nullable<int> AWAD_SAMN {get;set;}
		public Nullable<double> AWAD_NATQ {get;set;}
		public Nullable<double> AWAD_DMAS {get;set;}
		public Nullable<double> AWAD_SMAS {get;set;}
		public Nullable<int> AWAD_WAB {get;set;}
		public string AWAD_SWAB {get;set;}
		public string AWAD_REM {get;set;}
	}
}