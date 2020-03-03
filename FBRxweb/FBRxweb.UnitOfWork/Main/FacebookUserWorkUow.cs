using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class FacebookUserWorkUow : BaseUow, IFacebookUserWorkUow
    {
        public FacebookUserWorkUow(IFacebookUserWorkContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IFacebookUserWorkUow : ICoreUnitOfWork { }
}


