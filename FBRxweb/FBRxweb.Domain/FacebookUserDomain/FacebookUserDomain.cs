using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;
using FBRxweb.Models.ViewModels;
using RxWeb.Core.Security.Cryptography;

namespace FBRxweb.Domain.FacebookuserModule
{
    public class FacebookUserDomain : IFacebookUserDomain
    {
        public FacebookUserDomain(IFacebookUserUow uow, IPasswordHash passwordHash)
        {
            this.Uow = uow;
            PasswordHash = passwordHash;
        }

        public Task<object> GetAsync(FacebookUserModel parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(FacebookUserModel parameters)
        {
            var isMobile = await Uow.Repository<FacebookUser>().SingleOrDefaultAsync(t => t.MobileNo == parameters.MobileNo);
            if (isMobile != null && PasswordHash.VerifySignature(parameters.Password, isMobile.Password, isMobile.Salt))
            {
                return "suuccess with mobile";
            }

            else
            {
                var isEmail = await Uow.Repository<FacebookUser>().SingleOrDefaultAsync(t => t.Email == parameters.Email);
                if (isEmail != null && PasswordHash.VerifySignature(parameters.Password, isEmail.Password, isEmail.Salt))
                {
                    return "suuccess with email";
                }
                else
                {
                    return "Invalid credentials";
                }
                   // return "Invalid credentials";
            }
        }


        public HashSet<string> AddValidation(FacebookUserModel entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(FacebookUserModel entity)
        {
            FacebookUser facebookUser = new FacebookUser();
            PasswordResult passwordResult = PasswordHash.Encrypt(entity.Password);
            facebookUser.FirstName = entity.FirstName;
            facebookUser.LastName = entity.LastName;
            facebookUser.Email = entity.Email;
            facebookUser.MobileNo = entity.MobileNo;
            facebookUser.GenderAO = entity.GenderAO;
            facebookUser.LoginStatus = entity.LoginStatus;
            facebookUser.DateOfBirth = entity.DateOfBirth;
            facebookUser.CreatedDateTime = entity.CreatedDateTime;
            facebookUser.Password = passwordResult.Signature;
            facebookUser.Salt = passwordResult.Salt;

            await Uow.RegisterNewAsync(facebookUser);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(FacebookUserModel entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(FacebookUserModel entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(FacebookUserModel parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(FacebookUserModel parameters)
        {
            throw new NotImplementedException();
        }

        public IFacebookUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IPasswordHash PasswordHash { get; set; }
    }

    public interface IFacebookUserDomain : ICoreDomain<FacebookUserModel, FacebookUserModel> { }
}