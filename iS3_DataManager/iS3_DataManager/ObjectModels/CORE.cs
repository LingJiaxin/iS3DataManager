using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_CORE")]
	public class CORE
 	{ 
		public string LOCA_ID {get;set;}
		public string HDPH_ID {get;set;}
		public Nullable<double> CORE_TOP {get;set;}
		public Nullable<double> CORE_BASE {get;set;}
		public Nullable<int> CORE_PREC {get;set;}
		public Nullable<int> CORE_SREC {get;set;}
		public Nullable<int> CORE_RQD {get;set;}
		public Nullable<int> CORE_DIAM {get;set;}
		public string CORE_DURN {get;set;}
		public string CORE_DESC {get;set;}
		public string CORE_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}