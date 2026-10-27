
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: LIMITED_PERMISSIONS
    /// </summary>
    public enum ActorRunSyncPostForcePermissionLevel
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
    public static class ActorRunSyncPostForcePermissionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunSyncPostForcePermissionLevel value)
        {
            return value switch
            {
                ActorRunSyncPostForcePermissionLevel.FullPermissions => "FULL_PERMISSIONS",
                ActorRunSyncPostForcePermissionLevel.LimitedPermissions => "LIMITED_PERMISSIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunSyncPostForcePermissionLevel? ToEnum(string value)
        {
            return value switch
            {
                "FULL_PERMISSIONS" => ActorRunSyncPostForcePermissionLevel.FullPermissions,
                "LIMITED_PERMISSIONS" => ActorRunSyncPostForcePermissionLevel.LimitedPermissions,
                _ => null,
            };
        }
    }
}