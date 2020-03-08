using Microsoft.AspNetCore.Mvc;

namespace WebAppAutofac.Controllers
{
	[Route("/")]
    public class HomeController : Controller
    {
		private readonly DependencyA dependencyA;

        public HomeController(DependencyA dependencyA)
        {
            this.dependencyA = dependencyA;
        }

        [HttpGet]
		public IActionResult Get()
        {
            return Ok("Running WebApp with Autofac");
        }
    }
}
