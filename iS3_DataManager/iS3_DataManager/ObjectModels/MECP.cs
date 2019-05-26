using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_MECP")]
	public class MECP:DGObject
 	{ 
		public Nullable<double> MECP_COF {get;set;}
		public Nullable<double> MECP_AGF {get;set;}
		public Nullable<double> MECP_UCS {get;set;}
		public Nullable<double> MECP_SUCS {get;set;}
		public Nullable<double> MECP_DUCS {get;set;}
		public Nullable<double> MECP_SOFC {get;set;}
		public Nullable<double> MECP_ELAM {get;set;}
		public Nullable<double> MECP_POIS {get;set;}
		public Nullable<double> MECP_SPLS {get;set;}
		public Nullable<double> MECP_COEF {get;set;}
		public Nullable<double> MECP_COHE {get;set;}
		public Nullable<double> MECP_PLSI {get;set;}
		public Nullable<double> MECP_PLS {get;set;}
		public Nullable<double> MECP_FLES {get;set;}
		public Nullable<double> MECP_FTCO {get;set;}
		public Nullable<double> MECP_RMLR {get;set;}
	}
}