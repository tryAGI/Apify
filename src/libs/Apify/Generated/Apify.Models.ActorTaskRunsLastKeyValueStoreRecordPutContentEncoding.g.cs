
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding
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
    public static class ActorTaskRunsLastKeyValueStoreRecordPutContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding value)
        {
            return value switch
            {
                ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding.Br => "br",
                ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding.Deflate => "deflate",
                ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding.Gzip => "gzip",
                ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding.Br,
                "deflate" => ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding.Deflate,
                "gzip" => ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding.Gzip,
                "identity" => ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding.Identity,
                _ => null,
            };
        }
    }
}