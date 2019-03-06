using Interface.Service.IServices.ISysServices;
using Interface.Service.Model.SysModel;
using Interface.Service.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Service.Services.SysServices
{
    public class SysUserInfoServices : RepositoryBase<SysUser>, ISysUserInfoServices
    {
        private readonly IUserInfo _userInfo;
        public SysUserInfoServices(IDatabaseFactory databaseFactory, IUserInfo userInfo)
            : base(databaseFactory, userInfo)
        {
            _userInfo = userInfo;
        }
    }
}
