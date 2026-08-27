
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: LIMITED_PERMISSIONS
    /// </summary>
    public enum ActorsRunsPostForcePermissionLevel
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
    public static class ActorsRunsPostForcePermissionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorsRunsPostForcePermissionLevel value)
        {
            return value switch
            {
                ActorsRunsPostForcePermissionLevel.FullPermissions => "FULL_PERMISSIONS",
                ActorsRunsPostForcePermissionLevel.LimitedPermissions => "LIMITED_PERMISSIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorsRunsPostForcePermissionLevel? ToEnum(string value)
        {
            return value switch
            {
                "FULL_PERMISSIONS" => ActorsRunsPostForcePermissionLevel.FullPermissions,
                "LIMITED_PERMISSIONS" => ActorsRunsPostForcePermissionLevel.LimitedPermissions,
                _ => null,
            };
        }
    }
}