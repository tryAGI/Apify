
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorRunTimeoutExceededErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        RunTimeoutExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorRunTimeoutExceededErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunTimeoutExceededErrorErrorType value)
        {
            return value switch
            {
                ActorRunTimeoutExceededErrorErrorType.RunTimeoutExceeded => "run-timeout-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunTimeoutExceededErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "run-timeout-exceeded" => ActorRunTimeoutExceededErrorErrorType.RunTimeoutExceeded,
                _ => null,
            };
        }
    }
}