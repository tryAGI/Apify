
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetNotFoundErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        RecordNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetNotFoundErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetNotFoundErrorErrorType value)
        {
            return value switch
            {
                DatasetNotFoundErrorErrorType.RecordNotFound => "record-not-found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetNotFoundErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "record-not-found" => DatasetNotFoundErrorErrorType.RecordNotFound,
                _ => null,
            };
        }
    }
}