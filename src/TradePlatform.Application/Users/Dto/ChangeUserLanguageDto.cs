using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}