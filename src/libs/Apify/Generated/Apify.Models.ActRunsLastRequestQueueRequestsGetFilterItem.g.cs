
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActRunsLastRequestQueueRequestsGetFilterItem
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
    public static class ActRunsLastRequestQueueRequestsGetFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActRunsLastRequestQueueRequestsGetFilterItem value)
        {
            return value switch
            {
                ActRunsLastRequestQueueRequestsGetFilterItem.Locked => "locked",
                ActRunsLastRequestQueueRequestsGetFilterItem.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActRunsLastRequestQueueRequestsGetFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "locked" => ActRunsLastRequestQueueRequestsGetFilterItem.Locked,
                "pending" => ActRunsLastRequestQueueRequestsGetFilterItem.Pending,
                _ => null,
            };
        }
    }
}