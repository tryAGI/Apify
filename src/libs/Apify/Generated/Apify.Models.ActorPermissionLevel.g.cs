
#nullable enable

namespace Apify
{
    /// <summary>
    /// Determines the permission level that the Actor requires to run. For details, see [Actor permissions](https://docs.apify.com/platform/actors/development/permissions).
    /// </summary>
    public enum ActorPermissionLevel
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
    public static class ActorPermissionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorPermissionLevel value)
        {
            return value switch
            {
                ActorPermissionLevel.FullPermissions => "FULL_PERMISSIONS",
                ActorPermissionLevel.LimitedPermissions => "LIMITED_PERMISSIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorPermissionLevel? ToEnum(string value)
        {
            return value switch
            {
                "FULL_PERMISSIONS" => ActorPermissionLevel.FullPermissions,
                "LIMITED_PERMISSIONS" => ActorPermissionLevel.LimitedPermissions,
                _ => null,
            };
        }
    }
}