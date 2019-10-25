using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaPostgreSQL.Models
{
    public class CodigoViewModel
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
        public int Idcompania
        {
            get; set;
        }
        public CodigoViewModel() {}
    }
}