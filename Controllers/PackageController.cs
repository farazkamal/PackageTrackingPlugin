using Microsoft.AspNetCore.Mvc;

namespace PackageTrackingPlugin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PackageController : ControllerBase
    {

        private readonly ILogger<PackageController> _logger;

        public PackageController(ILogger<PackageController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Returns a string
        /// </summary>
        /// <param name="packageId">id of the package</param>
        /// <returns>some string</returns>
        [HttpGet(Name = "Track" )]
        public string Track(string packageId)
        {
            return "dont know";
        }
    }
}