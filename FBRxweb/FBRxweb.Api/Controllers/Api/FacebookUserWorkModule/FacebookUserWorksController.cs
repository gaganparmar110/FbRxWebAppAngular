using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.FacebookUserWorkModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.FacebookUserWorkModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class FacebookUserWorksController : BaseDomainController<FacebookUserWork, FacebookUserWork>

    {
        public FacebookUserWorksController(IFacebookUserWorkDomain domain):base(domain) {}

    }
}
