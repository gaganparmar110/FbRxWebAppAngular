using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.ViewOnlineUserModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.ViewOnlineUserModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class vOnlineUserListsController : BaseDomainController<vOnlineUserList, vOnlineUserList>

    {
        public vOnlineUserListsController(IvOnlineUserListDomain domain):base(domain) {}

    }
}
