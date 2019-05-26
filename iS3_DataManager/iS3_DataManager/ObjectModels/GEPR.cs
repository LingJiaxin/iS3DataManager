using System; 
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core.Model;

namespace iS3.Geology.Model
 { 
 	[Table("Geology_GEPR")]
	public class GEPR:DGObject
 	{ 
		public string GEPR_ID {get;set;}
		public string GEPR_DEVN {get;set;}
		public Nullable<int> GEPR_NOEH {get;set;}
		public Nullable<double> GEPR_ADEH {get;set;}
		public Nullable<double> GEPR_ADEH2 {get;set;}
		public Nullable<double> GEPR_AHEH {get;set;}
		public Nullable<double> GEPR_SPEH {get;set;}
		public Nullable<int> GEPR_NORH {get;set;}
		public Nullable<double> GEPR_ADRH {get;set;}
		public Nullable<double> GEPR_ADRH2 {get;set;}
		public Nullable<double> GEPR_AHRH {get;set;}
		public string GEPR_DETN {get;set;}
		public string GEPR_DESN {get;set;}
		public string GEPR_WAVP {get;set;}
		public Nullable<double> GEPR_DEMV {get;set;}
		public Nullable<double> GEPR_SPED {get;set;}
		public Nullable<double> GEPR_VPVS {get;set;}
		public Nullable<double> GEPR_POIS {get;set;}
		public Nullable<double> GEPR_DENS {get;set;}
		public string FILE_FSET {get;set;}
		public Nullable<int> GEPR_NOSR {get;set;}
		public Nullable<int> GEPR_NOMP {get;set;}
		public string GEPR_RECM {get;set;}
		public Nullable<int> GEPR_MENL {get;set;}
		public string GEPR_MEPN {get;set;}
		public Nullable<double> GEPR_DFTV {get;set;}
		public Nullable<double> GEPR_DFTL {get;set;}
		public Nullable<int> GEPR_NUML {get;set;}
		public string GEPR_LINN {get;set;}
		public string GEPR_EQUM {get;set;}
		public Nullable<int> GEPR_ANOF {get;set;}
		public string GEPR_LINN2 {get;set;}
		public string GEPR_SPCX {get;set;}
		public string GEPR_SPCY {get;set;}
		public string GEPR_EPCX {get;set;}
		public string GEPR_EPCY {get;set;}
		public Nullable<int> GEPR_NPSE {get;set;}
		public Nullable<int> GEPR_MNEP {get;set;}
		public Nullable<int> GEPR_SUPV {get;set;}
		public Nullable<int> GEPR_SUPC {get;set;}
		public string GEPR_ELEN {get;set;}
		public string GEPR_TYPE {get;set;}
		public Nullable<double> GEPR_DFTF {get;set;}
		public string GEPR_ACDT {get;set;}
		public Nullable<double> GEPR_LFLM {get;set;}
		public Nullable<double> GEPR_LAFL {get;set;}
		public Nullable<double> GEPR_EMFW {get;set;}
		public Nullable<int> GEPR_EXCT {get;set;}
		public Nullable<double> GEPR_REFL {get;set;}
		public Nullable<double> GEPR_REFW {get;set;}
		public Nullable<int> GEPR_REFN {get;set;}
		public Nullable<double> GEPR_RCEA {get;set;}
		public Nullable<double> GEPR_TRAD {get;set;}
		public Nullable<int> GEPR_TRAF {get;set;}
		public Nullable<int> GEPR_MEAT {get;set;}
		public Nullable<double> GEPR_BLIZ {get;set;}
		public string GEPR_LILD {get;set;}
	}
}