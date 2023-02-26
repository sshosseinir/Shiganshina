using Microsoft.AspNetCore.Mvc;
using Ohara.Gateway.Shiganshina.Controllers.Base;

namespace Pajuhesh.Gateway.Shiganshina.Controllers.v1;

[ApiVersion("1.0")]
public class HealthCheckController : BaseApiController
{
    [MapToApiVersion("1.0")]
    [HttpGet("ping")]
    public string Ping()
    {
        return "Pong";
    }
}