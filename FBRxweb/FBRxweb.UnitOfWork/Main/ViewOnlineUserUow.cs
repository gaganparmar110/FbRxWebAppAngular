using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class ViewOnlineUserUow : BaseUow, IViewOnlineUserUow
    {
        public ViewOnlineUserUow(IViewOnlineUserContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IViewOnlineUserUow : ICoreUnitOfWork { }
}


