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
using FBRxweb.Models.ViewModels;

namespace FBRxweb.BoundedContext.Main
{
    public class FacebookUserContext : BaseBoundedContext, IFacebookUserContext
    {
        public FacebookUserContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
                public DbSet<FacebookUser>FacebookUsers { get; set; }
        public DbSet<PostComment> PostComment { get; set; }
        public DbSet<PostLike> PostLike { get; set; }
        public DbSet<PostShare> PostShare { get; set; }
       
        

        #endregion DbSets

    }


    public interface IFacebookUserContext : IDbContext
    {
    }
}

