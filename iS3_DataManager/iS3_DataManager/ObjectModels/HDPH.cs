using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_HDPH")]
	public class HDPH:DGObject
 	{ 
		public string LOCA_ID {get;set;}
		public string HDPH_ID {get;set;}
		public string HDPH_TYPE {get;set;}
		public string HDPH_METH {get;set;}
		public string HDPH_ZKMD {get;set;}
		public Nullable<double> HDPH_TOP {get;set;}
		public string HDPH_ENDD {get;set;}
		public Nullable<double> PEOP_DIAM {get;set;}
		public Nullable<int> HDPH_BDA {get;set;}
		public Nullable<double> HDPH_SHOR {get;set;}
		public Nullable<double> HDPH_STAB {get;set;}
		public string HDPH_STRA {get;set;}
		public Nullable<double> HDPH_QXL {get;set;}
		public Nullable<double> HDPH_CJSW {get;set;}
		public Nullable<double> HDPH_WDSW {get;set;}
		public Nullable<int> HDPH_HSGS {get;set;}
		public string HDPH_QZSD {get;set;}
		public string HDPH_WTYP {get;set;}
		public string HDPH_WDES {get;set;}
		public string HDPH_STAT {get;set;}
		public string FILE_ENDT {get;set;}
		public string PEOP_ID {get;set;}
		public string HDPH_JQLX {get;set;}
		public string HDPH_WDX {get;set;}
		public string HDPH_ZTLX {get;set;}
		public string HDPH_ZKHJ {get;set;}
		public string HDPH_TTLX {get;set;}
		public Nullable<double> HDPH_TTCD {get;set;}
		public string HDPH_REM {get;set;}
		public string HDPH_DESC {get;set;}
		public string ORGA_ID {get;set;}
		public string HDPH_HTFF {get;set;}
		public string HDPH_HTCL {get;set;}
		public string HDPH_YYBZ {get;set;}
		public string FILE_FSET {get;set;}
	}
}