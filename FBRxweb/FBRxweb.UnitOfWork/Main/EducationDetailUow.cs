using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class EducationDetailUow : BaseUow, IEducationDetailUow
    {
        public EducationDetailUow(IEducationDetailContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IEducationDetailUow : ICoreUnitOfWork { }
}


