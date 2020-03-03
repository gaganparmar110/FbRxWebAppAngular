using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RxWeb.Core.Data;
using FBRxweb.Models.ViewModels;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Api.Controllers.FacebookUserModule
{
    [ApiController]
	[Route("api/[controller]")]
    public class SearchChangePasswordController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchChangePasswordController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[3];
            spParameters[0] = new SqlParameter() { ParameterName = "id", Value = searchParams["id"] };
            spParameters[1] = new SqlParameter() { ParameterName = "oldPassword", Value = searchParams["oldPassword"] };
            spParameters[2] = new SqlParameter() { ParameterName = "newPassword", Value = searchParams["newPassword"] };
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spChangePassword", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
