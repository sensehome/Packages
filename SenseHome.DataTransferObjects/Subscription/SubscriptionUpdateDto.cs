using System.ComponentModel.DataAnnotations;
using SenseHome.DataTransferObjects.Base;

namespace SenseHome.DataTransferObjects.Subscription
{
    public class SubscriptionUpdateDto : BaseDto
    {
        [Required]
        public string[] Path { set; get; }
    }
}
