using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.InvestmentPlans.DTO
{
    public class InvestmentPlanMapProfile : Profile
    {
        public InvestmentPlanMapProfile()
        {
            CreateMap<CreateInvestmentPlanDto, InvestmentPlan>();
            CreateMap<EditInvestmentPlanDto, InvestmentPlan>();
            CreateMap<InvestmentPlanDto, InvestmentPlan>();
            CreateMap<InvestmentPlan, InvestmentPlanListDto>();
        }
    }
}