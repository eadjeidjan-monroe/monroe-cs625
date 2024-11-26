using DemoAI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DisplayUserInputController : ControllerBase
	{
	

		// POST api/<DisplayTypeController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
			DemoGeneric demo = new DemoGeneric();
			
			if (!string.IsNullOrEmpty(value))
			{
				demo.DemoApiService(value);
			}
		}

		

	}
}
