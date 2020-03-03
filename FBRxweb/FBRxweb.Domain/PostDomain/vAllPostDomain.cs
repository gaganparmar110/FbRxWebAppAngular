using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.PostModule
{
    public class vAllPostDomain : IvAllPostDomain
    {
        public vAllPostDomain(IPostUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vAllPost parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<vAllPost>().AllAsync();
        }

        public async Task<object> GetBy(vAllPost parameters)
        {
            // throw new NotImplementedException();
            return await Uow.Repository<vAllPost>().SingleOrDefaultAsync(t=> t.PostId == parameters.PostId);
        }
        

        public HashSet<string> AddValidation(vAllPost entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vAllPost entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vAllPost entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vAllPost entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vAllPost parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vAllPost parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvAllPostDomain : ICoreDomain<vAllPost, vAllPost> { }
}
