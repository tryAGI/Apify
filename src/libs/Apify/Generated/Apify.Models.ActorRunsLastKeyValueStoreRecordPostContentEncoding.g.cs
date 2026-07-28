
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorRunsLastKeyValueStoreRecordPostContentEncoding
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
    public static class ActorRunsLastKeyValueStoreRecordPostContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunsLastKeyValueStoreRecordPostContentEncoding value)
        {
            return value switch
            {
                ActorRunsLastKeyValueStoreRecordPostContentEncoding.Br => "br",
                ActorRunsLastKeyValueStoreRecordPostContentEncoding.Deflate => "deflate",
                ActorRunsLastKeyValueStoreRecordPostContentEncoding.Gzip => "gzip",
                ActorRunsLastKeyValueStoreRecordPostContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunsLastKeyValueStoreRecordPostContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActorRunsLastKeyValueStoreRecordPostContentEncoding.Br,
                "deflate" => ActorRunsLastKeyValueStoreRecordPostContentEncoding.Deflate,
                "gzip" => ActorRunsLastKeyValueStoreRecordPostContentEncoding.Gzip,
                "identity" => ActorRunsLastKeyValueStoreRecordPostContentEncoding.Identity,
                _ => null,
            };
        }
    }
}