using Microsoft.AspNetCore.Mvc;

namespace FirstStatelessGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstController : ControllerBase
    {
        private readonly string helloWorld;
        public FirstController()
        {
            helloWorld = "Hello World!";
        }

        [HttpGet]
        [Route("get")]
        public async Task<string> Get()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            return helloWorld;
        }
    }
}
