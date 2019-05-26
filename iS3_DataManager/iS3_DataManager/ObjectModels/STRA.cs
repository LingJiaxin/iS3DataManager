using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_STRA")]
	public class STRA:DGObject
 	{ 
		public string STRA_ID {get;set;}
		public Nullable<double> STRA_TOP {get;set;}
		public Nullable<double> STRA_BASE {get;set;}
		public string STRA_HDFW {get;set;}
		public Nullable<double> STRA_PJHD {get;set;}
		public string STRA_YTWZ {get;set;}
		public string STRA_DESC {get;set;}
		public string STRA_GEO1 {get;set;}
		public string STRA_GEO2 {get;set;}
		public string STRA_STAT {get;set;}
		public string STRA_DSRG {get;set;}
		public Nullable<double> STRA_DIP {get;set;}
		public Nullable<double> STRA_DIR {get;set;}
		public string STRA_COLO {get;set;}
		public string STRA_CAUS {get;set;}
		public string STRA_COMP {get;set;}
		public string STRA_STRU {get;set;}
		public string STRA_DEGW {get;set;}
		public string STRA_PHYP {get;set;}
		public string STRA_MECP {get;set;}
		public string FILE_FSET {get;set;}
	}
}