using SenseHome.Common.Enums;
using SenseHome.DataTransferObjects.Base;

namespace SenseHome.DataTransferObjects.User
{
    public class UserDto : BaseDtoWithLog
    {
        public string Name { get; set; }
        public UserType Type { get; set; }
        public string UserTypeDisplayName => Type.GetDisplayName();
        public bool IsActive { get; set; } = true;
    }
}
