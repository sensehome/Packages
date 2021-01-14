using System.ComponentModel.DataAnnotations;

namespace SenseHome.Common.Enums
{
    public enum UserType
    {
        [Display(Name = "Admin")]
        Admin = 1,
        [Display(Name = "User")]
        User,
        [Display(Name = "Appliances")]
        Appliances
    }
}
