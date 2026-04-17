
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActRunsLastKeyValueStoreRecordPostContentEncoding
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
    public static class ActRunsLastKeyValueStoreRecordPostContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActRunsLastKeyValueStoreRecordPostContentEncoding value)
        {
            return value switch
            {
                ActRunsLastKeyValueStoreRecordPostContentEncoding.Br => "br",
                ActRunsLastKeyValueStoreRecordPostContentEncoding.Deflate => "deflate",
                ActRunsLastKeyValueStoreRecordPostContentEncoding.Gzip => "gzip",
                ActRunsLastKeyValueStoreRecordPostContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActRunsLastKeyValueStoreRecordPostContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActRunsLastKeyValueStoreRecordPostContentEncoding.Br,
                "deflate" => ActRunsLastKeyValueStoreRecordPostContentEncoding.Deflate,
                "gzip" => ActRunsLastKeyValueStoreRecordPostContentEncoding.Gzip,
                "identity" => ActRunsLastKeyValueStoreRecordPostContentEncoding.Identity,
                _ => null,
            };
        }
    }
}