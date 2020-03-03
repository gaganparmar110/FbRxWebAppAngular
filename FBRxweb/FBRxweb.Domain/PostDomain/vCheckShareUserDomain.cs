using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.PostModule
{
    public class vCheckShareUserDomain : IvCheckShareUserDomain
    {
        public vCheckShareUserDomain(IPostUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vCheckShareUser parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vCheckShareUser parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<vCheckShareUser>().SingleOrDefaultAsync(t => t.PostId == parameters.PostId);
        }


        public HashSet<string> AddValidation(vCheckShareUser entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vCheckShareUser entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vCheckShareUser entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vCheckShareUser entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vCheckShareUser parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vCheckShareUser parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvCheckShareUserDomain : ICoreDomain<vCheckShareUser, vCheckShareUser> { }
}
