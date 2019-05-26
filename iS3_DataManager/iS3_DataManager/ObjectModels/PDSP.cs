using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_PDSP")]
	public class PDSP:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string LOCA_ID {get;set;}
		public string HDPH_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string PDSP_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string PEOP_EQUP {get;set;}
		public string PDSP_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string PDSP_TESN {get;set;}
		public string PDSP_METH {get;set;}
		public Nullable<double> PDSP_DPTH {get;set;}
		public string PDSP_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string PDSP_TYPE {get;set;}
		public Nullable<double> PDSP_INHS {get;set;}
		public Nullable<double> PDSP_IHSV {get;set;}
		public Nullable<double> PDSP_YIEP {get;set;}
		public Nullable<double> PDSP_YPCV {get;set;}
		public Nullable<double> PDSP_PMCV {get;set;}
		public Nullable<double> PDSP_SOPC {get;set;}
		public Nullable<double> PDSP_SPM {get;set;}
		public Nullable<int> PDSP_BCCV {get;set;}
		public string PDSP_REM {get;set;}
	}
}