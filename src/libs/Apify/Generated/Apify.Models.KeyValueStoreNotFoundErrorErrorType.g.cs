
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum KeyValueStoreNotFoundErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        RecordNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyValueStoreNotFoundErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyValueStoreNotFoundErrorErrorType value)
        {
            return value switch
            {
                KeyValueStoreNotFoundErrorErrorType.RecordNotFound => "record-not-found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyValueStoreNotFoundErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "record-not-found" => KeyValueStoreNotFoundErrorErrorType.RecordNotFound,
                _ => null,
            };
        }
    }
}