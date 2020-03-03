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
    public class SearchSearchNameController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchSearchNameController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[2];
            spParameters[0] = new SqlParameter() { ParameterName = "firstName", Value = searchParams["firstName"] };
            spParameters[1] = new SqlParameter() { ParameterName = "lastName", Value = searchParams["lastName"] };
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spSearchByName", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
