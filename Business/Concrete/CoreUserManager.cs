using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using CoreUser = Core.Entities.Concrete.CoreUser;

namespace Business.Concrete
{
    public class CoreUserManager : ICoreUserService
    {
        ICoreUserDal _coreUserDal;

        public CoreUserManager(ICoreUserDal coreUserDal)
        {
            _coreUserDal = coreUserDal;
        }

        public List<OperationClaim> GetClaims(CoreUser coreUser)
        {
            return _coreUserDal.GetClaims(coreUser);
        }

        public void Add(CoreUser coreUser)
        {
            _coreUserDal.Add(coreUser);
        }

        public CoreUser GetByMail(string email)
        {
            return _coreUserDal.Get(u => u.Email == email);
        }

       
    }
}