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
    public class ChatMessageDomain : IChatMessageDomain
    {
        public ChatMessageDomain(IFacebookChatUow uow, IDbContextManager<MainSqlDbContext> dbContextManager)
        {
            this.Uow = uow;
            this.DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(ChatMessage parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(ChatMessage parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(ChatMessage entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(ChatMessage entity)
        {
            await DbContextManager.BeginTransactionAsync();

            var spParameters = new SqlParameter[3];

            spParameters[0] = new SqlParameter() { ParameterName = "sender", Value = entity.SenderId };
            spParameters[1] = new SqlParameter() { ParameterName = "receiver", Value = entity.ReceiverId };
            spParameters[2] = new SqlParameter() { ParameterName = "chat", Value = entity.Message };

            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spInsertChatMessage", spParameters);
            try
            {
                await DbContextManager.CommitAsync();

            }
            catch (Exception e)
            {
                DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(ChatMessage entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(ChatMessage entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(ChatMessage parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(ChatMessage parameters)
        {
            throw new NotImplementedException();
        }

        public IFacebookChatUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();

        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IChatMessageDomain : ICoreDomain<ChatMessage, ChatMessage> { }
}
