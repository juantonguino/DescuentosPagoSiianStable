using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class TipoDocumentoViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[StringLength(4,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="codigo")]
		public  string Codigo { get; set; } 

		[StringLength(200,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombre")]
		public  string Nombre { get; set; } 

		[Display(Name ="esactivo")]
		public  bool? Esactivo { get; set; } 

		[StringLength(10,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="prefijo")]
		public  string Prefijo { get; set; } 

		[Display(Name ="esfacturaventa")]
		public  bool? Esfacturaventa { get; set; } 

		[Display(Name ="esfacturacompra")]
		public  bool? Esfacturacompra { get; set; } 

		[Display(Name ="esegreso")]
		public  bool? Esegreso { get; set; } 

		[Display(Name ="esnotacontable")]
		public  bool? Esnotacontable { get; set; } 

		[Display(Name ="esnotadebito")]
		public  bool? Esnotadebito { get; set; } 

		[Display(Name ="esnotacredito")]
		public  bool? Esnotacredito { get; set; } 

		[StringLength(200,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="resolucion")]
		public  string Resolucion { get; set; } 

		[Display(Name ="numeroinicial")]
		public  int? Numeroinicial { get; set; } 

		[Display(Name ="numerofinal")]
		public  int? Numerofinal { get; set; } 

		[Display(Name ="numeroactual")]
		public  int? Numeroactual { get; set; } 

		[Display(Name ="fecharesolucion")]
		public  DateTime? Fecharesolucion { get; set; } 

		[Display(Name ="fechavencimiento")]
		public  DateTime? Fechavencimiento { get; set; } 

		[Display(Name ="numeroverificador")]
		public  int? Numeroverificador { get; set; } 

		[Display(Name ="esnumeracionautomatica")]
		public  bool? Esnumeracionautomatica { get; set; } 

		public TipoDocumentoViewModel(int p_id, string p_codigo, string p_nombre, bool? p_esactivo, string p_prefijo, bool? p_esfacturaventa, bool? p_esfacturacompra, bool? p_esegreso, bool? p_esnotacontable, bool? p_esnotadebito, bool? p_esnotacredito, string p_resolucion, int? p_numeroinicial, int? p_numerofinal, int? p_numeroactual, DateTime? p_fecharesolucion, DateTime? p_fechavencimiento, int? p_numeroverificador, bool? p_esnumeracionautomatica)		{
			Id = p_id;
			Codigo = p_codigo;
			Nombre = p_nombre;
			Esactivo = p_esactivo;
			Prefijo = p_prefijo;
			Esfacturaventa = p_esfacturaventa;
			Esfacturacompra = p_esfacturacompra;
			Esegreso = p_esegreso;
			Esnotacontable = p_esnotacontable;
			Esnotadebito = p_esnotadebito;
			Esnotacredito = p_esnotacredito;
			Resolucion = p_resolucion;
			Numeroinicial = p_numeroinicial;
			Numerofinal = p_numerofinal;
			Numeroactual = p_numeroactual;
			Fecharesolucion = p_fecharesolucion;
			Fechavencimiento = p_fechavencimiento;
			Numeroverificador = p_numeroverificador;
			Esnumeracionautomatica = p_esnumeracionautomatica;
		}

		public TipoDocumentoViewModel()		{
		}
	}
}
