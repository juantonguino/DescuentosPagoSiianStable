using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Terceros.ViewModels
{
	public class TerceroMaestroViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[Display(Name ="idtipoidentificacion")]
		public  int Idtipoidentificacion { get; set; } 

		[StringLength(40,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="identificacion")]
		public  string Identificacion { get; set; } 

		
		[StringLength(300,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombreunido")]
		public  string Nombreunido { get; set; } 

		public TerceroMaestroViewModel(int p_id, int p_idtipoidentificacion, string p_identificacion, string p_nombreunido)		{
			Id = p_id;
			Idtipoidentificacion = p_idtipoidentificacion;
			Identificacion = p_identificacion;
		
			Nombreunido = p_nombreunido;
		}

		public TerceroMaestroViewModel()		{
		}
	}
}
