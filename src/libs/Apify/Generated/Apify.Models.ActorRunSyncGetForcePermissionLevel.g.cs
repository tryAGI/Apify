
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: LIMITED_PERMISSIONS
    /// </summary>
    public enum ActorRunSyncGetForcePermissionLevel
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
    public static class ActorRunSyncGetForcePermissionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunSyncGetForcePermissionLevel value)
        {
            return value switch
            {
                ActorRunSyncGetForcePermissionLevel.FullPermissions => "FULL_PERMISSIONS",
                ActorRunSyncGetForcePermissionLevel.LimitedPermissions => "LIMITED_PERMISSIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunSyncGetForcePermissionLevel? ToEnum(string value)
        {
            return value switch
            {
                "FULL_PERMISSIONS" => ActorRunSyncGetForcePermissionLevel.FullPermissions,
                "LIMITED_PERMISSIONS" => ActorRunSyncGetForcePermissionLevel.LimitedPermissions,
                _ => null,
            };
        }
    }
}