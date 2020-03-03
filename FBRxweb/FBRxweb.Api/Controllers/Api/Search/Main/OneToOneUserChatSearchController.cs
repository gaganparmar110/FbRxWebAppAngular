using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RxWeb.Core.Security;
using RxWeb.Core.Data;
using FBRxweb.Models.ViewModels;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Api.Controllers.UserChatModule
{
    [ApiController]
	[Route("api/[controller]")]
    public class SearchOneToOneUserChatController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchOneToOneUserChatController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[2];
            spParameters[0] = new SqlParameter() { ParameterName = "sender", Value = searchParams["sender"] };
            spParameters[1] = new SqlParameter() { ParameterName = "receiver", Value = searchParams["receiver"] };
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spUserChats", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
