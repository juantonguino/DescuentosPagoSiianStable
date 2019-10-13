using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class AuxiliaresCentroCostosViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[Display(Name ="idmayor")]
		public  int? Idmayor { get; set; } 

		[StringLength(200,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="nombre")]
		public  string Nombre { get; set; } 

		[Display(Name ="esactivo")]
		public  bool? Esactivo { get; set; } 

		[StringLength(20,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="codigo")]
		public  string Codigo { get; set; } 

		public AuxiliaresCentroCostosViewModel(int p_id, int? p_idmayor, string p_nombre, bool? p_esactivo, string p_codigo)		{
			Id = p_id;
			Idmayor = p_idmayor;
			Nombre = p_nombre;
			Esactivo = p_esactivo;
			Codigo = p_codigo;
		}

		public AuxiliaresCentroCostosViewModel()		{
		}
	}
}
