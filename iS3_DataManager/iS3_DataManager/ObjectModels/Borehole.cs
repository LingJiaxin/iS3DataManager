using System; 
 namespace iS3_DataManager.ObjectModels
 { 
 	public class Borehole
 	{ 
		public Nullable<int> Id {get;set;}
		public String Boreholeid {get;set;}
		public Nullable<DateTime> Boreholetime {get;set;}
		public Nullable<Double> Boreholedepth {get;set;}
	}
}