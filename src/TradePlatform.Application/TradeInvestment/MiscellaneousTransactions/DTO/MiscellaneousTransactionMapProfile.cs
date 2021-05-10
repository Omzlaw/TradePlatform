using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.MiscellaneousTransactions.DTO
{
    public class MiscellaneousTransactionMapProfile : Profile
    {
        public MiscellaneousTransactionMapProfile()
        {
            CreateMap<CreateMiscellaneousTransactionDto, MiscellaneousTransaction>();
            CreateMap<EditMiscellaneousTransactionDto, MiscellaneousTransaction>();
            CreateMap<MiscellaneousTransactionDto, MiscellaneousTransaction>();
            CreateMap<MiscellaneousTransaction, MiscellaneousTransactionListDto>();
        }
    }
}