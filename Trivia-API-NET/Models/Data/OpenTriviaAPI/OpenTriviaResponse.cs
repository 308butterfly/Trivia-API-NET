using Newtonsoft.Json;
using System.Text.Json;

namespace Trivia_API_NET.Models.Data.OpenTriviaAPI
{
    public class OpenTriviaResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }
        [JsonProperty("results")]
        public List<OpenTriviaQuestion> Results { get; set; }

    }
}


{
    "response_code": 0,
	"results": [

        {
        "category": "General Knowledge",
			"type": "multiple",
			"difficulty": "hard",
			"question": "Named after the mallow flower, mauve is a shade of what?",
			"correct_answer": "Purple",
			"incorrect_answers": [

                "Red",
				"Brown",
				"Pink"
			]
		}
	]
}
