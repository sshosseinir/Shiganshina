using Microsoft.AspNetCore.Mvc;
using Ohara.Gateway.Shiganshina.Controllers.Base;

namespace Pajuhesh.Gateway.Shiganshina.Controllers.v2;

[ApiVersion("2.0")]
public class HealthCheckController : BaseApiController
{
    [MapToApiVersion("2.0")]
    [HttpGet("ping")]
    public string Ping()
    {
        return "Poke";
    }
}