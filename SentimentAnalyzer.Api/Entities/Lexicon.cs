using System.ComponentModel.DataAnnotations;

namespace SentimentAnalyzer.Api.Entities
{
    public class Lexicon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Word { get; set; }

        [Required]
        public float SentimentScore { get; set; }
    }
}
