using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Contabilidad.ViewModels
{
    public class ImpuestoORetencionViewModel
    {
        public int Id;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int EsRetencion { get; set; }
        [Display(Name = "Codigo")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Codigo { get; set; }
        [Display(Name = "Porcentaje")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Porcentaje { get; set; }
        [Display(Name = "Base Impuesto")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BaseImpuesto { get; set; }
        [Display(Name = "Valor")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Valor { get; set; }
        [Display(Name = "Notas")]
        public string Notas { get; set; }
        [Display(Name = "Persona")]
        public int? IdTercero { get; set; }
        [Display(Name = "Multilibro")]
        public int? IdMultilibro { get; set; }
        [Display(Name = "Sucursal")]
        public int? IdSucursal { get; set; }
        [Display(Name = "Unidad de Negocio")]
        public int? IdUnidadNegocio { get; set; }
        [Display(Name = "Centro de Costo")]
        public int? IdCentroCosto { get; set; }
        [Display(Name = "Proyecto")]
        public int? IdProyecto { get; set; }
        [Display(Name = "Control Fiscal")]
        public int? Idcontrolfiscal { get; set; }
        [Display(Name = "Flujo efectivo")]
        public int? Idfe { get; set; }
        [Display(Name = "Doc. Cruce")]
        public string Doccruce { get; set; }
        [StringLength(100, ErrorMessage = "Debe Contener Máximo {1} caracteres")]
        [Display(Name = "Nro. Cruce")]
        public string Nrocruce { get; set; }
        [Display(Name = "Fecha vencimiento")]
        public DateTime? Fechavencimiento { get; set; }
        [Display(Name = "Periodo vencimiento")]
        public int? Periodovencimiento { get; set; }
        [StringLength(200, ErrorMessage = "Debe Contener Maximo {1} caracteres")]
        [Display(Name = "Ref. banco")]
        public string Refbanco { get; set; }
        [Display(Name = "Persona 2")]
        public int? IdTerceroDos { get; set;}

        public ImpuestoORetencionViewModel() { }

        public ImpuestoORetencionViewModel(int esRetencion, string codigo, decimal? porcentaje, decimal? baseImpuesto, decimal? valor, string notas, int? idTercero, int? idMultilibro, int? idSucursal, int? idUnidadNegocio, int? idCentroCosto, int? idProyecto, int? idcontrolfiscal, int? idfe, string doccruce, string nrocruce, DateTime? fechavencimiento, int? periodovencimiento, string refbanco, int? idTerceroDos)
        {
            EsRetencion = esRetencion;
            Codigo = codigo;
            Porcentaje = porcentaje;
            BaseImpuesto = baseImpuesto;
            Valor = valor;
            Notas = notas;
            IdTercero = idTercero;
            IdMultilibro = idMultilibro;
            IdSucursal = idSucursal;
            IdUnidadNegocio = idUnidadNegocio;
            IdCentroCosto = idCentroCosto;
            IdProyecto = idProyecto;
            Idcontrolfiscal = idcontrolfiscal;
            Idfe = idfe;
            Doccruce = doccruce;
            Nrocruce = nrocruce;
            Fechavencimiento = fechavencimiento;
            Periodovencimiento = periodovencimiento;
            Refbanco = refbanco;
            IdTerceroDos = idTerceroDos;
        }
    }
}
