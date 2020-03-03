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
    public class PostShareDomain : IPostShareDomain
    {
        public PostShareDomain(IPostUow uow, IDbContextManager<MainSqlDbContext> dbContextManager)
        {
            this.Uow = uow;
            this.DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(PostShare parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(PostShare parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(PostShare entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostShare entity)
        {
            await DbContextManager.BeginTransactionAsync();

            var spParameters = new SqlParameter[2];

            spParameters[0] = new SqlParameter() { ParameterName = "userid", Value = entity.UserId };
            spParameters[1] = new SqlParameter() { ParameterName = "postid", Value = entity.PostId };

            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spInsertShare", spParameters);
            try
            {
                await DbContextManager.CommitAsync();

            }
            catch (Exception )
            {
                DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(PostShare entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostShare entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostShare parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostShare parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();

        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IPostShareDomain : ICoreDomain<PostShare, PostShare> { }
}
