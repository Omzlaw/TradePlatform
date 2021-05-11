using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.Verifications.DTO;
using TradePlatform.Authorization;
using TradePlatform.Core.TradeInvestment;
using TradePlatform.Core.TradeInvestment.Verifications;

namespace TradePlatform.Application.TradeInvestment.Verifications
{
    [AbpAuthorize(PermissionNames.Pages_Verifications)]
    public class VerificationAppService : AsyncCrudAppService<Verification, VerificationDto, int, VerificationListDto, CreateVerificationDto, EditVerificationDto>, IVerificationAppService
    {
        private readonly IVerificationManager _verificationManager;
        private readonly IMapper _mapper;
        public VerificationAppService(IRepository<Verification, int> repository, IVerificationManager verificationManager, IMapper mapper) : base(repository)
        {
            _verificationManager = verificationManager;
            _mapper = mapper;
        }

        public async Task<VerificationDto> GetVerificationByUserProfile(int userProfileId)
        {
            var dep = await _verificationManager.GetVerificationByUserProfile(userProfileId);
            if(dep == null)
            {
                throw new EntityNotFoundException(typeof(Verification), userProfileId);
            }
            return _mapper.Map<VerificationDto>(dep);
        }
    }
}