
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

            return View( new DocumentoContableParaGuardarViewModel());
        }
        [HttpPost]
        public ActionResult Editar()
        {
            
            return View("Create", new DocumentoContableParaGuardarViewModel());
        }

        public ActionResult search()
        {
            return View("Create", new DocumentoContableParaGuardarViewModel());
        }
    }
}