
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
	public class EstadoContableWebApiController : ApiController	{

		[HttpGet]
		public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
		{
			List<EstadoContableViewModel> listaEstadoContableViewModel = 
                Enumerable.Range(1,4).Select(x=>new EstadoContableViewModel {Id=x,Nombre="Estado"+x }).ToList();
			return Request.CreateResponse(DataSourceLoader.Load(listaEstadoContableViewModel, loadOptions));
		}


	}
}
