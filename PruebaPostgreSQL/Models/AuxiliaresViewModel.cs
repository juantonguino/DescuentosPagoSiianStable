using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class AuxiliaresViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[Display(Name ="id_mayor")]
		public  int Id_mayor { get; set; } 

		[StringLength(20,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="codigo")]
		public  string Codigo { get; set; } 

		[StringLength(200,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombre1")]
		public  string Nombre1 { get; set; } 

		[StringLength(200,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombre2")]
		public  string Nombre2 { get; set; } 

		[StringLength(200,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombre3")]
		public  string Nombre3 { get; set; } 

		[Display(Name ="idsucursal")]
		public  int? Idsucursal { get; set; } 

		[Display(Name ="esdebito")]
		public  bool Esdebito { get; set; } 

		[Display(Name ="idmoneda")]
		public  int? Idmoneda { get; set; } 

		[Display(Name ="idtipotercero")]
		public  int Idtipotercero { get; set; } 

		[Display(Name ="iddetelle")]
		public  int Iddetelle { get; set; } 

		[Display(Name ="esdisponible")]
		public  bool Esdisponible { get; set; } 

		[Display(Name ="escaja")]
		public  bool Escaja { get; set; } 

		[Display(Name ="esbanco")]
		public  bool Esbanco { get; set; } 

		[Display(Name ="manejacentrocosto")]
		public  bool Manejacentrocosto { get; set; } 

		[Display(Name ="manejaunidadnegocio")]
		public  bool Manejaunidadnegocio { get; set; } 

		[Display(Name ="manejaproyecto")]
		public  bool Manejaproyecto { get; set; } 

		[Display(Name ="idtipoimpuesto")]
		public  int Idtipoimpuesto { get; set; } 

		[Display(Name ="controlfiscal")]
		public  bool Controlfiscal { get; set; } 

		[Display(Name ="estaactivo")]
		public  bool Estaactivo { get; set; } 

		public AuxiliaresViewModel(int p_id, int p_id_mayor, string p_codigo, string p_nombre1, string p_nombre2, string p_nombre3, int? p_idsucursal, bool p_esdebito, int? p_idmoneda, int p_idtipotercero, int p_iddetelle, bool p_esdisponible, bool p_escaja, bool p_esbanco, bool p_manejacentrocosto, bool p_manejaunidadnegocio, bool p_manejaproyecto, int p_idtipoimpuesto, bool p_controlfiscal, bool p_estaactivo)		{
			Id = p_id;
			Id_mayor = p_id_mayor;
			Codigo = p_codigo;
			Nombre1 = p_nombre1;
			Nombre2 = p_nombre2;
			Nombre3 = p_nombre3;
			Idsucursal = p_idsucursal;
			Esdebito = p_esdebito;
			Idmoneda = p_idmoneda;
			Idtipotercero = p_idtipotercero;
			Iddetelle = p_iddetelle;
			Esdisponible = p_esdisponible;
			Escaja = p_escaja;
			Esbanco = p_esbanco;
			Manejacentrocosto = p_manejacentrocosto;
			Manejaunidadnegocio = p_manejaunidadnegocio;
			Manejaproyecto = p_manejaproyecto;
			Idtipoimpuesto = p_idtipoimpuesto;
			Controlfiscal = p_controlfiscal;
			Estaactivo = p_estaactivo;
		}

		public AuxiliaresViewModel()		{
		}
	}
}
