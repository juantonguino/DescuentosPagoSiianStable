using Entities.Contabilidad.ViewModels;
using Entities.Generales.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Xml;

namespace PruebaPostgreSQL.Controllers.WebApi
{
    public class UtilsWebApiController : ApiController
{
        [System.Web.Mvc.HttpGet]
        public HttpResponseMessage getListSucursalMultilibro()
        {
            List<MultilibroViewModel> arrayMultilibro = new List<MultilibroViewModel>
            {
                new MultilibroViewModel{
                    Id=1,
                    Esactivo=true,
                    Nombre="Temp"
                }
            };

            List<SucursalViewModel> arraySucursal = new List<SucursalViewModel>
            {
                new SucursalViewModel{
                    Nombre= "Sucursal1",
                    Codigo="1",
                    Esactivo= true,
                    Idcompania=2,
                    Id=1
                }
            };

            var retorno = new List<Object> {
                arrayMultilibro,
                arraySucursal
            };
            return Request.CreateResponse(HttpStatusCode.OK, retorno);
        }
    }
}
