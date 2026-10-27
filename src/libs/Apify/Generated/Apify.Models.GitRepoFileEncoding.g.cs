
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum GitRepoFileEncoding
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
        /// <summary>
        ///
        /// </summary>
        Utf8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GitRepoFileEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GitRepoFileEncoding value)
        {
            return value switch
            {
                GitRepoFileEncoding.Base64 => "base64",
                GitRepoFileEncoding.Utf8 => "utf-8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GitRepoFileEncoding? ToEnum(string value)
        {
            return value switch
            {
                "base64" => GitRepoFileEncoding.Base64,
                "utf-8" => GitRepoFileEncoding.Utf8,
                _ => null,
            };
        }
    }
}