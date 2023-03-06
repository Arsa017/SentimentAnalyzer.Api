using Microsoft.EntityFrameworkCore;
using SentimentAnalyzer.Api.Entities;

namespace SentimentAnalyzer.Api.DbContexts
{
    public class LexiconContext : DbContext
    {
        public DbSet<Lexicon> Lexicon { get; set; }

        public LexiconContext(DbContextOptions<LexiconContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Lexicon>()
                .HasIndex(e => e.Word)
                .IsUnique();

            builder.Entity<Lexicon>()
                .HasData(
                    new Lexicon()
                    {
                        Id = 1,
                        Word = "nice",
                        SentimentScore = "0.4"
                    },
                    new Lexicon()
                    {
                        Id = 2,
                        Word = "excellent",
                        SentimentScore = "0.8"
                    },
                    new Lexicon()
                    {
                        Id = 3,
                        Word = "modest",
                        SentimentScore = "0"
                    },
                    new Lexicon()
                    {
                        Id = 4,
                        Word = "horrible",
                        SentimentScore = "-0.8"
                    },
                    new Lexicon()
                    {
                        Id = 5,
                        Word = "ugly",
                        SentimentScore = "-0.5"
                    }
                );

            base.OnModelCreating(builder);
        } 

    }
}
