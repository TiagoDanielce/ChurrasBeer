using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace ChurrasBeer.Infrastructure.CrossCutting.Extensions.Enums
{
    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            if (enumValue == null)
                return string.Empty;

            return enumValue.GetType()?
                            .GetMember(enumValue.ToString())?
                            .First()?
                            .GetCustomAttribute<DisplayNameAttribute>()?
                            .DisplayName;
        }
    }
}
