using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_RPLT")]
	public class RPLT:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string RPLT_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string RPLT_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string RPLT_EQUP {get;set;}
		public string RPLT_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string RPLT_TESN {get;set;}
		public string RPLT_METH {get;set;}
		public string RPLT_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string RPLT_DESC {get;set;}
		public string RPLT_PLTF {get;set;}
		public string RPLT_SAMD {get;set;}
		public string RPLT_LOAM {get;set;}
		public string RPLT_SAMS {get;set;}
		public Nullable<double> RPLT_MC {get;set;}
		public Nullable<double> RPLT_SIZE {get;set;}
		public Nullable<double> RPLT_HEIG {get;set;}
		public Nullable<double> RPLT_LPS {get;set;}
		public Nullable<double> RPLT_ECD {get;set;}
		public string RPLT_ANII {get;set;}
		public string RPLT_DESF {get;set;}
		public Nullable<double> RPLT_DESL {get;set;}
		public Nullable<double> RPLT_PLS {get;set;}
		public Nullable<double> RPLT_PLSI {get;set;}
		public string RPLT_REM {get;set;}
	}
}