
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
	public class ControlFiscalWebApiController : ApiController	{

		[HttpGet]
		public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
		{
            List<ControlFiscalViewModel> listaControlFiscalViewModel = Enumerable.Range(1, 2).Select(x => new ControlFiscalViewModel {Id=x,Nombre="Control "+x }).ToList();
			return Request.CreateResponse(DataSourceLoader.Load(listaControlFiscalViewModel, loadOptions));
		}


	}
}
