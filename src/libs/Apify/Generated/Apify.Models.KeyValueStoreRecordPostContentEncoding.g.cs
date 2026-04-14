
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum KeyValueStoreRecordPostContentEncoding
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
        /// <summary>
        /// 
        /// </summary>
        Identity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyValueStoreRecordPostContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyValueStoreRecordPostContentEncoding value)
        {
            return value switch
            {
                KeyValueStoreRecordPostContentEncoding.Br => "br",
                KeyValueStoreRecordPostContentEncoding.Deflate => "deflate",
                KeyValueStoreRecordPostContentEncoding.Gzip => "gzip",
                KeyValueStoreRecordPostContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyValueStoreRecordPostContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => KeyValueStoreRecordPostContentEncoding.Br,
                "deflate" => KeyValueStoreRecordPostContentEncoding.Deflate,
                "gzip" => KeyValueStoreRecordPostContentEncoding.Gzip,
                "identity" => KeyValueStoreRecordPostContentEncoding.Identity,
                _ => null,
            };
        }
    }
}