using Microsoft.AspNetCore.Mvc;

namespace APIPractical.Controllers
{
    [ApiController]
    [Route("add")]
    public class AddController : ControllerBase
    {
        [Route("{number1}/{number2}")]
        [HttpGet]
        public int Add(int number1, int number2) 
        {
            return number1 + number2;
        }

    }
}
