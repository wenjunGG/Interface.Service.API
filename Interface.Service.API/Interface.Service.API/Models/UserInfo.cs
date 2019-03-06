using Interface.Service.IServices.ISysServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interface.Service.API.Models
{
    public class UserInfo:IUserInfo
    {

        public Guid UserId { get; set; }

        public Guid EnterpriseId { get; set; }

        public Guid ProjectId { get; set; }
    }
}