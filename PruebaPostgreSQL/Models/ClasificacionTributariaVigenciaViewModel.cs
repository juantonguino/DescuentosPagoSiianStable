using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class ClasificacionTributariaVigenciaViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[Display(Name ="idclasificaciontributaria")]
		public  int Idclasificaciontributaria { get; set; } 

		[Display(Name ="fechainicio")]
		public  DateTime Fechainicio { get; set; } 

		[Display(Name ="fechavencimiento")]
		public  DateTime Fechavencimiento { get; set; } 

		[Display(Name ="idauxiliar")]
		public  int Idauxiliar { get; set; } 

		[Display(Name ="idauxiliardevolucion")]
		public  int Idauxiliardevolucion { get; set; } 

		[Display(Name ="idauxiliarasumida")]
		public  int? Idauxiliarasumida { get; set; } 

		[Display(Name ="porcentaje")]
		public  decimal Porcentaje { get; set; } 

		[Display(Name ="esactivo")]
		public  bool Esactivo { get; set; } 

		public ClasificacionTributariaVigenciaViewModel(int p_id, int p_idclasificaciontributaria, DateTime p_fechainicio, DateTime p_fechavencimiento, int p_idauxiliar, int p_idauxiliardevolucion, int? p_idauxiliarasumida, decimal p_porcentaje, bool p_esactivo)		{
			Id = p_id;
			Idclasificaciontributaria = p_idclasificaciontributaria;
			Fechainicio = p_fechainicio;
			Fechavencimiento = p_fechavencimiento;
			Idauxiliar = p_idauxiliar;
			Idauxiliardevolucion = p_idauxiliardevolucion;
			Idauxiliarasumida = p_idauxiliarasumida;
			Porcentaje = p_porcentaje;
			Esactivo = p_esactivo;
		}

		public ClasificacionTributariaVigenciaViewModel()		{
		}
	}
}
