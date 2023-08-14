using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Reflection;

namespace Localization.Controllers.Api
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        private readonly IStringLocalizer<SharedResource> _localizer1;
        private readonly IStringLocalizer _localizer2;
        private readonly IStringLocalizer _localizer3;

        public ApiController(IStringLocalizer<SharedResource> stringLocalizer, IStringLocalizerFactory factory)
        {
            _localizer1 = stringLocalizer;
            _localizer2 = factory.Create(nameof(SharedResource), typeof(SharedResource).Assembly.FullName);
            _localizer3 = factory.Create(typeof(SharedResource));
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_localizer3["Shared"].Value);
        }
    }
}
