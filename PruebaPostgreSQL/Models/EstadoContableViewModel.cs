using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class EstadoContableViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[StringLength(200,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombre")]
		public  string Nombre { get; set; } 

		[Display(Name ="esanulado")]
		public  bool? Esanulado { get; set; } 

		[Display(Name ="esaprobado")]
		public  bool? Esaprobado { get; set; } 

		[Display(Name ="esproceso")]
		public  bool? Esproceso { get; set; } 

		[Display(Name ="esedicion")]
		public  bool? Esedicion { get; set; } 

		[Display(Name ="esactivo")]
		public  bool? Esactivo { get; set; } 

		public EstadoContableViewModel(int p_id, string p_nombre, bool? p_esanulado, bool? p_esaprobado, bool? p_esproceso, bool? p_esedicion, bool? p_esactivo)		{
			Id = p_id;
			Nombre = p_nombre;
			Esanulado = p_esanulado;
			Esaprobado = p_esaprobado;
			Esproceso = p_esproceso;
			Esedicion = p_esedicion;
			Esactivo = p_esactivo;
		}

		public EstadoContableViewModel()		{
		}
	}
}
