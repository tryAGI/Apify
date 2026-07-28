
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorRunsLastKeyValueStoreRecordPutContentEncoding
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
    public static class ActorRunsLastKeyValueStoreRecordPutContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunsLastKeyValueStoreRecordPutContentEncoding value)
        {
            return value switch
            {
                ActorRunsLastKeyValueStoreRecordPutContentEncoding.Br => "br",
                ActorRunsLastKeyValueStoreRecordPutContentEncoding.Deflate => "deflate",
                ActorRunsLastKeyValueStoreRecordPutContentEncoding.Gzip => "gzip",
                ActorRunsLastKeyValueStoreRecordPutContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunsLastKeyValueStoreRecordPutContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActorRunsLastKeyValueStoreRecordPutContentEncoding.Br,
                "deflate" => ActorRunsLastKeyValueStoreRecordPutContentEncoding.Deflate,
                "gzip" => ActorRunsLastKeyValueStoreRecordPutContentEncoding.Gzip,
                "identity" => ActorRunsLastKeyValueStoreRecordPutContentEncoding.Identity,
                _ => null,
            };
        }
    }
}