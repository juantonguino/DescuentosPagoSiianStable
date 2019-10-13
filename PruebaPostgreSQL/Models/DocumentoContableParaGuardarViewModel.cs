using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Entities.Contabilidad.ViewModels
{
	public class DocumentoContableParaGuardarViewModel
	{

        public int Id { get; set; }
        [DisplayName("Tipo Documento")]
        public int Idtipodocumento { get; set; }
        [DisplayName("Sucursal")]
        public int Idsucursal { get; set; }
        public int Estado { get; set; }
        [DisplayName("Número Documento")]
        public int Nrodocumento { get; set; }
        [DisplayName("Fecha Documento")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime? Fechadocumento { get; set; }
        [DisplayName("Fecha Contabilización")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime? Fechacontabilizacion { get; set; }
        public DateTime? Fechafinalizacion { get; set; }
        public int Compania { get; set; }
        public int Periodo { get; set; }
        public bool? EstaActivo { get; set; }
        [DisplayName("Centro de Costos")]
        public int IdCentroCosto { get; set; }
        [DisplayName("Unidad de Negocio")]
        public int IdUnidadNegocio { get; set; }        
        [Required]
        [DisplayName("Tercero")]
        public int IdTercero { get; set; }
        [DisplayName("Nota")]
        public string Notas { get; set; }
        public List<string> Error { get; set; }
        public int IdMultilibro { get; set; }
        [DisplayName("Moneda")]
        public int IdMoneda { get; set; }
        [DisplayName("TRM")]
        public decimal Trm { get; set; }
        public string Operacion { get; set; }
        public bool IsCuadrado { get; set; }
        public List<AuxiliarContableViewModel> ListaAuxiliarContable { get; set; }

        //Campos Agresgados

        [DisplayName("Documentos De Referencia")]
        public int? DocumentosRefencia { get; set; }

        [DisplayName("Documentos Que Referencian")]
        public int? DocumentosQueReferencian { get; set; }

        //fin de Campos agregados

        public bool? Esactivo { get; set; }

        public DocumentoContableParaGuardarViewModel()
        {
            Error = new List<string>();
            ListaAuxiliarContable = new List<AuxiliarContableViewModel>();
        }
        public DocumentoContableParaGuardarViewModel(int p_id, int p_idtipodocumento, int p_idsucursal, int p_estado, int p_nrodocumento, DateTime? p_fechadocumento, DateTime? p_fechacontabilizacion, DateTime? p_fechafinalizacion, int p_compania, int p_periodo, bool? p_esactivo, string p_notas)
        {
            Id = p_id;
            Idtipodocumento = p_idtipodocumento;
            Idsucursal = p_idsucursal;
            Estado = p_estado;
            Nrodocumento = p_nrodocumento;
            Fechadocumento = p_fechadocumento;
            Fechacontabilizacion = p_fechacontabilizacion;
            Fechafinalizacion = p_fechafinalizacion;
            Compania = p_compania;
            Periodo = p_periodo;
            Esactivo = p_esactivo;
            Notas = p_notas;
            ListaAuxiliarContable = new List<AuxiliarContableViewModel>();
        }
    }
}
