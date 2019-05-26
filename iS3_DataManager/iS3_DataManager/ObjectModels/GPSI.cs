using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_GPSI")]
	public class GPSI:DGObject
 	{ 
		public string GPSI_ID {get;set;}
		public string GPSI_MILE {get;set;}
		public Nullable<double> GPSI_SMIL {get;set;}
		public Nullable<double> GPSI_EMIL {get;set;}
		public string GPSI_TIME {get;set;}
		public string GPSI_RISC {get;set;}
		public string GPSI_GEOL {get;set;}
		public string GPSI_SRG {get;set;}
		public string GPSI_FORC {get;set;}
		public string GPSI_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}