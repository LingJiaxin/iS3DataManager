using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_DYNP")]
	public class DYNP:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string LOCA_ID {get;set;}
		public string HDPH_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string DYNP_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string DYNP_EQUP {get;set;}
		public string _CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string DYNP_TESN {get;set;}
		public string DYNP_METH {get;set;}
		public Nullable<double> DYNP_DPTH {get;set;}
		public string DYNP_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string DYNP_TYPE {get;set;}
		public Nullable<double> DYNP_TESE {get;set;}
		public Nullable<int> DYNP_HAMW {get;set;}
		public Nullable<double> DYNP_FALD {get;set;}
		public Nullable<double> DYNP_PROD {get;set;}
		public Nullable<int> DYNP_CONA {get;set;}
		public Nullable<int> DYNP_HAMN {get;set;}
		public string DYNP_TSTE {get;set;}
		public Nullable<int> DYNP_SAPN {get;set;}
	}
}