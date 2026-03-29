
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorRunNotFoundErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        RecordNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorRunNotFoundErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunNotFoundErrorErrorType value)
        {
            return value switch
            {
                ActorRunNotFoundErrorErrorType.RecordNotFound => "record-not-found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunNotFoundErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "record-not-found" => ActorRunNotFoundErrorErrorType.RecordNotFound,
                _ => null,
            };
        }
    }
}