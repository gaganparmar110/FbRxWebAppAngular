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
    public class PostMediaDomain : IPostMediaDomain
    {
        public PostMediaDomain(IPostUow uow, IDbContextManager<MainSqlDbContext> dbContextManager)
        {
            this.Uow = uow;
            this.DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(PostMedia parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(PostMedia parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(PostMedia entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostMedia entity)
        {
            await DbContextManager.BeginTransactionAsync();

            var spParameters = new SqlParameter[2];

            spParameters[0] = new SqlParameter() { ParameterName = "userid", Value = entity.UserId };
            spParameters[1] = new SqlParameter() { ParameterName = "post", Value = entity.Media };

            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spInsertPostMedias", spParameters);
            try
            {
                await DbContextManager.CommitAsync();

            }
            catch (Exception )
            {
                DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(PostMedia entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostMedia entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostMedia parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostMedia parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();


        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IPostMediaDomain : ICoreDomain<PostMedia, PostMedia> { }
}
