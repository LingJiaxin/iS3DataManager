using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_TTES")]
	public class TTES
 	{ 
		public string PROJ_ID {get;set;}
		public string TTES_LOCA {get;set;}
		public string SPEC_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string TTES_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string TTES_EQUP {get;set;}
		public string TTES_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string TTES_TESN {get;set;}
		public string TTES_METH {get;set;}
		public string TTES_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string TTES_DESC {get;set;}
		public string TTES_PLTF {get;set;}
		public Nullable<int> TTES_COH {get;set;}
		public Nullable<double> TTES_AOF {get;set;}
		public Nullable<double> TTES_SDIA {get;set;}
		public Nullable<double> TTES_LEN {get;set;}
		public Nullable<double> TTES_IMC {get;set;}
		public Nullable<double> TTES_FMC {get;set;}
		public Nullable<double> TTES_BDEN {get;set;}
		public Nullable<double> TTES_DDEN {get;set;}
		public string TTES_SAT {get;set;}
		public string TTES_CONS {get;set;}
		public Nullable<int> TTES_CONP {get;set;}
		public Nullable<int> TTES_CELL {get;set;}
		public Nullable<int> TTES_PWPI {get;set;}
		public Nullable<double> TTES_STRR {get;set;}
		public Nullable<double> TTES_STRN {get;set;}
		public Nullable<int> TTES_DEVF {get;set;}
		public Nullable<int> TTES_PWPF {get;set;}
		public Nullable<double> TTES_STV {get;set;}
		public string TTES_MODE {get;set;}
		public string TTES_REM {get;set;}
	}
}