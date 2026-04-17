
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActRunsLastKeyValueStoreRecordPutContentEncoding
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
    public static class ActRunsLastKeyValueStoreRecordPutContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActRunsLastKeyValueStoreRecordPutContentEncoding value)
        {
            return value switch
            {
                ActRunsLastKeyValueStoreRecordPutContentEncoding.Br => "br",
                ActRunsLastKeyValueStoreRecordPutContentEncoding.Deflate => "deflate",
                ActRunsLastKeyValueStoreRecordPutContentEncoding.Gzip => "gzip",
                ActRunsLastKeyValueStoreRecordPutContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActRunsLastKeyValueStoreRecordPutContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActRunsLastKeyValueStoreRecordPutContentEncoding.Br,
                "deflate" => ActRunsLastKeyValueStoreRecordPutContentEncoding.Deflate,
                "gzip" => ActRunsLastKeyValueStoreRecordPutContentEncoding.Gzip,
                "identity" => ActRunsLastKeyValueStoreRecordPutContentEncoding.Identity,
                _ => null,
            };
        }
    }
}