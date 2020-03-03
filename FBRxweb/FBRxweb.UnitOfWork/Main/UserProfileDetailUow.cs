using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class UserProfileDetailUow : BaseUow, IUserProfileDetailUow
    {
        public UserProfileDetailUow(IUserProfileDetailContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IUserProfileDetailUow : ICoreUnitOfWork { }
}


