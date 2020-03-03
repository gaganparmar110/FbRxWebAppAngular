using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class FacebookUserDetailUow : BaseUow, IFacebookUserDetailUow
    {
        public FacebookUserDetailUow(IFacebookUserDetailContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IFacebookUserDetailUow : ICoreUnitOfWork { }
}


