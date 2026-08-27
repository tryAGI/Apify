
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum RequestQueueRequestsGetFilterItem
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
    public static class RequestQueueRequestsGetFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestQueueRequestsGetFilterItem value)
        {
            return value switch
            {
                RequestQueueRequestsGetFilterItem.Locked => "locked",
                RequestQueueRequestsGetFilterItem.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestQueueRequestsGetFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "locked" => RequestQueueRequestsGetFilterItem.Locked,
                "pending" => RequestQueueRequestsGetFilterItem.Pending,
                _ => null,
            };
        }
    }
}