
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorRunKeyValueStoreRecordPostContentEncoding
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
    public static class ActorRunKeyValueStoreRecordPostContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunKeyValueStoreRecordPostContentEncoding value)
        {
            return value switch
            {
                ActorRunKeyValueStoreRecordPostContentEncoding.Br => "br",
                ActorRunKeyValueStoreRecordPostContentEncoding.Deflate => "deflate",
                ActorRunKeyValueStoreRecordPostContentEncoding.Gzip => "gzip",
                ActorRunKeyValueStoreRecordPostContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunKeyValueStoreRecordPostContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActorRunKeyValueStoreRecordPostContentEncoding.Br,
                "deflate" => ActorRunKeyValueStoreRecordPostContentEncoding.Deflate,
                "gzip" => ActorRunKeyValueStoreRecordPostContentEncoding.Gzip,
                "identity" => ActorRunKeyValueStoreRecordPostContentEncoding.Identity,
                _ => null,
            };
        }
    }
}