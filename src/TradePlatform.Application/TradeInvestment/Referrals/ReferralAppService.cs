using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.Referrals.DTO;
using TradePlatform.Authorization;
using TradePlatform.Core.TradeInvestment;
using TradePlatform.Core.TradeInvestment.Referrals;

namespace TradePlatform.Application.TradeInvestment.Referrals
{
    [AbpAuthorize(PermissionNames.Pages_Referrals)]
    public class ReferralAppService : AsyncCrudAppService<Referral, ReferralDto, int, ReferralListDto, CreateReferralDto, EditReferralDto>, IReferralAppService
    {
        private readonly IReferralManager _referralManager;
        private readonly IMapper _mapper;
        public ReferralAppService(IRepository<Referral, int> repository, IReferralManager referralManager, IMapper mapper) : base(repository)
        {
            _referralManager = referralManager;
            _mapper = mapper;
        }

        public async Task<ListResultDto<ReferralListDto>> GetReferralsByUserProfile(int userProfileId)
        {
            var dep = await _referralManager.GetReferralsByUserProfile(userProfileId);
            return new ListResultDto<ReferralListDto>(_mapper.Map<List<ReferralListDto>>(dep));
        }
    }
}