
using Entities.Contabilidad.ViewModels;
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
	public class MultilibroWebApiController : ApiController	{

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            List<MultilibroViewModel> multiLibro = Enumerable.Range(1, 4).Select(x => new MultilibroViewModel { Id = x, Nombre = "Mutilibro " + x }).ToList();
            
            return Request.CreateResponse(DataSourceLoader.Load(multiLibro, loadOptions));
        }

	}
}
