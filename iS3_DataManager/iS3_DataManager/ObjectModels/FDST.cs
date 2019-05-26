using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_FDST")]
	public class FDST:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string LOCA_ID {get;set;}
		public string HDPH_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string _DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string FDST_EQUP {get;set;}
		public string FDST_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string FDST_TESN {get;set;}
		public string FDST_METH {get;set;}
		public Nullable<double> FDST_DPTH {get;set;}
		public string FDST_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string FDST_CLSD {get;set;}
		public Nullable<int> FDST_NORL {get;set;}
		public Nullable<double> FDST_NORS {get;set;}
		public Nullable<double> FDST_SHES {get;set;}
		public Nullable<double> FDST_SHED {get;set;}
		public Nullable<double> FDST_VERD {get;set;}
		public Nullable<double> FDST_DILS {get;set;}
		public string FDST_SSFMD {get;set;}
		public Nullable<double> FDST_PESS {get;set;}
		public Nullable<double> FDST_SHS {get;set;}
		public Nullable<double> FDST_RSHS {get;set;}
		public Nullable<double> FDST_COF {get;set;}
		public Nullable<double> FDST_RCOF {get;set;}
		public Nullable<double> FDST_AGF {get;set;}
		public Nullable<double> FDST_RAGF {get;set;}
	}
}