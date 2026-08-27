
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum ActorTaskRunsLastRequestQueueRequestsGetFilterItem
    {
        /// <summary>
        ///
        /// </summary>
        Locked,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorTaskRunsLastRequestQueueRequestsGetFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorTaskRunsLastRequestQueueRequestsGetFilterItem value)
        {
            return value switch
            {
                ActorTaskRunsLastRequestQueueRequestsGetFilterItem.Locked => "locked",
                ActorTaskRunsLastRequestQueueRequestsGetFilterItem.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorTaskRunsLastRequestQueueRequestsGetFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "locked" => ActorTaskRunsLastRequestQueueRequestsGetFilterItem.Locked,
                "pending" => ActorTaskRunsLastRequestQueueRequestsGetFilterItem.Pending,
                _ => null,
            };
        }
    }
}