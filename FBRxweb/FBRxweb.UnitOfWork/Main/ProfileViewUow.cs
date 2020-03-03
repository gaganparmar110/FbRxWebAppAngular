using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class ProfileViewUow : BaseUow, IProfileViewUow
    {
        public ProfileViewUow(IProfileViewContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IProfileViewUow : ICoreUnitOfWork { }
}


