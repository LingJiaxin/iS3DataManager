using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_GRIS")]
	public class GRIS:DGObject
 	{ 
		public string GRIS_ID {get;set;}
		public string GRIS_PJIS {get;set;}
		public string GRIS_LRFD {get;set;}
		public string GRIS_RPMD {get;set;}
		public string GRIS_MILE {get;set;}
		public string GRIS_STPN {get;set;}
		public string GRID_EDPN {get;set;}
	}
}