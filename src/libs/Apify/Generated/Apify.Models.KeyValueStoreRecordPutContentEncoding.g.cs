
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum KeyValueStoreRecordPutContentEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Br,
        /// <summary>
        /// 
        /// </summary>
        Deflate,
        /// <summary>
        /// 
        /// </summary>
        Gzip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyValueStoreRecordPutContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyValueStoreRecordPutContentEncoding value)
        {
            return value switch
            {
                KeyValueStoreRecordPutContentEncoding.Br => "br",
                KeyValueStoreRecordPutContentEncoding.Deflate => "deflate",
                KeyValueStoreRecordPutContentEncoding.Gzip => "gzip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyValueStoreRecordPutContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => KeyValueStoreRecordPutContentEncoding.Br,
                "deflate" => KeyValueStoreRecordPutContentEncoding.Deflate,
                "gzip" => KeyValueStoreRecordPutContentEncoding.Gzip,
                _ => null,
            };
        }
    }
}