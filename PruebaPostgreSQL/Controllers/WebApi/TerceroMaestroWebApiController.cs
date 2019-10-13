
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Entities.Terceros.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;


namespace PruebaPostgreSQL.Controllers
{
    public class TerceroMaestroWebApiController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            List<TerceroMaestroViewModel> listaTerceros = Enumerable.Range(1, 100).Select(x => new TerceroMaestroViewModel { Id = x, Nombreunido = "Nombre" + x, Identificacion = x.ToString() })
                .ToList();
            loadOptions.Take = 0;
            loadOptions.Skip = 0;
            return Request.CreateResponse(DataSourceLoader.Load(listaTerceros, loadOptions));
        }


        

    }

}
