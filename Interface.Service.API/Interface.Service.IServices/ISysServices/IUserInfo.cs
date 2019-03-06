using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Service.IServices.ISysServices
{
    public interface IUserInfo
    {
        Guid UserId { get; }
        Guid EnterpriseId { get; }
        Guid ProjectId { get; }
    }
}
