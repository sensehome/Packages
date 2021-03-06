﻿using System.ComponentModel.DataAnnotations;

namespace SenseHome.DataTransferObjects.Subscription
{
    public class SubscriptionInsertDto
    {
        [Required]
        public string[] Path { set; get; }
        [Required]
        public string UserId { get; set; }
    }
}
