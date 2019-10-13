using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class ClasificacionTributariaViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[StringLength(20,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="codigo")]
		public  string Codigo { get; set; } 

		[StringLength(200,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="descripcion")]
		public  string Descripcion { get; set; } 

		[Display(Name ="idclasetributo")]
		public  int Idclasetributo { get; set; } 

		[Display(Name ="idtributo")]
		public  int Idtributo { get; set; } 

		[Display(Name ="idnaturalezatributaria")]
		public  int Idnaturalezatributaria { get; set; } 

		[Display(Name ="esactivo")]
		public  bool Esactivo { get; set; } 

		public ClasificacionTributariaViewModel(int p_id, string p_codigo, string p_descripcion, int p_idclasetributo, int p_idtributo, int p_idnaturalezatributaria, bool p_esactivo)		{
			Id = p_id;
			Codigo = p_codigo;
			Descripcion = p_descripcion;
			Idclasetributo = p_idclasetributo;
			Idtributo = p_idtributo;
			Idnaturalezatributaria = p_idnaturalezatributaria;
			Esactivo = p_esactivo;
		}

		public ClasificacionTributariaViewModel()		{
		}
	}
}
