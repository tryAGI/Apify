
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorBuildNotFoundErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        RecordNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorBuildNotFoundErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorBuildNotFoundErrorErrorType value)
        {
            return value switch
            {
                ActorBuildNotFoundErrorErrorType.RecordNotFound => "record-not-found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorBuildNotFoundErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "record-not-found" => ActorBuildNotFoundErrorErrorType.RecordNotFound,
                _ => null,
            };
        }
    }
}