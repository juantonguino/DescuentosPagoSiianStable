using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class UnidadesNegocioViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[StringLength(4,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="codigo")]
		public  string Codigo { get; set; } 

		[StringLength(100,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombre")]
		public  string Nombre { get; set; } 

		[Display(Name ="esactivo")]
		public  bool? Esactivo { get; set; } 

		public UnidadesNegocioViewModel(int p_id, string p_codigo, string p_nombre, bool? p_esactivo)		{
			Id = p_id;
			Codigo = p_codigo;
			Nombre = p_nombre;
			Esactivo = p_esactivo;
		}

		public UnidadesNegocioViewModel()		{
		}
	}
}
