namespace Trivia_API_NET.Models.Data.Entities
{
    // later
    public class Game
    {
        public IList<string> GameIds { get; set; }
        public Guid GameId { get; set; }
        public IList<string> Questions { get; set; }

    }
}
