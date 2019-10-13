using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Contabilidad.ViewModels
{
	public class AuxiliarContableViewModel
	{
		[Display(Name ="id")]
		public  int Id { get; set; } 

		[Display(Name ="Documento")]
		public  int Iddocumento { get; set; } 

		[Display(Name ="Auxiliar")]
		public  int Idauxiliar { get; set; } 

		[Display(Name ="Multilibro")]
		public  int Idmultilibro { get; set; } 

		[Display(Name ="Sucursal")]
		public  int Idsucursal { get; set; } 

		[Display(Name ="Unidad negocio")]
		public  int? Idunidadnegocio { get; set; } 

		[Display(Name ="Centro de costo")]
		public  int? Idccostos { get; set; } 

		[Display(Name ="Flujo efectivo")]
		public  int? Idfe { get; set; } 

		[Display(Name ="Presupuesto")]
		public  int? Idpresupuesto { get; set; } 

		[Display(Name ="Proyecto")]
		public  int? Idproyecto { get; set; } 

		[Display(Name ="Persona")]
		public  int Idtercero { get; set; } 

		[Display(Name ="Valor")]
		public  decimal? Valor { get; set; } 

		[Display(Name ="Es Debito")]
		public  bool Esdebito { get; set; } 

		[Display(Name ="Base gravable")]
		public  decimal? Basegravable { get; set; } 

		[StringLength(300,ErrorMessage ="Debe Contener Máximo {1} caracteres")]
		[Display(Name ="Notas")]
		public  string Notas { get; set; } 

		[StringLength(100,ErrorMessage ="Debe Contener Máximo {1} caracteres")]
		[Display(Name ="Doc. Cruce")]
		public  string Doccruce { get; set; } 

		[StringLength(100,ErrorMessage ="Debe Contener Máximo {1} caracteres")]
		[Display(Name ="Nro. Cruce")]
		public  string Nrocruce { get; set; } 

		[Display(Name ="Fecha vencimiento")]
		public  DateTime? Fechavencimiento { get; set; } 

		[Display(Name ="Periodo vencimiento")]
		public  int? Periodovencimiento { get; set; } 

		[StringLength(200,ErrorMessage ="Debe Contener Maximo {1} caracteres")]
		[Display(Name ="Ref. banco")]
		public  string Refbanco { get; set; } 

		[Display(Name ="Orden")]
		public  int? Orden { get; set; } 

		[Display(Name ="Accesorio")]
		public  int? Accesorio { get; set; } 

		[Display(Name ="Control fiscal")]
		public  int? Idcontrolfiscal { get; set; } 

		[Display(Name ="Auxiliar origen")]
		public  int? Idauxiliarcontableorigen { get; set; }

        public int IdAdicional { get; set; }

        public decimal TotalImpuestos { get; set; }
        public decimal TotalRetenciones { get; set; }

        [Display(Name = "Persona 2")]
        public int? IdTerceroDos { get; set; }

        public decimal ValorAlterno { get; set; }

        public List<ImpuestoORetencionViewModel> ListaImpuestos { get; set; }

        

        public AuxiliarContableViewModel(int p_id, int p_iddocumento, int p_idauxiliar, int p_idmultilibro, int p_idsucursal, int? p_idunidadnegocio, int? p_idccostos, int? p_idfe, int? p_idpresupuesto, int? p_idproyecto, int p_idtercero, decimal? p_valor, bool p_esdebito, decimal? p_basegravable, string p_notas, string p_doccruce, string p_nrocruce, DateTime? p_fechavencimiento, int? p_periodovencimiento, string p_refbanco, int? p_orden, int? p_accesorio, int? p_idcontrolfiscal, int? p_idauxiliarcontableorigen,int p_idadicional,int? p_idtercero2,decimal p_valorAlterno)		{
			Id = p_id;
			Iddocumento = p_iddocumento;
			Idauxiliar = p_idauxiliar;
			Idmultilibro = p_idmultilibro;
			Idsucursal = p_idsucursal;
			Idunidadnegocio = p_idunidadnegocio;
			Idccostos = p_idccostos;
			Idfe = p_idfe;
			Idpresupuesto = p_idpresupuesto;
			Idproyecto = p_idproyecto;
			Idtercero = p_idtercero;
			Valor = p_valor;
			Esdebito = p_esdebito;
			Basegravable = p_basegravable;
			Notas = p_notas;
			Doccruce = p_doccruce;
			Nrocruce = p_nrocruce;
			Fechavencimiento = p_fechavencimiento;
			Periodovencimiento = p_periodovencimiento;
			Refbanco = p_refbanco;
			Orden = p_orden;
			Accesorio = p_accesorio;
			Idcontrolfiscal = p_idcontrolfiscal;
			Idauxiliarcontableorigen = p_idauxiliarcontableorigen;
            ListaImpuestos = new List<ImpuestoORetencionViewModel>();
            IdAdicional = p_idadicional;
            IdTerceroDos = p_idtercero2;
            ValorAlterno = p_valorAlterno;
		}

		public AuxiliarContableViewModel()		{
		}
	}
}
