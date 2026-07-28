
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorRunsLastRequestQueueRequestsGetFilterItem
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
    public static class ActorRunsLastRequestQueueRequestsGetFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunsLastRequestQueueRequestsGetFilterItem value)
        {
            return value switch
            {
                ActorRunsLastRequestQueueRequestsGetFilterItem.Locked => "locked",
                ActorRunsLastRequestQueueRequestsGetFilterItem.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunsLastRequestQueueRequestsGetFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "locked" => ActorRunsLastRequestQueueRequestsGetFilterItem.Locked,
                "pending" => ActorRunsLastRequestQueueRequestsGetFilterItem.Pending,
                _ => null,
            };
        }
    }
}