using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.PostModule
{
    public class vCheckLikeUserDomain : IvCheckLikeUserDomain
    {
        public vCheckLikeUserDomain(IPostUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vCheckLikeUser parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vCheckLikeUser parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<vCheckLikeUser>().SingleOrDefaultAsync(t => t.PostId == parameters.PostId);
        }


        public HashSet<string> AddValidation(vCheckLikeUser entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vCheckLikeUser entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vCheckLikeUser entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vCheckLikeUser entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vCheckLikeUser parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vCheckLikeUser parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvCheckLikeUserDomain : ICoreDomain<vCheckLikeUser, vCheckLikeUser> { }
}
