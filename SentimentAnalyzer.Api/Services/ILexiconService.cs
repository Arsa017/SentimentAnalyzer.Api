using SentimentAnalyzer.Api.Entities;

namespace SentimentAnalyzer.Api.Services
{
    public interface ILexiconService
    {
        public Task<IEnumerable<Lexicon>> GetLexiconWordsAsync();

        public Task<Lexicon?> GetLexiconWordAsync(string word);

        public Task AddWordToLexiconAsync(Lexicon lexiconWordToAdd);

        public Task<bool> SaveChangesAsync();
    }
}
