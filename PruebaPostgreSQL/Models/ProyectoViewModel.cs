using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class ProyectoViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[StringLength(300,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombre")]
		public  string Nombre { get; set; } 

		[Display(Name ="esactivo")]
		public  bool? Esactivo { get; set; } 

		[StringLength(5,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="codigo")]
		public  string Codigo { get; set; } 

		[Display(Name ="esdetalle")]
		public  bool Esdetalle { get; set; } 

		[Display(Name ="idpadre")]
		public  int? Idpadre { get; set; } 

		public ProyectoViewModel(int p_id, string p_nombre, bool? p_esactivo, string p_codigo, bool p_esdetalle, int? p_idpadre)		{
			Id = p_id;
			Nombre = p_nombre;
			Esactivo = p_esactivo;
			Codigo = p_codigo;
			Esdetalle = p_esdetalle;
			Idpadre = p_idpadre;
		}

		public ProyectoViewModel()		{
		}
	}
}
