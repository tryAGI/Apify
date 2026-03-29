
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorVersionNotFoundErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        RecordNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorVersionNotFoundErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorVersionNotFoundErrorErrorType value)
        {
            return value switch
            {
                ActorVersionNotFoundErrorErrorType.RecordNotFound => "record-not-found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorVersionNotFoundErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "record-not-found" => ActorVersionNotFoundErrorErrorType.RecordNotFound,
                _ => null,
            };
        }
    }
}