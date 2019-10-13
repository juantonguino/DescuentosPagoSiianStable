using DevExpress.Web.Mvc;

using Entities.Generales.ViewModels;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;


namespace PruebaPostgreSQL.Controllers.WebApi
{
	public class SucursalWebApiController : ApiController	{

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            List<SucursalViewModel> listaSucursalViewModel = Enumerable.Range(0, 100).Select(x => new SucursalViewModel
            {
                Id = 1,
                Nombre = "Sucursal" + x,
                Codigo = x.ToString()
            }).ToList();
            return Request.CreateResponse(DataSourceLoader.Load(listaSucursalViewModel, loadOptions));
        }

       
    }
}
