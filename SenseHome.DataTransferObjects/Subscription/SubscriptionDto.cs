using SenseHome.DataTransferObjects.Base;

namespace SenseHome.DataTransferObjects.Subscription
{
    public class SubscriptionDto : BaseDtoWithLog
    {
        public string[] Path { set; get; }
        public string UserId { get; set; }
    }
}
