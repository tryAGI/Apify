
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorRunsLastDatasetItemsPostContentEncoding
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
    public static class ActorRunsLastDatasetItemsPostContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunsLastDatasetItemsPostContentEncoding value)
        {
            return value switch
            {
                ActorRunsLastDatasetItemsPostContentEncoding.Br => "br",
                ActorRunsLastDatasetItemsPostContentEncoding.Deflate => "deflate",
                ActorRunsLastDatasetItemsPostContentEncoding.Gzip => "gzip",
                ActorRunsLastDatasetItemsPostContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunsLastDatasetItemsPostContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActorRunsLastDatasetItemsPostContentEncoding.Br,
                "deflate" => ActorRunsLastDatasetItemsPostContentEncoding.Deflate,
                "gzip" => ActorRunsLastDatasetItemsPostContentEncoding.Gzip,
                "identity" => ActorRunsLastDatasetItemsPostContentEncoding.Identity,
                _ => null,
            };
        }
    }
}