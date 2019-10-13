using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class MultilibroViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[StringLength(200,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombre")]
		public  string Nombre { get; set; } 

		[Display(Name ="esactivo")]
		public  bool? Esactivo { get; set; } 

		public MultilibroViewModel(int p_id, string p_nombre, bool? p_esactivo)		{
			Id = p_id;
			Nombre = p_nombre;
			Esactivo = p_esactivo;
		}

		public MultilibroViewModel()		{
		}
	}
}
