using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.UserProfileDetailModule
{
    public class vUserProfileDomain : IvUserProfileDomain
    {
        public vUserProfileDomain(IUserProfileDetailUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vUserProfile parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<vUserProfile>().AllAsync();
        }

        public async Task<object> GetBy(vUserProfile parameters)
        {
            throw new NotImplementedException();
          //  return await Uow.Repository<vUserProfile>().SingleOrDefaultAsync(t=> t.UserId == parameters.UserId);
        }
        
//
        public HashSet<string> AddValidation(vUserProfile entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vUserProfile entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vUserProfile entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vUserProfile entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vUserProfile parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vUserProfile parameters)
        {
            throw new NotImplementedException();
        }

        public IUserProfileDetailUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvUserProfileDomain : ICoreDomain<vUserProfile, vUserProfile> { }
}
