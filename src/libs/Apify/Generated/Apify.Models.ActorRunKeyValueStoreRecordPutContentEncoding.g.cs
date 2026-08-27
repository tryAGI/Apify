
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum ActorRunKeyValueStoreRecordPutContentEncoding
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
    public static class ActorRunKeyValueStoreRecordPutContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunKeyValueStoreRecordPutContentEncoding value)
        {
            return value switch
            {
                ActorRunKeyValueStoreRecordPutContentEncoding.Br => "br",
                ActorRunKeyValueStoreRecordPutContentEncoding.Deflate => "deflate",
                ActorRunKeyValueStoreRecordPutContentEncoding.Gzip => "gzip",
                ActorRunKeyValueStoreRecordPutContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunKeyValueStoreRecordPutContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActorRunKeyValueStoreRecordPutContentEncoding.Br,
                "deflate" => ActorRunKeyValueStoreRecordPutContentEncoding.Deflate,
                "gzip" => ActorRunKeyValueStoreRecordPutContentEncoding.Gzip,
                "identity" => ActorRunKeyValueStoreRecordPutContentEncoding.Identity,
                _ => null,
            };
        }
    }
}