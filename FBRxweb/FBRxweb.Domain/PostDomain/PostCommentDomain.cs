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
    public class PostCommentDomain : IPostCommentDomain
    {
        public PostCommentDomain(IPostUow uow, IDbContextManager<MainSqlDbContext> dbContextManager)
        {
            this.Uow = uow;
            this.DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(PostComment parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(PostComment parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(PostComment entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostComment entity)
        {
            await DbContextManager.BeginTransactionAsync();

            var spParameters = new SqlParameter[3];

            spParameters[0] = new SqlParameter() { ParameterName = "userid", Value = entity.UserId };
            spParameters[1] = new SqlParameter() { ParameterName = "postid", Value = entity.PostId };
            spParameters[2] = new SqlParameter() { ParameterName = "comment", Value = entity.Comment };

            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spInsertComment", spParameters);
            try
            {
                await DbContextManager.CommitAsync();

            }
            catch (Exception )
            {
                DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(PostComment entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostComment entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostComment parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostComment parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();

        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IPostCommentDomain : ICoreDomain<PostComment, PostComment> { }
}
