using Microsoft.AspNetCore.Mvc;
using RxWeb.Core.AspNetCore;
using FBRxweb.Models.ViewModels;
using FBRxweb.Domain.FacebookuserModule;

namespace FBRxweb.Api.Controllers.FacebookUserModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class FacebookUsersController : BaseDomainController<FacebookUserModel, FacebookUserModel>

    {
        public FacebookUsersController(IFacebookUserDomain domain):base(domain) {}

    }
}
