
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: locked
    /// </summary>
    public enum RequestQueueRequestsGetFilter
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
    public static class RequestQueueRequestsGetFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestQueueRequestsGetFilter value)
        {
            return value switch
            {
                RequestQueueRequestsGetFilter.Locked => "locked",
                RequestQueueRequestsGetFilter.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestQueueRequestsGetFilter? ToEnum(string value)
        {
            return value switch
            {
                "locked" => RequestQueueRequestsGetFilter.Locked,
                "pending" => RequestQueueRequestsGetFilter.Pending,
                _ => null,
            };
        }
    }
}