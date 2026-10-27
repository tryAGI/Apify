
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: LIMITED_PERMISSIONS
    /// </summary>
    public enum ActorRunSyncGetDatasetItemsPostForcePermissionLevel
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
    public static class ActorRunSyncGetDatasetItemsPostForcePermissionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunSyncGetDatasetItemsPostForcePermissionLevel value)
        {
            return value switch
            {
                ActorRunSyncGetDatasetItemsPostForcePermissionLevel.FullPermissions => "FULL_PERMISSIONS",
                ActorRunSyncGetDatasetItemsPostForcePermissionLevel.LimitedPermissions => "LIMITED_PERMISSIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunSyncGetDatasetItemsPostForcePermissionLevel? ToEnum(string value)
        {
            return value switch
            {
                "FULL_PERMISSIONS" => ActorRunSyncGetDatasetItemsPostForcePermissionLevel.FullPermissions,
                "LIMITED_PERMISSIONS" => ActorRunSyncGetDatasetItemsPostForcePermissionLevel.LimitedPermissions,
                _ => null,
            };
        }
    }
}