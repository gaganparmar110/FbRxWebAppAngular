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

namespace FBRxweb.Domain.FacebookChatModule
{
    public class ChatMediaDomain : IChatMediaDomain
    {
        public ChatMediaDomain(IFacebookChatUow uow, IDbContextManager<MainSqlDbContext> dbContextManager)
        {
            this.Uow = uow;
            this.DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(ChatMedia parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(ChatMedia parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(ChatMedia entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(ChatMedia entity)
        {
            await DbContextManager.BeginTransactionAsync();

            var spParameters = new SqlParameter[3];

            spParameters[0] = new SqlParameter() { ParameterName = "sender", Value = entity.SenderId };
            spParameters[1] = new SqlParameter() { ParameterName = "receiver", Value = entity.ReceiverId };
            spParameters[2] = new SqlParameter() { ParameterName = "chat", Value = entity.Media };

            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spInsertChatMedia", spParameters);
            try
            {
                await DbContextManager.CommitAsync();

            }
            catch (Exception e)
            {
                DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(ChatMedia entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(ChatMedia entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(ChatMedia parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(ChatMedia parameters)
        {
            throw new NotImplementedException();
        }

        public IFacebookChatUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();

        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IChatMediaDomain : ICoreDomain<ChatMedia, ChatMedia> { }
}
