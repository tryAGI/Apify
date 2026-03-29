
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestQueueRequestsBatchDeleteContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestQueueRequestsBatchDeleteContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestQueueRequestsBatchDeleteContentType value)
        {
            return value switch
            {
                RequestQueueRequestsBatchDeleteContentType.ApplicationJson => "application/json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestQueueRequestsBatchDeleteContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => RequestQueueRequestsBatchDeleteContentType.ApplicationJson,
                _ => null,
            };
        }
    }
}