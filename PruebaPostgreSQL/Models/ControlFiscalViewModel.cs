using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class ControlFiscalViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[StringLength(200,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombre")]
		public  string Nombre { get; set; } 

		[Display(Name ="esdeducible")]
		public  bool Esdeducible { get; set; } 

		[Display(Name ="esactivo")]
		public  bool Esactivo { get; set; } 

		public ControlFiscalViewModel(int p_id, string p_nombre, bool p_esdeducible, bool p_esactivo)		{
			Id = p_id;
			Nombre = p_nombre;
			Esdeducible = p_esdeducible;
			Esactivo = p_esactivo;
		}

		public ControlFiscalViewModel()		{
		}
	}
}
