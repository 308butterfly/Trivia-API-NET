namespace Trivia_API_NET.Models.DTO
{
    public class QuestionDTO
    {
        public IList<string> Answers { get; set; } = new List<string>();
    }
}
