
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum RecordNotFoundErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        RecordNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordNotFoundErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordNotFoundErrorErrorType value)
        {
            return value switch
            {
                RecordNotFoundErrorErrorType.RecordNotFound => "record-not-found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordNotFoundErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "record-not-found" => RecordNotFoundErrorErrorType.RecordNotFound,
                _ => null,
            };
        }
    }
}