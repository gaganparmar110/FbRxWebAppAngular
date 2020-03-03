using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class FacebookChatUow : BaseUow, IFacebookChatUow
    {
        public FacebookChatUow(IFacebookChatContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IFacebookChatUow : ICoreUnitOfWork { }
}


