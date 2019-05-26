using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_EPY")]
	public class EPY:DGObject
 	{ 
		public string EP_CHAI {get;set;}
		public Nullable<double> EP_RCSW {get;set;}
		public Nullable<double> EP_XSS {get;set;}
		public string EP_EH {get;set;}
		public string EP_EW {get;set;}
		public string EP_CYCF {get;set;}
	}
}