using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FBRxweb.BoundedContext.SqlContext;
using FBRxweb.Models.Main;
using FBRxweb.Models;
using FBRxweb.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace FBRxweb.BoundedContext.Main
{
    public class FacebookChatContext : BaseBoundedContext, IFacebookChatContext
    {
        public FacebookChatContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<ChatMedia> ChatMedia { get; set; }
		public DbSet<ChatMessage> ChatMessage { get; set; }
		public DbSet<UserChat> UserChat { get; set; }
		public DbSet<vOnlineUserList> vOnlineUserList { get; set; }
            #endregion DbSets


    }


    public interface IFacebookChatContext : IDbContext
    {
    }
}

