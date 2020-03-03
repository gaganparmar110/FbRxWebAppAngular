using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.ViewOnlineUserModule
{
    public class vOnlineUserListDomain : IvOnlineUserListDomain
    {
        public vOnlineUserListDomain(IViewOnlineUserUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vOnlineUserList parameters)
        {
            //throw new NotImplementedException();

            return await Uow.Repository<vOnlineUserList>().AllAsync();
        }

        public Task<object> GetBy(vOnlineUserList parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vOnlineUserList entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vOnlineUserList entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vOnlineUserList entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vOnlineUserList entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vOnlineUserList parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vOnlineUserList parameters)
        {
            throw new NotImplementedException();
        }

        public IViewOnlineUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvOnlineUserListDomain : ICoreDomain<vOnlineUserList, vOnlineUserList> { }
}
