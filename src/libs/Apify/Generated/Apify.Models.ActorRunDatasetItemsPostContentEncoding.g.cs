
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum ActorRunDatasetItemsPostContentEncoding
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
    public static class ActorRunDatasetItemsPostContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunDatasetItemsPostContentEncoding value)
        {
            return value switch
            {
                ActorRunDatasetItemsPostContentEncoding.Br => "br",
                ActorRunDatasetItemsPostContentEncoding.Deflate => "deflate",
                ActorRunDatasetItemsPostContentEncoding.Gzip => "gzip",
                ActorRunDatasetItemsPostContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunDatasetItemsPostContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActorRunDatasetItemsPostContentEncoding.Br,
                "deflate" => ActorRunDatasetItemsPostContentEncoding.Deflate,
                "gzip" => ActorRunDatasetItemsPostContentEncoding.Gzip,
                "identity" => ActorRunDatasetItemsPostContentEncoding.Identity,
                _ => null,
            };
        }
    }
}