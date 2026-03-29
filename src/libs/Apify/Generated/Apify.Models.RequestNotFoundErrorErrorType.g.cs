
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestNotFoundErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        RecordNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestNotFoundErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestNotFoundErrorErrorType value)
        {
            return value switch
            {
                RequestNotFoundErrorErrorType.RecordNotFound => "record-not-found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestNotFoundErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "record-not-found" => RequestNotFoundErrorErrorType.RecordNotFound,
                _ => null,
            };
        }
    }
}