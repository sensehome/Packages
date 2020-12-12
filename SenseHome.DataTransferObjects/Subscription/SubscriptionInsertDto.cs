using SenseHome.DataTransferObjects.Base;

namespace SenseHome.DataTransferObjects.Subscription
{
    public class SubscriptionInsertDto : BaseDtoWithLog
    {
        public string[] Path { set; get; }
        public string UserId { get; set; }
    }
}
