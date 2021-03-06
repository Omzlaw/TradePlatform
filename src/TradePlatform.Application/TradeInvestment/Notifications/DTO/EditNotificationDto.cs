using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Notifications.DTO
{
    [AutoMapTo(typeof(Notification))]
    public class EditNotificationDto : EntityDto<int>
    {
        [Required]
        public string Message { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}