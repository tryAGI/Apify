
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentVariableNotFoundErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        RecordNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentVariableNotFoundErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentVariableNotFoundErrorErrorType value)
        {
            return value switch
            {
                EnvironmentVariableNotFoundErrorErrorType.RecordNotFound => "record-not-found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentVariableNotFoundErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "record-not-found" => EnvironmentVariableNotFoundErrorErrorType.RecordNotFound,
                _ => null,
            };
        }
    }
}