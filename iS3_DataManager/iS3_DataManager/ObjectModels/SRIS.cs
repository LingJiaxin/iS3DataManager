using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_SRIS")]
	public class SRIS:DGObject
 	{ 
		public string SRIS_ID {get;set;}
		public string SRIS_MILE {get;set;}
		public string SRIS_QSZH {get;set;}
		public string SRIS_ZZZH {get;set;}
		public Nullable<double> SRIS_LGTH {get;set;}
		public string SRIS_SRLV {get;set;}
		public string SRIS_RCLV {get;set;}
		public string SRIS_SAEC {get;set;}
		public string SRIS_UWCF {get;set;}
		public string SRIS_WFCF {get;set;}
		public string SRIS_ISCF {get;set;}
		public string SRIS_BQ1 {get;set;}
		public string SRIS_BQ2 {get;set;}
	}
}