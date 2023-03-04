using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SentimentAnalyzer.Api.Models;

namespace SentimentAnalyzer.Api.Controllers
{
    [Route("api/lecixon")]
    [ApiController]
    public class LexiconController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<LexiconResponse>> GetLexicon()
        {
            var result =
                    new List<LexiconResponse>
                    {
                        new LexiconResponse { Id = 1, Word = "Kafa", SentimentScore = 0.5 },
                        new LexiconResponse { Id = 2, Word = "Kisa", SentimentScore = -0.2 },
                    };
               

            return Ok(result);
        }
    }
}
