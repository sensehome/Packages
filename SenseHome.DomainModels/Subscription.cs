using SenseHome.DomainModels.Base;
using System;

namespace SenseHome.DomainModels
{
    public class Subscription : BaseEntityWithLog
    {
        public string[] Path { set; get; }
        public string UserId { get; set; }
        public virtual User User {get; set;}
    }
}
