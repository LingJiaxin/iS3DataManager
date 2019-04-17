using System; 
 namespace iS3_DataManager.Models
 { 
 	public class Borehole
 	{ 
		public Nullable<Int> Id {get;set;}
		public Nullable<String> Boreholeid {get;set;}
		public Nullable<Datetime> Boreholetime {get;set;}
		public Nullable<Double> Boreholedepth {get;set;}
	}
}