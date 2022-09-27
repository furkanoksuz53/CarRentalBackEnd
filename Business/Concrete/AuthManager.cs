using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constans;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private ICoreUserService _coreUserService;
        private ITokenHelper _tokenHelper;

        public AuthManager(ICoreUserService coreUserService, ITokenHelper tokenHelper)
        {
            _coreUserService = coreUserService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<CoreUser> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var coreUser = new CoreUser
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _coreUserService.Add(coreUser);
            return new SuccessDataResult<CoreUser>(coreUser, Messages.UserRegistered);
        }

        public IDataResult<CoreUser> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _coreUserService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<CoreUser>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<CoreUser>(Messages.PasswordError);
            }

            return new SuccessDataResult<CoreUser>(userToCheck, Messages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_coreUserService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(CoreUser coreUser)
        {
            var claims = _coreUserService.GetClaims(coreUser);
            var accessToken = _tokenHelper.CreateToken(coreUser, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}