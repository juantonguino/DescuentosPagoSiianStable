using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaPostgreSQL.Models
{
    public class CodigoImpuestoViewModel
    {
        [Display(Name = "id")]
        public int Id { get; set; }

        [StringLength(4, ErrorMessage = "Debe Contener Maximo {1} caracteres")]
        [Display(Name = "codigo")]
        public string Codigo { get; set; }

        [StringLength(200, ErrorMessage = "Debe Contener Maximo {1} caracteres")]
        [Display(Name = "nombre")]
        public string Nombre { get; set; }

        [Display(Name = "esactivo")]
        public bool? Esactivo { get; set; }

        [Display(Name = "idcompania")]
        public int Idcompania { get; set; }

        public CodigoImpuestoViewModel(int p_id, string p_codigo, string p_nombre, bool? p_esactivo, int p_idcompania)
        {
            Id = p_id;
            Codigo = p_codigo;
            Nombre = p_nombre;
            Esactivo = p_esactivo;
            Idcompania = p_idcompania;
        }

        public CodigoImpuestoViewModel()
        {
        }
    }
}