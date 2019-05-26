using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_GROS")]
	public class GROS:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string LOCA_ID {get;set;}
		public string HDPH_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string GROS_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string GROS_EQUP {get;set;}
		public string GROS_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string GROS_TESN {get;set;}
		public string GROS_METH {get;set;}
		public Nullable<double> GROS_DPTH {get;set;}
		public string GROS_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string GROS_TYPE {get;set;}
		public Nullable<double> GROS_TOP {get;set;}
		public string GROS_MEAP {get;set;}
		public Nullable<double> GROS_CHPP {get;set;}
		public Nullable<double> GROS_WAPR {get;set;}
		public Nullable<int> GROS_CRAO {get;set;}
		public Nullable<double> GROS_INFP {get;set;}
		public Nullable<double> GROS_STCR {get;set;}
		public Nullable<double> GROS_LCOP {get;set;}
		public Nullable<double> GROS_OPEP {get;set;}
		public Nullable<double> GROS_POWP {get;set;}
		public Nullable<double> GROS_MIPS {get;set;}
		public Nullable<double> GROS_MAPS {get;set;}
		public Nullable<double> GROS_DMAX {get;set;}
		public string GROS_REM {get;set;}
	}
}