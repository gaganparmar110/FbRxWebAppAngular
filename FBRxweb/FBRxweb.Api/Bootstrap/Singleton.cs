using Microsoft.Extensions.DependencyInjection;
using FBRxweb.Infrastructure.Singleton;
using FBRxweb.BoundedContext.Singleton;
using RxWeb.Core.Data;

namespace FBRxweb.Api.Bootstrap
{
    public static class Singleton
    {
        public static void AddSingletonService(this IServiceCollection serviceCollection)
        {
            #region Singleton
            serviceCollection.AddSingleton<ITenantDbConnectionInfo, TenantDbConnectionInfo>();
            serviceCollection.AddSingleton(typeof(UserAccessConfigInfo));
            #endregion Singleton
        }

    }
}




