using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Entities.Contabilidad.ViewModels;

namespace PruebaPostgreSQL.Controllers.WebApi
{
    public class ImpuestoORetencionWebApiController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage getImpuestoORetenciones( object id, DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(GetListImpuestos(id), loadOptions));
        }

        //id auxiliar contable
        public List<ImpuestoORetencionViewModel> GetListImpuestos( int id)
        {

            //implementar busqioda aqui
            //return null;
            return new List<ImpuestoORetencionViewModel>() { new ImpuestoORetencionViewModel {
                BaseImpuesto=0,
                Codigo="000",
                Doccruce="000",
                Idcontrolfiscal=0,
                EsRetencion= false,
                Fechavencimiento =DateTime.Now,
                IdCentroCosto=0,
                Idfe=0,
                IdNultilibro=0,
                IdProyecto=0,
                IdSucursal=0,
                IdTercero=0,
                IdTerceroDos=0,
                IdUnidadNegocio=0,
                Notas="asdfa",
                Nrocruce="1234",
                Periodovencimiento=0,
                Porcentaje=0,
                Refbanco="0",
                Valor=2342
            } };
        }
    }
}
