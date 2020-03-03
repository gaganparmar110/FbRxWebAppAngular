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
    public class PostContext : BaseBoundedContext, IPostContext
    {
        public PostContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<PostMessage> Post { get; set; }
		public DbSet<PostMedia> PostMessage { get; set; }
            		public DbSet<vAllPost> vAllPost { get; set; }
            		public DbSet<PostLike> PostLike { get; set; }
		public DbSet<PostComment> PostComment { get; set; }
		public DbSet<PostShare> PostShare { get; set; }
            		public DbSet<vCheckLikeUser> vCheckLikeUser { get; set; }
		public DbSet<vCheckCommentUser> vCheckCommentUser { get; set; }
		public DbSet<vCheckShareUser> vCheckShareUser { get; set; }
            #endregion DbSets

    }


    public interface IPostContext : IDbContext
    {
    }
}

