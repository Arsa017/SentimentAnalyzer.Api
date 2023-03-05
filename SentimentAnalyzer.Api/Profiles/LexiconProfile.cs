using AutoMapper;

namespace SentimentAnalyzer.Api.Profiles
{
    public class LexiconProfile : Profile
    {
        public LexiconProfile()
        {
            CreateMap<Entities.Lexicon, Models.LexiconResponse>();
            CreateMap<Models.LexiconRequest, Entities.Lexicon>();
        }
    }
}
