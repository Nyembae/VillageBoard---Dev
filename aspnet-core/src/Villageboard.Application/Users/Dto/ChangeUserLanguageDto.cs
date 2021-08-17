using System.ComponentModel.DataAnnotations;

namespace Villageboard.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}