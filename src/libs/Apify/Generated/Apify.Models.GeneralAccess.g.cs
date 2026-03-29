
#nullable enable

namespace Apify
{
    /// <summary>
    /// Defines the general access level for the resource.
    /// </summary>
    public enum GeneralAccess
    {
        /// <summary>
        /// 
        /// </summary>
        AnyoneWithIdCanRead,
        /// <summary>
        /// 
        /// </summary>
        AnyoneWithNameCanRead,
        /// <summary>
        /// 
        /// </summary>
        FollowUserSetting,
        /// <summary>
        /// 
        /// </summary>
        Restricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneralAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneralAccess value)
        {
            return value switch
            {
                GeneralAccess.AnyoneWithIdCanRead => "ANYONE_WITH_ID_CAN_READ",
                GeneralAccess.AnyoneWithNameCanRead => "ANYONE_WITH_NAME_CAN_READ",
                GeneralAccess.FollowUserSetting => "FOLLOW_USER_SETTING",
                GeneralAccess.Restricted => "RESTRICTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneralAccess? ToEnum(string value)
        {
            return value switch
            {
                "ANYONE_WITH_ID_CAN_READ" => GeneralAccess.AnyoneWithIdCanRead,
                "ANYONE_WITH_NAME_CAN_READ" => GeneralAccess.AnyoneWithNameCanRead,
                "FOLLOW_USER_SETTING" => GeneralAccess.FollowUserSetting,
                "RESTRICTED" => GeneralAccess.Restricted,
                _ => null,
            };
        }
    }
}