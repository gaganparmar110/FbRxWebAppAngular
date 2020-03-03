using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.UserProfileDetailModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.UserProfileDetailModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class vUserProfilesController : BaseDomainController<vUserProfile, vUserProfile>

    {
        public vUserProfilesController(IvUserProfileDomain domain):base(domain) {}

    }
}
