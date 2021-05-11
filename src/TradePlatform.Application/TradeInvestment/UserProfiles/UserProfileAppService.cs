using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.UserProfiles.DTO;
using TradePlatform.Authorization;
using TradePlatform.Core.TradeInvestment;
using TradePlatform.Core.TradeInvestment.UserProfiles;

namespace TradePlatform.Application.TradeInvestment.UserProfiles
{
    [AbpAuthorize(PermissionNames.Pages_UserProfiles)]
    public class UserProfileAppService : AsyncCrudAppService<UserProfile, UserProfileDto, int, UserProfileListDto, CreateUserProfileDto, EditUserProfileDto>, IUserProfileAppService
    {
        private readonly IUserProfileManager _userProfileManager;
        private readonly IMapper _mapper;
        public UserProfileAppService(IRepository<UserProfile, int> repository, IUserProfileManager userProfileManager, IMapper mapper) : base(repository)
        {
            _userProfileManager = userProfileManager;
            _mapper = mapper;
        }

        public async Task<UserProfileDto> GetUserProfileByUser(int userId)
        {
            var dep = await _userProfileManager.GetUserProfileByUser(userId);
            if(dep == null)
            {
                throw new EntityNotFoundException(typeof(UserProfile), userId);
            }
            return _mapper.Map<UserProfileDto>(dep);
        }
    }
}