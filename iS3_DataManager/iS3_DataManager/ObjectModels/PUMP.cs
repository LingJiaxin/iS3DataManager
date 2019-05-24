using System; 
using System.ComponentModel.DataAnnotations.Schema;
namespace iS3_DataManager.ObjectModels
 { 
 	[Table("Geology_PUMP")]
	public class PUMP
 	{ 
		public string PROJ_ID {get;set;}
		public string LOCA_ID {get;set;}
		public string HYDW_ID {get;set;}
		public string ORGA_ID {get;set;}
		public string PUMP_DATE {get;set;}
		public string PEOP_ID {get;set;}
		public string PUMP_EQUP {get;set;}
		public string PUMP_CRED {get;set;}
		public string FILE_FSET {get;set;}
		public string PUMP_TESN {get;set;}
		public string PUMP_METH {get;set;}
		public Nullable<double> PUMP_DPTH {get;set;}
		public string PUMP_STAT {get;set;}
		public string STRA_ID {get;set;}
		public string PUMP_DESC {get;set;}
		public Nullable<double> PUMP_PUWL {get;set;}
		public Nullable<double> PUMP_STWL {get;set;}
		public Nullable<double> PUMP_PUMC {get;set;}
		public Nullable<double> PUMP_SPEY {get;set;}
		public Nullable<double> PUMP_AQUT {get;set;}
		public Nullable<double> PUMP_HYDD {get;set;}
		public string PUMP_DEPO {get;set;}
		public Nullable<double> PUMP_MABD {get;set;}
		public string PUMP_CDHN {get;set;}
		public Nullable<double> PUMP_INFR {get;set;}
		public Nullable<double> PUMP_WATI {get;set;}
		public Nullable<double> PUMP_PERC {get;set;}
		public Nullable<double> PUMP_WACC {get;set;}
		public Nullable<double> PUMP_WASC {get;set;}
		public string PUMP_REM {get;set;}
	}
}