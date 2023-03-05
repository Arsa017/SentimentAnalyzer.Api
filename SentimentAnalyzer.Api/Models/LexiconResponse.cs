namespace SentimentAnalyzer.Api.Models
{
    public class LexiconResponse
    {
        public int Id { get; set; }
        public string? Word { get; set; }
        public string? SentimentScore { get; set; }
    }
}
