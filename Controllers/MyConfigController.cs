using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace configurationSource.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class MyConfigController : ControllerBase
	{
		private readonly IConfiguration _configuration;
        public MyConfigController(IConfiguration configuration)
        {
			_configuration = configuration;
        }

        [HttpGet]
		public Dictionary<string, string?> Get()
		{
			return _configuration.GetSection("Demo").GetChildren().ToDictionary(a => a.Key, a => a.Value);
		}
	}
}
