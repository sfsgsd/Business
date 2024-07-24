using Application.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseApiController : ControllerBase
    {

        protected ActionResult HandleResult<T>(Result<T> result)
        {
            if (result == null) return NotFound();
            if (result.IsSucceed && result.Value != null)
                return Ok(result.Value);
            if (result.IsSucceed && result.Value == null)
                return NotFound();
            return BadRequest(result.Error);
        }
    }
}
