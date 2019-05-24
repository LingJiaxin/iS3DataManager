using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_MOIS")]
	public class MOIS
 	{ 
		public string PROJ_ID {get;set;}
		public string MOIS_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string MOIS_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string MOIS_EQUP {get;set;}
		public string MOIS_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string MOIS_TESN {get;set;}
		public string MOIS_METH {get;set;}
		public string MOIS_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string MOIS_LITH {get;set;}
		public string MOIS_DESC {get;set;}
		public string MOIS_SAMD {get;set;}
		public Nullable<double> MOIS_DRYT {get;set;}
		public Nullable<int> MOIS_SAMN {get;set;}
		public string MOIS_DRTM {get;set;}
		public Nullable<double> MOIS_WBDQ {get;set;}
		public Nullable<double> MOIS_TMSW1 {get;set;}
		public Nullable<double> MOIS_TMSW2 {get;set;}
		public Nullable<int> MOIS_MC {get;set;}
		public string MOIS_REM {get;set;}
	}
}