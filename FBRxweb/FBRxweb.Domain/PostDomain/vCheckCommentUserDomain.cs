using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.PostModule
{
    public class vCheckCommentUserDomain : IvCheckCommentUserDomain
    {
        public vCheckCommentUserDomain(IPostUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vCheckCommentUser parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vCheckCommentUser parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<vCheckCommentUser>().SingleOrDefaultAsync(t => t.PostId == parameters.PostId);
        }
        

        public HashSet<string> AddValidation(vCheckCommentUser entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vCheckCommentUser entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vCheckCommentUser entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vCheckCommentUser entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vCheckCommentUser parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vCheckCommentUser parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvCheckCommentUserDomain : ICoreDomain<vCheckCommentUser, vCheckCommentUser> { }
}
