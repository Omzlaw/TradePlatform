using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.InvestmentPlans.DTO;
using TradePlatform.Core.TradeInvestment;


namespace TradePlatform.Application.TradeInvestment.InvestmentPlans
{
    public class InvestmentPlanAppService : AsyncCrudAppService<InvestmentPlan, InvestmentPlanDto, int, InvestmentPlanListDto, CreateInvestmentPlanDto, EditInvestmentPlanDto>, IInvestmentPlanAppService
    {
        public InvestmentPlanAppService(IRepository<InvestmentPlan, int> repository) : base(repository)
        {
        }

    }
}