using System.ComponentModel.DataAnnotations;

namespace SenseHome.DataTransferObjects.Authentication
{
    public class InternalLoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
