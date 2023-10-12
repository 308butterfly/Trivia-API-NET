using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using Trivia_API_NET.Models.DTO;
using static System.Net.WebRequestMethods;

namespace Trivia_API_NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly string BASE_URL = "https://opentdb.com/api.php";
        private readonly int COUNT_LIMIT = 50;
        private readonly (int LOWER_BOUND, int UPPER_BOUND) CATEFORY_ID_RANGE = new (9, 32);
        private readonly List<string> DIFFICULTIES = new List<string> { "easy", "medium", "hard", "any" };
        private readonly List<string> TYPES = new List<string> { "multiple", "boolean", "any" };
        private readonly IConfiguration _configuration;
        public GameController(IConfiguration configuration, string API_Name) 
        { 
            _configuration = configuration;
            BASE_URL = configuration[API_Name]["Base_URL"];
        }
        private bool IsValidRequest(uint count, uint categoryId, string difficulty, string type)
        {
            if (count < 1 || count > COUNT_LIMIT)
                return false;

            if (categoryId < CATEFORY_ID_RANGE.LOWER_BOUND || categoryId > CATEFORY_ID_RANGE.UPPER_BOUND)
                return false;

            if (!DIFFICULTIES.Contains(difficulty))
                return false;

            if (!TYPES.Contains(type))
                return false;

            return true;
        }

        private string MakeQuery(uint count, uint categoryId, string difficulty, string type)
        {
            var url = new StringBuilder(baseURL);


            url.Append($"?amount={count}");
            return 
        }
        
        
        [HttpGet]
        public async Task<IActionResult> GetGameQuestions([FromQuery] uint count, uint categoryId, string difficulty, string type) {

            // https://opentdb.com/api.php?amount=10&category=17&difficulty=medium&type=multiple

            var gameData = new GameDTO();

            

            if (IsValidRequest(count, categoryId, difficulty, type) is not true)
                BadRequest();

            
            using (var client = new HttpClient())
            {
                try
                {
                    



                    var results = await client.GetAsync(url.ToString());

                    // change results to game object and return;

                   


                }
                catch {
                    return BadRequest();
                }
            }
            return Ok(gameData);
        }
    }
}
