
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorNotFoundErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ActorNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorNotFoundErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorNotFoundErrorErrorType value)
        {
            return value switch
            {
                ActorNotFoundErrorErrorType.ActorNotFound => "actor-not-found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorNotFoundErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "actor-not-found" => ActorNotFoundErrorErrorType.ActorNotFound,
                _ => null,
            };
        }
    }
}