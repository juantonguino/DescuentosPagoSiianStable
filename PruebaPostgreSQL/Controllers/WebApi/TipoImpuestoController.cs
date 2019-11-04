using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using PruebaPostgreSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PruebaPostgreSQL.Controllers.WebApi
{
    public class TipoImpuestoWebApiController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            List<TipoImpuestoVewModel> listaSucursalViewModel = new List<TipoImpuestoVewModel> {
                new TipoImpuestoVewModel{
                    Id=1,
                    Nombre="Impuesto"
                },
                new TipoImpuestoVewModel{ 
                    Id=2,
                    Nombre="Retencion"
                }
            };
            return Request.CreateResponse(DataSourceLoader.Load(listaSucursalViewModel, loadOptions));
        }
    }
}