using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_INJC")]
	public class INJC
 	{ 
		public string PROJ_ID {get;set;}
		public string LOCA_ID {get;set;}
		public string HYDW_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string INJC_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string INJC_EQUP {get;set;}
		public string INJC_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string INJC_TESN {get;set;}
		public string INJC_METH {get;set;}
		public string INJC_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string INJC_DESC {get;set;}
		public Nullable<double> INJC_WATD {get;set;}
		public Nullable<double> INJC_DEPT {get;set;}
		public Nullable<double> INJC_LENG {get;set;}
		public Nullable<double> INJC_DIAM {get;set;}
		public string INJC_TYPE {get;set;}
		public Nullable<double> INJC_HEAD {get;set;}
		public Nullable<double> INJC_INJW {get;set;}
		public Nullable<double> INJC_UTIN {get;set;}
		public string INJC_DURA {get;set;}
		public Nullable<double> INJC_WATP {get;set;}
		public string INJC_REM {get;set;}
	}
}