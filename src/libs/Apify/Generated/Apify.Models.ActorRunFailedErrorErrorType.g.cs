
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorRunFailedErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        RunFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorRunFailedErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunFailedErrorErrorType value)
        {
            return value switch
            {
                ActorRunFailedErrorErrorType.RunFailed => "run-failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunFailedErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "run-failed" => ActorRunFailedErrorErrorType.RunFailed,
                _ => null,
            };
        }
    }
}