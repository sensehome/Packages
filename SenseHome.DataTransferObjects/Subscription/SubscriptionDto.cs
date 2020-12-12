using SenseHome.DataTransferObjects.Base;
using System;

namespace SenseHome.DataTransferObjects.Subscription
{
    public class SubscriptionDto : BaseDtoWithLog
    {
        public DateTime ExpireDate { get; set; }
        public string[] Path { set; get; }
        public string UserId { get; set; }
    }
}
