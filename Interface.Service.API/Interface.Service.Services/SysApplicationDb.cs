using Interface.Service.Model.SysModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Service.Services
{
    public abstract class SysApplicationDb : DbContext
    {
        protected SysApplicationDb(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        #region 系统信息
        //用户
        public DbSet<SysUser> SysUsers { get; set; }

        #endregion


    }
}
