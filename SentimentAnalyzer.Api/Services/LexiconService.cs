using Microsoft.EntityFrameworkCore;
using SentimentAnalyzer.Api.DbContexts;
using SentimentAnalyzer.Api.Entities;

namespace SentimentAnalyzer.Api.Services
{
    public class LexiconService : ILexiconService
    {
        private readonly LexiconContext _lexiconContext;
        private readonly ILogger<LexiconService> _logger;

        public LexiconService(
            LexiconContext lexiconContext, 
            ILogger<LexiconService> logger)
        {
            _lexiconContext = lexiconContext ?? throw new ArgumentNullException(nameof(lexiconContext));
            _logger = logger;
        }

        public async Task<List<Lexicon>> GetLexiconWordsAsync()
        {
            var resp = new List<Lexicon>();

            try
            {
                resp = await _lexiconContext.Lexicon.OrderBy(l => l.Word).ToListAsync();
            } 
            catch (Exception ex)
            {
                _logger.LogError($"Error occured: LexiconService: GetLexiconWordsAsync(); message: {ex.Message}");
            }

            return resp;
        }

        public async Task<Lexicon?> GetLexiconWordAsync(string? word)
        {

            var resp = new Lexicon();
            
            try
            {
                resp = await _lexiconContext.Lexicon.Where(l => l.Word == word).FirstOrDefaultAsync();
            } 
            catch (Exception ex)
            {
                _logger.LogError($"Error occured: LexiconService: GetLexiconWordAsync(); request: {word} message: {ex.Message}");
            }

            return resp;
        }

        public async Task AddWordToLexiconAsync(Lexicon lexiconWordToAdd)
        {
            try
            {
                var resp = await GetLexiconWordAsync(lexiconWordToAdd.Word).ConfigureAwait(false);
                
                if (resp == null)   // preventing the occurrence of duplicates
                {
                    _lexiconContext.Add(lexiconWordToAdd);
                }
            } 
            catch(Exception ex)
            {
                _logger.LogError($"Error occured: LexiconService: AddWordToLexiconAsync(); request: {lexiconWordToAdd} message: {ex.Message}");
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _lexiconContext.SaveChangesAsync() >= 0);
        }
    }
}
