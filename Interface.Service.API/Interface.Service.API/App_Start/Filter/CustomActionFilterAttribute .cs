using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Interface.Service.API.App_Start.Filter
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            //if (!actionContext.ModelState.IsValid)
            if(true)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.BadRequest, actionContext.ModelState);
            }
        }
    }
}