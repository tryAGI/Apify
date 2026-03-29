
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnknownBuildTagErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        UnknownBuildTag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnknownBuildTagErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnknownBuildTagErrorErrorType value)
        {
            return value switch
            {
                UnknownBuildTagErrorErrorType.UnknownBuildTag => "unknown-build-tag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnknownBuildTagErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "unknown-build-tag" => UnknownBuildTagErrorErrorType.UnknownBuildTag,
                _ => null,
            };
        }
    }
}