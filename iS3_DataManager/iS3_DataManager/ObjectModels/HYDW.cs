using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_HYDW")]
	public class HYDW:DGObject
 	{ 
		public string LOCA_ID {get;set;}
		public string HYDW_ID {get;set;}
		public string HYDW_TYPE {get;set;}
		public Nullable<double> HYDW_DIAM {get;set;}
		public Nullable<double> HYDW_TOP {get;set;}
		public Nullable<double> HYDW_DEPT {get;set;}
		public string HYDW_STRT {get;set;}
		public string HYDW_ENDT {get;set;}
		public string HYDW_CESC {get;set;}
		public string HYDW_LESC {get;set;}
	}
}