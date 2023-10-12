namespace Trivia_API_NET.Models.DTO
{
    public class GameDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public IList<QuestionDTO> Questions { get; set; } = new List<QuestionDTO>();
    }
}
