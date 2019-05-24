using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_RDEN")]
	public class RDEN
 	{ 
		public string PROJ_ID {get;set;}
		public string RDEN_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string RDEN_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string RDEN_EQUP {get;set;}
		public string RDEN_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string RDEN_TESN {get;set;}
		public string RDEN_METH {get;set;}
		public string RDEN_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string RDEN_LITH {get;set;}
		public string RDEN_DESC {get;set;}
		public Nullable<double> RDEN_SAMV {get;set;}
		public Nullable<double> RDEN_DTPW {get;set;}
		public Nullable<double> RDEN_WSAQ {get;set;}
		public Nullable<double> RDEN_WSWQ {get;set;}
		public Nullable<int> RDEN_MC {get;set;}
		public Nullable<int> RDEN_SMC {get;set;}
		public Nullable<int> RDEN_DDEN {get;set;}
		public Nullable<int> RDEN_NDEN {get;set;}
		public Nullable<double> RDEN_PORO {get;set;}
		public Nullable<int> RDEN_PDEN {get;set;}
		public Nullable<int> RDEN_BDEN {get;set;}
		public string RDEN_REM {get;set;}
	}
}