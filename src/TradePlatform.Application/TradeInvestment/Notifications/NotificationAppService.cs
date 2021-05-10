using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.Notifications.DTO;
using TradePlatform.Core.TradeInvestment;
using TradePlatform.Core.TradeInvestment.Notifications;

namespace TradePlatform.Application.TradeInvestment.Notifications
{
    public class NotificationAppService : AsyncCrudAppService<Notification, NotificationDto, int, NotificationListDto, CreateNotificationDto, EditNotificationDto>, INotificationAppService
    {
        private readonly INotificationManager _notificationManager;
        private readonly IMapper _mapper;
        public NotificationAppService(IRepository<Notification, int> repository, INotificationManager notificationManager, IMapper mapper) : base(repository)
        {
            _notificationManager = notificationManager;
            _mapper = mapper;
        }

        public async Task<ListResultDto<NotificationListDto>> GetNotificationsByUserProfile(int userProfileId)
        {
            var dep = await _notificationManager.GetNotificationsByUserProfile(userProfileId);
            return new ListResultDto<NotificationListDto>(_mapper.Map<List<NotificationListDto>>(dep));
        }
    }
}