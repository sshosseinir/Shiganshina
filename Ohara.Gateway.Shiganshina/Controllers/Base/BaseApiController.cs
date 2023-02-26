using Microsoft.AspNetCore.Mvc;

namespace Ohara.Gateway.Shiganshina.Controllers.Base;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
public class BaseApiController : Controller
{
}