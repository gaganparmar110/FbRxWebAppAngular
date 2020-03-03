using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.FacebookUserDetailModule
{
    public class FacebookUserDetailDomain : IFacebookUserDetailDomain
    {
        public FacebookUserDetailDomain(IFacebookUserDetailUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(FacebookUserDetail parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<FacebookUserDetail>().AllAsync();
        }

        public async Task<object> GetBy(FacebookUserDetail parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<FacebookUserDetail>().SingleOrDefaultAsync(t => t.UserDetailId==parameters.UserDetailId);
        }
        

        public HashSet<string> AddValidation(FacebookUserDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(FacebookUserDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(FacebookUserDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(FacebookUserDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(FacebookUserDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(FacebookUserDetail parameters)
        {
            throw new NotImplementedException();
        }

        public IFacebookUserDetailUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IFacebookUserDetailDomain : ICoreDomain<FacebookUserDetail, FacebookUserDetail> { }
}
