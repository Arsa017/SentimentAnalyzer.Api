namespace SentimentAnalyzer.Api.Models
{
    public class LexiconUpdateRequest
    {
        public string? OldWord { get; set; }
        public string? NewWord { get; set; }
        public string? NewSentimentScore { get; set; }
    }
}
