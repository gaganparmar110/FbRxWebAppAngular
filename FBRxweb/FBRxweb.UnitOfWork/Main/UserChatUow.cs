using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class UserChatUow : BaseUow, IUserChatUow
    {
        public UserChatUow(IUserChatContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IUserChatUow : ICoreUnitOfWork { }
}


