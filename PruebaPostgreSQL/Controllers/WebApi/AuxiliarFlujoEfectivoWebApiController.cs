
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
	public class AuxiliarFlujoEfectivoWebApiController : ApiController	{

		[HttpGet]
		public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
		{
			List<AuxiliarFlujoEfectivoViewModel> listaAuxiliarFlujoEfectivoViewModel = 
                Enumerable.Range(1,100).Select(x=>new AuxiliarFlujoEfectivoViewModel { Codigo=x.ToString(),Nombre="Flujo "+x,Id=x}).ToList();
			return Request.CreateResponse(DataSourceLoader.Load(listaAuxiliarFlujoEfectivoViewModel, loadOptions));
		}


		
	}
}
