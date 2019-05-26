using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_AD")]
	public class AD:DGObject
 	{ 
		public string LOCA_ID {get;set;}
		public string HDPH_ID {get;set;}
		public string GCS_CHAI {get;set;}
		public Nullable<double> DETL_TOP {get;set;}
		public string DETL_GEO1 {get;set;}
		public string DETL_GEO2 {get;set;}
		public Nullable<double> DETL_RQD {get;set;}
		public Nullable<double> DETL_BEAR {get;set;}
		public Nullable<double> DETL_FRIC {get;set;}
		public Nullable<double> DETL_BLOW {get;set;}
		public Nullable<double> DETL_DBLOW {get;set;}
		public string DETL_DESC {get;set;}
		public string DETL_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}