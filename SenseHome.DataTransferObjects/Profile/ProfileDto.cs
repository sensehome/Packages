using SenseHome.DataTransferObjects.Base;

namespace SenseHome.DataTransferObjects.Profile
{
    public class ProfileDto : BaseDtoWithLog
    {
        public string ImagePath { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }

    }
}
