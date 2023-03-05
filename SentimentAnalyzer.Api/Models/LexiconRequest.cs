using System.ComponentModel.DataAnnotations;

namespace SentimentAnalyzer.Api.Models
{
    public class LexiconRequest
    {
        public int Id { get; set; }
        [Required]
        public string? Word { get; set; }
        [Required]
        public string? SentimentScore { get; set; }
    }
}
