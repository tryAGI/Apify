
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActRunsLastDatasetItemsPostContentEncoding
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
    public static class ActRunsLastDatasetItemsPostContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActRunsLastDatasetItemsPostContentEncoding value)
        {
            return value switch
            {
                ActRunsLastDatasetItemsPostContentEncoding.Br => "br",
                ActRunsLastDatasetItemsPostContentEncoding.Deflate => "deflate",
                ActRunsLastDatasetItemsPostContentEncoding.Gzip => "gzip",
                ActRunsLastDatasetItemsPostContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActRunsLastDatasetItemsPostContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => ActRunsLastDatasetItemsPostContentEncoding.Br,
                "deflate" => ActRunsLastDatasetItemsPostContentEncoding.Deflate,
                "gzip" => ActRunsLastDatasetItemsPostContentEncoding.Gzip,
                "identity" => ActRunsLastDatasetItemsPostContentEncoding.Identity,
                _ => null,
            };
        }
    }
}