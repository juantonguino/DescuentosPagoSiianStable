using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class MonedaViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[StringLength(3,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="sigla")]
		public  string Sigla { get; set; } 

		[StringLength(300,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombre")]
		public  string Nombre { get; set; } 

		[StringLength(3,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="simbolo")]
		public  string Simbolo { get; set; } 

		[Display(Name ="esactivo")]
		public  bool? Esactivo { get; set; } 

		public MonedaViewModel(int p_id, string p_sigla, string p_nombre, string p_simbolo, bool? p_esactivo)		{
			Id = p_id;
			Sigla = p_sigla;
			Nombre = p_nombre;
			Simbolo = p_simbolo;
			Esactivo = p_esactivo;
		}

		public MonedaViewModel()		{
		}
	}
}
