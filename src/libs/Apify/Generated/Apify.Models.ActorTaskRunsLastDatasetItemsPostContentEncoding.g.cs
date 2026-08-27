
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum ActorTaskRunsLastDatasetItemsPostContentEncoding
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
    public static class ActorTaskRunsLastDatasetItemsPostContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorTaskRunsLastDatasetItemsPostContentEncoding value)
        {
            return value switch
            {
                ActorTaskRunsLastDatasetItemsPostContentEncoding.Br => "br",
                ActorTaskRunsLastDatasetItemsPostContentEncoding.Deflate => "deflate",
                ActorTaskRunsLastDatasetItemsPostContentEncoding.Gzip => "gzip",
                ActorTaskRunsLastDatasetItemsPostContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorTaskRunsLastDatasetItemsPostContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActorTaskRunsLastDatasetItemsPostContentEncoding.Br,
                "deflate" => ActorTaskRunsLastDatasetItemsPostContentEncoding.Deflate,
                "gzip" => ActorTaskRunsLastDatasetItemsPostContentEncoding.Gzip,
                "identity" => ActorTaskRunsLastDatasetItemsPostContentEncoding.Identity,
                _ => null,
            };
        }
    }
}