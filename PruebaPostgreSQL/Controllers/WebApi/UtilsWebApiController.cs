using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Xml;

namespace PruebaPostgreSQL.Controllers.WebApi
{
    public class UtilsWebApiController : ApiController
{
        [System.Web.Mvc.HttpGet]
        public HttpResponseMessage getListSucursalMultilibro()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "string");
        }
    }
}
