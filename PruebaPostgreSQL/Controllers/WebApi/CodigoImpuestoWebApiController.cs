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
    public class CodigoImpuestoWebApiController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            List<CodigoImpuestoViewModel> listaSucursalViewModel = Enumerable.Range(0, 100).Select(x => new CodigoImpuestoViewModel
            {
                Id = 1,
                Nombre = "Codigo" + x,
                Codigo = x.ToString()
            }).ToList();
            return Request.CreateResponse(DataSourceLoader.Load(listaSucursalViewModel, loadOptions));
        }
    }
}
