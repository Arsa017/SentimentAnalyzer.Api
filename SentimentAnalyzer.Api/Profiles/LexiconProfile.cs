using AutoMapper;

namespace SentimentAnalyzer.Api.Profiles
{
    public class LexiconProfile : Profile
    {
        public LexiconProfile()
        {
            CreateMap<Entities.Lexicon, Models.LexiconResponse>()
                .ForMember(src => src.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(src => src.Word, opt => opt.MapFrom(dest => dest.Word))
                .ForMember(src => src.SentimentScore, opt => opt.MapFrom(dest => dest.SentimentScore));

            CreateMap<Models.LexiconRequest, Entities.Lexicon>()
                .ForMember(src => src.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(src => src.Word, opt => opt.MapFrom(dest => dest.Word))
                .ForMember(src => src.SentimentScore, opt => opt.MapFrom(dest => dest.SentimentScore));
        }
    }
}
