using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_CHEM")]
	public class CHEM
 	{ 
		public string PROJ_ID {get;set;}
		public string CHEM_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string CHEM_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string CHEM_EQUP {get;set;}
		public string CHEM_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string CHEM_TESN {get;set;}
		public string CHEM_METH {get;set;}
		public string CHEM_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string CHEM_DESC {get;set;}
		public string CHEM_SAMD {get;set;}
		public Nullable<int> CHEM_SAMN {get;set;}
		public Nullable<double> HYCH_PH {get;set;}
		public Nullable<double> HYCH_HARD {get;set;}
		public Nullable<double> HYCH_K {get;set;}
		public Nullable<double> HYCH_NA {get;set;}
		public Nullable<double> HYCH_GA {get;set;}
		public Nullable<double> HYCH_MG {get;set;}
		public Nullable<double> HYCH_HCO3 {get;set;}
		public Nullable<double> HYCH_SO4 {get;set;}
		public Nullable<double> HYCH_CL {get;set;}
		public string HYCH_CHTY {get;set;}
		public string CHEM_REM {get;set;}
	}
}