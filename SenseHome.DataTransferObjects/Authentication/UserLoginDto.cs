using System.ComponentModel.DataAnnotations;

namespace SenseHome.DataTransferObjects.Authentication
{
    public class UserLoginDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
