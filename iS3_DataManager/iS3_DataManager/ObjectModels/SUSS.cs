using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_SUSS")]
	public class SUSS
 	{ 
		public string PEOP_ID {get;set;}
		public string SUSS_MILE {get;set;}
		public Nullable<double> SUSS_SMIL {get;set;}
		public Nullable<double> SUSS_EMIL {get;set;}
		public Nullable<double> SUSS_LENG {get;set;}
		public Nullable<int> SUSS_DSRG {get;set;}
		public string SUSS_STLD {get;set;}
		public string SUSS_SUKD {get;set;}
		public string SUSS_SPGD {get;set;}
		public string SUSS_ARTD {get;set;}
		public string SUSS_MADE {get;set;}
		public string SUSS_GEAS {get;set;}
		public string SUSS_INTM {get;set;}
		public string SUSS_INCO {get;set;}
		public string SUSS_ADVC {get;set;}
		public string SUSS_ACME {get;set;}
		public string SUSS_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}