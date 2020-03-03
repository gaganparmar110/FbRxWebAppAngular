using FBRxweb.BoundedContext.SqlContext;
using FBRxweb.Models.Main;
using FBRxweb.Models.ViewModels;
using FBRxweb.UnitOfWork.Main;
using Microsoft.Data.SqlClient;
using RxWeb.Core;
using RxWeb.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FBRxweb.Domain.PostModule
{
    public class PostMessageDomain : IPostMessageDomain
    {
        public PostMessageDomain(IPostUow uow,IDbContextManager<MainSqlDbContext> dbContextManager) {
            this.Uow = uow;
           this.DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(PostMessage parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(PostMessage parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(PostMessage entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostMessage entity)
        {
            await DbContextManager.BeginTransactionAsync();

            var spParameters = new SqlParameter[2];

            spParameters[0] = new SqlParameter() { ParameterName = "userid", Value = entity.UserId };
            spParameters[1] = new SqlParameter() { ParameterName = "post", Value = entity.Message };

            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spInsertPostMessages", spParameters);
            try
            {
                await DbContextManager.CommitAsync();                

            }
            catch (Exception)
            {
                DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(PostMessage entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostMessage entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostMessage parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostMessage parameters)
        {
            throw new NotImplementedException();
        }

        

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();

        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IPostMessageDomain : ICoreDomain<PostMessage, PostMessage> { }
}
