
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum ActorRunRequestQueueRequestsGetFilterItem
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
    public static class ActorRunRequestQueueRequestsGetFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunRequestQueueRequestsGetFilterItem value)
        {
            return value switch
            {
                ActorRunRequestQueueRequestsGetFilterItem.Locked => "locked",
                ActorRunRequestQueueRequestsGetFilterItem.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunRequestQueueRequestsGetFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "locked" => ActorRunRequestQueueRequestsGetFilterItem.Locked,
                "pending" => ActorRunRequestQueueRequestsGetFilterItem.Pending,
                _ => null,
            };
        }
    }
}