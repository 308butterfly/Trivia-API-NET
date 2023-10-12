using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace Trivia_API_NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        public GameController() { }
        
        [HttpGet]
        public async Task<IActionResult> GetGameQuestions([FromQuery] int count, int categoryId, string difficulty, string type) {

            var baseURL = "https://opentdb.com/api.php";

            using (var client = new HttpClient())
            {
                try
                {
                    var results = await client.GetAsync();


                }
                catch {
                    return BadRequest();
                }
            }
            return Ok("Game Questions retrieved");
        }
    }
}
