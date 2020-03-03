using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class FacebookUserUow : BaseUow, IFacebookUserUow
    {
        public FacebookUserUow(IFacebookUserContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IFacebookUserUow : ICoreUnitOfWork { }
}


