using Microsoft.AspNetCore.Mvc;
using waifu_simulator.Utils.Responses;

namespace waifu_simulator.Controllers;

[ApiController]
[Route("api/example")]
public class ExampleController : ControllerBase
{
    private readonly IConfiguration _config;
    public ExampleController(IConfiguration config)
    {
        _config = config;
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponses<string>>> GetHellow()
    {
        try
        {
            string val = _config["example:value"];

            if (string.IsNullOrEmpty(val)) return BadRequest(ResponsesHelper.error<string>("the string is null"));


            return Ok(ResponsesHelper.success(val));
        }
        catch (Exception e)
        {
            return StatusCode(500, ResponsesHelper.error<string>("error", new Dictionary<string, string> { { "exception", e.Message } }));
        }
    }
}