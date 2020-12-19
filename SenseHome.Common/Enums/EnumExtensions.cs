using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SenseHome.Common.Enums
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this System.Enum value)
        {
            var displayName = value.ToString();
            var memberInfo = value.GetType().GetMember(value.ToString());

            if (memberInfo.Length > 0)
            {
                var attribute = memberInfo[0].CustomAttributes.FirstOrDefault(x => x.AttributeType == typeof(DisplayAttribute));
                if (attribute != null)
                {
                    displayName = attribute.NamedArguments != null
                        ? attribute.NamedArguments.First().TypedValue.Value.ToString()
                        : value.ToString();
                }
            }

            return displayName;
        }

        public static string ToIntegerString(this System.Enum enumValue)
        {
            return enumValue.ToString("D");
        }
    }
}
