using Interface.Service.API.App_Start.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Interface.Service.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //注册登陆权限
            config.Filters.Add(new AuthFilterAttribute());
            //自定义拦截器
            config.Filters.Add(new CustomActionFilterAttribute());
            //错误拦截器
            config.Filters.Add(new ExceptionFilter());

            // Web API 路由
            config.MapHttpAttributeRoutes();


        }
    }
}
