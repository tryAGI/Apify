
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum DatasetItemsPostContentEncoding
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
    public static class DatasetItemsPostContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetItemsPostContentEncoding value)
        {
            return value switch
            {
                DatasetItemsPostContentEncoding.Br => "br",
                DatasetItemsPostContentEncoding.Deflate => "deflate",
                DatasetItemsPostContentEncoding.Gzip => "gzip",
                DatasetItemsPostContentEncoding.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetItemsPostContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "br" => DatasetItemsPostContentEncoding.Br,
                "deflate" => DatasetItemsPostContentEncoding.Deflate,
                "gzip" => DatasetItemsPostContentEncoding.Gzip,
                "identity" => DatasetItemsPostContentEncoding.Identity,
                _ => null,
            };
        }
    }
}