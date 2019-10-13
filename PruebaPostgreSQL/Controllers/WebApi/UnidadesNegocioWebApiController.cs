
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
	public class UnidadesNegocioWebApiController : ApiController	{

		[HttpGet]
		public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
		{
			
			List<UnidadesNegocioViewModel> listaUnidadesNegocioViewModel = 
                Enumerable.Range(1,100).Select(x=>new UnidadesNegocioViewModel {Id=x,Codigo=x.ToString(),Nombre="Unidad "+x }).ToList();
			loadOptions.Take = 0;
			loadOptions.Skip = 0;
			var ds = DataSourceLoader.Load(listaUnidadesNegocioViewModel, loadOptions);
            
			return Request.CreateResponse(ds);
        }



	}
}
