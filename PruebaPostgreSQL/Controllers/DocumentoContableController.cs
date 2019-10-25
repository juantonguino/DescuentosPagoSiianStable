
using Entities.Contabilidad.ViewModels;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Transactions;
using System.Web;
using System.Web.Mvc;

namespace PruebaPostgreSQL.Controllers.Contabilidad
{
    
    public class DocumentoContableController : Controller
    {

        [HttpPost]
        public ActionResult Create(DocumentoContableParaGuardarViewModel view)
        {
            return View(view);
        }
        public ActionResult Create()
        {
            var temp = new DocumentoContableParaGuardarViewModel();
            temp.ListaAuxiliarContable.Add(new AuxiliarContableViewModel()
            {
                Id = 1,
                IdAdicional = 1,
                Idauxiliar = 1,
                Idauxiliarcontableorigen = 1,
                Idccostos = 1,
                Idcontrolfiscal = 1,
                Iddocumento = 1,
                Idfe = 1,
                Idmultilibro = 1,
                Idpresupuesto = 1,
                Idproyecto = 1,
                Idsucursal = 1,
                Idtercero = 1,
                IdTerceroDos = 1,
                Idunidadnegocio = 1,
                Valor = 123,
                ListaImpuestos = new List<ImpuestoORetencionViewModel>() { 
                    new ImpuestoORetencionViewModel() {
                    Id = 0,
                    Idfe=0,
                    IdSucursal=0,
                    IdUnidadNegocio=0,
                    IdProyecto=0,
                    IdCentroCosto=0,
                    Idcontrolfiscal=0,
                    IdMultilibro=0,
                    IdTercero=0,
                    IdTerceroDos=0
                    }
                }
            });
            return View("Create", temp);
            //return View( new DocumentoContableParaGuardarViewModel());
        }
        [HttpPost]
        public ActionResult Editar(DocumentoContableParaGuardarViewModel view)
        {
            return View("Create", view);
        }

        public ActionResult search()
        {
            return View("Create", new DocumentoContableParaGuardarViewModel());
        }
    }
}