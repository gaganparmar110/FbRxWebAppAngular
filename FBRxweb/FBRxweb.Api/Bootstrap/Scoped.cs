#region Namespace
using Microsoft.Extensions.DependencyInjection;
using FBRxweb.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using FBRxweb.UnitOfWork.DbEntityAudit;
using FBRxweb.BoundedContext.Main;
using FBRxweb.UnitOfWork.Main;


using FBRxweb.Domain.PostModule;
using FBRxweb.Domain.FacebookChatModule;
//  using FBRxweb.Domain.vUserProfileModule;
using FBRxweb.Domain.UserProfileDetailModule;
#endregion Namespace



using FBRxweb.Domain.FacebookUserDetailModule;
using FBRxweb.Domain.FacebookUserWorkModule;
using FBRxweb.Domain.EducationDetailModule;
using FBRxweb.Domain.FacebookuserModule;

namespace FBRxweb.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();

                        serviceCollection.AddScoped<IFacebookUserContext, FacebookUserContext>();
            serviceCollection.AddScoped<IFacebookUserUow, FacebookUserUow>();
                       
                        serviceCollection.AddScoped<IUserChatContext, UserChatContext>();
            serviceCollection.AddScoped<IUserChatUow, UserChatUow>();
                        serviceCollection.AddScoped<IViewOnlineUserContext, ViewOnlineUserContext>();
            serviceCollection.AddScoped<IViewOnlineUserUow, ViewOnlineUserUow>();
                        serviceCollection.AddScoped<IPostContext, PostContext>();
            serviceCollection.AddScoped<IPostUow, PostUow>();
                        serviceCollection.AddScoped<IPostDetailContext, PostDetailContext>();
 
         
                        serviceCollection.AddScoped<IFacebookChatContext, FacebookChatContext>();
            serviceCollection.AddScoped<IFacebookChatUow, FacebookChatUow>();

             
  //          serviceCollection.AddScoped<IFacebookContext, FacebookContext>();
 //           serviceCollection.AddScoped<IFacebookUow, FacebookUow>();
                        serviceCollection.AddScoped<IProfileViewContext, ProfileViewContext>();
            serviceCollection.AddScoped<IProfileViewUow, ProfileViewUow>();
                        serviceCollection.AddScoped<IProfileViewContext, ProfileViewContext>();
            serviceCollection.AddScoped<IProfileViewUow, ProfileViewUow>();
                        serviceCollection.AddScoped<IProfileViewContext, ProfileViewContext>();
            serviceCollection.AddScoped<IProfileViewUow, ProfileViewUow>();
                        serviceCollection.AddScoped<IFacebookUserDetailContext, FacebookUserDetailContext>();
            serviceCollection.AddScoped<IFacebookUserDetailUow, FacebookUserDetailUow>();
                        serviceCollection.AddScoped<IFacebookUserWorkContext, FacebookUserWorkContext>();
            serviceCollection.AddScoped<IFacebookUserWorkUow, FacebookUserWorkUow>();
                        serviceCollection.AddScoped<IEducationDetailContext, EducationDetailContext>();
            serviceCollection.AddScoped<IEducationDetailUow, EducationDetailUow>();

                       
                        serviceCollection.AddScoped<IUserProfileDetailContext, UserProfileDetailContext>();
            serviceCollection.AddScoped<IUserProfileDetailUow, UserProfileDetailUow>();
            #endregion ContextService



            

              #region DomainService
   
            serviceCollection.AddScoped<IFacebookUserDomain, FacebookUserDomain>();
       
            serviceCollection.AddScoped<IvAllPostDomain, vAllPostDomain>();
            
            serviceCollection.AddScoped<IPostMediaDomain, PostMediaDomain>();
            
            serviceCollection.AddScoped<IPostMessageDomain, PostMessageDomain>();
            
            serviceCollection.AddScoped<IPostLikeDomain, PostLikeDomain>();
            
            serviceCollection.AddScoped<IPostCommentDomain, PostCommentDomain>();
            
            serviceCollection.AddScoped<IPostShareDomain, PostShareDomain>();
            
         
            serviceCollection.AddScoped<IChatMediaDomain, ChatMediaDomain>();
            
            serviceCollection.AddScoped<IChatMessageDomain, ChatMessageDomain>();
            
           
            
            serviceCollection.AddScoped<IvCheckLikeUserDomain, vCheckLikeUserDomain>();
            
            serviceCollection.AddScoped<IvCheckCommentUserDomain, vCheckCommentUserDomain>();
            
            serviceCollection.AddScoped<IvCheckShareUserDomain, vCheckShareUserDomain>();
            
           // serviceCollection.AddScoped<IVUserProfileDomain, VUserProfileDomain>();
            
            serviceCollection.AddScoped<IvUserProfileDomain, vUserProfileDomain>();
            #endregion DomainService














            #region DomainService

            
            serviceCollection.AddScoped<IFacebookUserDetailDomain, FacebookUserDetailDomain>();
            
            serviceCollection.AddScoped<IFacebookUserWorkDomain, FacebookUserWorkDomain>();
            
            serviceCollection.AddScoped<IEducationDetailDomain, EducationDetailDomain>();


            #endregion

        }
    }
}



