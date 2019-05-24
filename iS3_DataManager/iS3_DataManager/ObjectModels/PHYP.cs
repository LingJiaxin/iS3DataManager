using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_PHYP")]
	public class PHYP
 	{ 
		public string PHYP_ROCC {get;set;}
		public Nullable<double> PHYP_PARD {get;set;}
		public Nullable<double> PHYP_NDEN {get;set;}
		public Nullable<double> PHYP_SDEN {get;set;}
		public Nullable<double> PHYP_DDEN {get;set;}
		public Nullable<double> PHYP_MOIS {get;set;}
		public Nullable<double> PHYP_WAAR {get;set;}
		public Nullable<double> PHYP_SWAR {get;set;}
		public Nullable<double> PHYP_WSCR {get;set;}
		public Nullable<double> PHYP_AFER {get;set;}
		public Nullable<double> PHYP_RFER {get;set;}
		public Nullable<double> PHYP_LCER {get;set;}
		public Nullable<double> PHYP_EXPP {get;set;}
		public Nullable<double> PHYP_POEC {get;set;}
	}
}