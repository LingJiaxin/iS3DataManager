using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_TWIS")]
	public class TWIS:DGObject
 	{ 
		public string TWIS_ID {get;set;}
		public string PEOP_ID {get;set;}
		public string TWIS_MILE {get;set;}
		public Nullable<double> TWIS_SMIL {get;set;}
		public Nullable<double> TWIS_EMIL {get;set;}
		public string TWIS_TIME {get;set;}
		public string TWIS_MEAM {get;set;}
		public string TWIS_MEAI {get;set;}
		public Nullable<double> TWIS_AWI {get;set;}
		public string TWIS_ACME {get;set;}
		public string TWIS_REM {get;set;}
		public string FILE_FSET {get;set;}
	}
}