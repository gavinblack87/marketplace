using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace IgsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IgsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] {"this", "is", "hard", "coded"};
        }
    }
}