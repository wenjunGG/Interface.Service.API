using Interface.Service.API.App_Start.Filter;
using Interface.Service.API.Models.Sys;
using Interface.Service.IServices.ISysServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;




namespace Interface.Service.API.Areas.Sys.Controllers
{
    [RoutePrefix("user")]
    [AuthFilter] //登陆
    [CustomActionFilter] //自定义
    [ExceptionFilter]
    public class UserInfoController : ApiController
    {
        // GET: Sys/UserInfo

        private readonly ISysUserInfoServices _ISysUserInfoServices;

        public UserInfoController(ISysUserInfoServices iSysUserInfoServices)
        {
            _ISysUserInfoServices = iSysUserInfoServices;
        }

        [HttpGet]
        [Route("TestGet")]
        [AllowAnonymous]//可以匿名访问
        public string TestGet()
        {
            var listUser = _ISysUserInfoServices.GetAllWithProject().ToList();
            return "ok";
        }

        [HttpPost]
        [Route("Test")]
        //[AllowAnonymous]//可以匿名访问
        public string Test(string DataType, [FromBody]Test value)
        {
            var listUser = _ISysUserInfoServices.GetAllWithProject().ToList();
            return "ok";
        }
    }
}