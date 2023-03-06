using SentimentAnalyzer.Api.Entities;

namespace SentimentAnalyzer.Api.Services
{
    public interface ILexiconService
    {
        public Task<List<Lexicon>> GetLexiconWordsAsync();

        public Task<Lexicon?> GetLexiconWordAsync(string? word);

        public Task<Lexicon?> GetLexiconWordByIdAsync(int? id);

        public Task AddWordToLexiconAsync(Lexicon lexiconWordToAdd);

        public void DeleteWordFromLexicon(Lexicon lexiconWordToRemove);

        public Task<bool> SaveChangesAsync();

    }
}
