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
	public class AuxiliaresWebApiController : ApiController	{

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            List<AuxiliaresViewModel> listaAuxiliaresViewModel = new List<AuxiliaresViewModel>();
            listaAuxiliaresViewModel.Add(new AuxiliaresViewModel {Id=1,Codigo="1105"  });
            return Request.CreateResponse(DataSourceLoader.Load(listaAuxiliaresViewModel, loadOptions));
        }

        

	}
}
