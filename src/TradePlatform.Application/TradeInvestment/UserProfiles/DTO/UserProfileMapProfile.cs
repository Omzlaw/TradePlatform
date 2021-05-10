using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.UserProfiles.DTO
{
    public class UserProfileMapProfile : Profile
    {
        public UserProfileMapProfile()
        {
            CreateMap<CreateUserProfileDto, UserProfile>();
            CreateMap<EditUserProfileDto, UserProfile>();
            CreateMap<UserProfileDto, UserProfile>();
            CreateMap<UserProfile, UserProfileListDto>();
        }
    }
}