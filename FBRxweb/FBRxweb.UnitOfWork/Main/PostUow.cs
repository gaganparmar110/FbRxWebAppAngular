using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class PostUow : BaseUow, IPostUow
    {
        public PostUow(IPostContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IPostUow : ICoreUnitOfWork { }
}


