using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using CoreUser = Core.Entities.Concrete.CoreUser;

namespace Business.Abstract
{
    public interface ICoreUserService
    {
        List<OperationClaim> GetClaims(CoreUser coreUser);
        void Add(CoreUser coreUser);
        CoreUser GetByMail(string email);
    }

}