using Autofac;
using Autofac.Integration.WebApi;
using Interface.Service.API.Models;
using Interface.Service.IServices.ISysServices;
using Interface.Service.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Interface.Service.API
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            HttpConfiguration config = GlobalConfiguration.Configuration;

            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.Load("Interface.Service.Services"))
               .Where(t => t.Name.EndsWith("Services"))
               .AsImplementedInterfaces();

            //builder.RegisterType(Assembly.Load("Interface.Service.Services").GetType()).W.AsImplementedInterfaces();

            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            builder.RegisterType<DatabaseFactory>().As<IDatabaseFactory>().InstancePerLifetimeScope();

            builder.RegisterType<UserInfo>().As<IUserInfo>();

            //builder.RegisterType<Services.SysServices.MessageQueue>().As<IMessageQueue>();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
         
           // builder.RegisterType<OnTimedEvent>().As<IOnTimedEvent>();
            //builder.RegisterHubs(Assembly.GetExecutingAssembly());

            //builder.RegisterType<ChatHub>().ExternallyOwned();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new Autofac.Integration.Mvc.AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();

            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}