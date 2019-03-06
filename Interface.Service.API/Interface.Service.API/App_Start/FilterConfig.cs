using Interface.Service.API.App_Start.Filter;
using System.Web;
using System.Web.Mvc;

namespace Interface.Service.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

           
        }
    }
}