using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("")]
    public class HomeController : ControllerBase
    {
		private readonly DependencyA dependencyA;

		public HomeController(DependencyA dependencyA)
		{
			this.dependencyA = dependencyA;
		}

		[HttpGet]
        public IActionResult Get()
        {
			dependencyA.DoStuff();

			return Ok("Running WebApp with MS DI");
        }
    }
}
