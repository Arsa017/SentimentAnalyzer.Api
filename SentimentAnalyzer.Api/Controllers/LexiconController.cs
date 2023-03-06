using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SentimentAnalyzer.Api.Entities;
using SentimentAnalyzer.Api.Models;
using SentimentAnalyzer.Api.Services;

namespace SentimentAnalyzer.Api.Controllers
{
    [Route("api/lecixon")]
    [ApiController]
    public class LexiconController : ControllerBase
    {
        private readonly ILexiconService _lexiconService;
        private readonly IMapper _mapper;
        private readonly ILogger<LexiconController> _logger;

        public LexiconController(
            ILexiconService lexiconService,
            IMapper mapper,
            ILogger<LexiconController> logger)
        {
            _lexiconService = lexiconService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<LexiconResponse>>> GetLexiconWords()
        {

            var lexiconResp = new List<LexiconResponse>();

            try
            {
                var resp = await _lexiconService.GetLexiconWordsAsync().ConfigureAwait(false);
                lexiconResp = _mapper.Map<List<LexiconResponse>>(resp.ToList());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured: LexiconController: GetLexiconWords(); message: {ex.Message}");
            }
            
            return Ok(lexiconResp);
        }

        [HttpGet("{word}")]
        public async Task<ActionResult<LexiconResponse>> GetLexiconWord(string word)
        {
            var lexiconResponse = new LexiconResponse();

            try
            {
                var resp = await _lexiconService.GetLexiconWordAsync(word).ConfigureAwait(false);

                if (resp == null)
                {
                    return NotFound();
                }

                lexiconResponse = _mapper.Map<LexiconResponse>(resp);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured: LexiconController: GetLexiconWord(); request: {word} message: {ex.Message}");
            }

            return Ok(lexiconResponse);
        }

        [HttpPost]
        public async Task<ActionResult> AddWordToLexicon(LexiconRequest lexiconRequest)
        {
            try
            {
                var lexiconEntity = _mapper.Map<Lexicon>(lexiconRequest);
                
                await _lexiconService.AddWordToLexiconAsync(lexiconEntity).ConfigureAwait(false);

                await _lexiconService.SaveChangesAsync().ConfigureAwait(false);

            } 
            catch (Exception ex)
            {
                _logger.LogError($"Error occured: LexiconController: AddWordToLexicon(); request: {lexiconRequest} message: {ex.Message}");
                return BadRequest();
            }

            return NoContent();
        }
        
    }
}
