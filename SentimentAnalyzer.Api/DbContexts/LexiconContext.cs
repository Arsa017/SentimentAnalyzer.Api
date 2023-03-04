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
        } 

    }
}
