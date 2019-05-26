using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_WAVE_S")]
	public class WAVE_S:DGObject
 	{ 
		public string PROJ_ID {get;set;}
		public string WAVE_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string WAVE_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string WAVE_EQUP {get;set;}
		public string WAVE_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string WAVE_TESN {get;set;}
		public string WAVE_METH {get;set;}
		public Nullable<double> WAVE_DPTH {get;set;}
		public string WAVE_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string WAVE_DESC {get;set;}
		public string WAVE_MPNM {get;set;}
		public string WAVE_MPPS {get;set;}
		public string WAVE_MPGD {get;set;}
		public Nullable<double> WAVE_SPAC {get;set;}
		public Nullable<int> WAVE_TIME {get;set;}
		public Nullable<int> WAVE_RLWV1 {get;set;}
		public Nullable<int> WAVE_RLWV2 {get;set;}
		public Nullable<double> WAVE_RMIF {get;set;}
		public string WAVE_REM {get;set;}
	}
}