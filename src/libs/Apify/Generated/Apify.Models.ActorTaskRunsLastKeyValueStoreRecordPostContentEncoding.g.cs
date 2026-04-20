
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding
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
    public static class ActorTaskRunsLastKeyValueStoreRecordPostContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding value)
        {
            return value switch
            {
                ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding.Br => "br",
                ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding.Deflate => "deflate",
                ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding.Gzip => "gzip",
                ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding.Br,
                "deflate" => ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding.Deflate,
                "gzip" => ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding.Gzip,
                "identity" => ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding.Identity,
                _ => null,
            };
        }
    }
}