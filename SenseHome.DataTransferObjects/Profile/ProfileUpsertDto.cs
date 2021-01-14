using System.ComponentModel.DataAnnotations;
using SenseHome.DataTransferObjects.Base;

namespace SenseHome.DataTransferObjects.Profile
{
    public class ProfileUpsertDto : BaseDtoWithLog
    {
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public string DisplayName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
