
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: LIMITED_PERMISSIONS
    /// </summary>
    public enum ActorRunSyncGetDatasetItemsGetForcePermissionLevel
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
    public static class ActorRunSyncGetDatasetItemsGetForcePermissionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunSyncGetDatasetItemsGetForcePermissionLevel value)
        {
            return value switch
            {
                ActorRunSyncGetDatasetItemsGetForcePermissionLevel.FullPermissions => "FULL_PERMISSIONS",
                ActorRunSyncGetDatasetItemsGetForcePermissionLevel.LimitedPermissions => "LIMITED_PERMISSIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunSyncGetDatasetItemsGetForcePermissionLevel? ToEnum(string value)
        {
            return value switch
            {
                "FULL_PERMISSIONS" => ActorRunSyncGetDatasetItemsGetForcePermissionLevel.FullPermissions,
                "LIMITED_PERMISSIONS" => ActorRunSyncGetDatasetItemsGetForcePermissionLevel.LimitedPermissions,
                _ => null,
            };
        }
    }
}