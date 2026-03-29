
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: LIMITED_PERMISSIONS
    /// </summary>
    public enum ActRunsPostForcePermissionLevel
    {
        /// <summary>
        /// 
        /// </summary>
        FullPermissions,
        /// <summary>
        /// 
        /// </summary>
        LimitedPermissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActRunsPostForcePermissionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActRunsPostForcePermissionLevel value)
        {
            return value switch
            {
                ActRunsPostForcePermissionLevel.FullPermissions => "FULL_PERMISSIONS",
                ActRunsPostForcePermissionLevel.LimitedPermissions => "LIMITED_PERMISSIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActRunsPostForcePermissionLevel? ToEnum(string value)
        {
            return value switch
            {
                "FULL_PERMISSIONS" => ActRunsPostForcePermissionLevel.FullPermissions,
                "LIMITED_PERMISSIONS" => ActRunsPostForcePermissionLevel.LimitedPermissions,
                _ => null,
            };
        }
    }
}